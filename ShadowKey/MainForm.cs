using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ShadowKey.Enum;
using ShadowKey.Extenstions;
using static MaterialSkin.Controls.FlexibleMaterialForm;
using Microsoft.VisualBasic;

namespace ShadowKey
{
    public partial class MainForm : MaterialForm
    {
        public static string Username = string.Empty;
        private DatabaseClass databaseClass = new DatabaseClass();
        private MaterialSkinManager skinManager = MaterialSkinManager.Instance;
        public MainForm()
        {
            InitializeComponent();
            skinManager.AddFormToManage(this);
            skinManager.ColorScheme = new ColorScheme(Primary.Purple600, Primary.Purple700, Primary.Purple900, Accent.Purple100, TextShade.WHITE);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            this.Sizable = false;
            Task.Run(() => CustomControlsBackColor());
            materialSwitch1.Checked = false;
        }
        private Task loadAllUsers()
        {
            IEnumerable<string> users = databaseClass.GetData("username");
            var x = users.Where(q => q != Username);
            materialComboBox1.Items.AddRange(x.ToArray());
            return Task.CompletedTask;
        }
        private void CustomControlsBackColor(bool isDark = true)
        {
            Control[] targetControls = new Control[] { picPanel, panel1, pictureBox1 };
            for (int i = 0; i < targetControls.Length; i++)
            {
                Control control = targetControls[i];
                if (isDark)
                    control.BackColor = Color.FromArgb(40, 41, 40);
                else
                    control.BackColor = Color.FromArgb(219, 219, 219);
            }
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
            {
                skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                Task.Run(() => CustomControlsBackColor(false));

            }
            else
            {
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
                Task.Run(() => CustomControlsBackColor());
            }
            _Refresh();
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            dialog.InitialDirectory = $@"C:\Users\{Environment.UserName}\Pictures";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = dialog.FileName;
                txtBoxfilePath.Text = filePath;
                pictureBox1.ImageLocation = filePath;
            }
        }

        private void encodeBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtBoxfilePath.Text))
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    MaterialMessageBox.Show(this, "Please select an image first.", "Image not found", MessageBoxButtons.OK, MessageBoxIcon.Error, false, ButtonsPosition.Center);
                    _Refresh();
                });
                return;
            }
            if (string.IsNullOrEmpty(keyTextBox.Text))
            {
                MaterialMessageBox.Show(this, "Encryption key is required", "Key empty", MessageBoxButtons.OK, MessageBoxIcon.Error, false, ButtonsPosition.Center);
                _Refresh();
                return;
            }
            int keyLength = int.Parse(keyLengthComboBox.SelectedItem.ToString());
            int keyBytes = keyLength / 8;
            var requiredChars = keyBytes;
            if (keyTextBox.Text.Length != requiredChars)
            {
                string message = $"Encryption key must be exactly {requiredChars} characters long.\n"
                              + $"Your current key has {keyTextBox.Text.Length} characters.\n"
                              + "Please try again or press on the key random generator";

                MaterialMessageBox.Show(this,
                    message,
                    "Invalid Key Length",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    false,
                    ButtonsPosition.Center);
                _Refresh();
                return;
            }
            SetStatus("Encrypting message ..", Color.FromArgb(255, 204, 0));
            Image image = Image.FromFile(txtBoxfilePath.Text);
            var plainText = txtBoxMessage.Text;
            var hashPlainText = CreateHash(plainText);
            string encyrptedMessage = EncryptString(plainText, keyTextBox.Text, keyBytes);
            encyrptedMessage += "\0";
            if (!Directory.Exists(materialComboBox1.Text))
                Directory.CreateDirectory(materialComboBox1.Text);
            var items = GetImageExtensionAndFormat(txtBoxfilePath.Text);
            ImageFormat imageFormat = items.Item2;
            string extension = items.Item1;
            string protectedFilename = $@"{Directory.GetCurrentDirectory()}\{materialComboBox1.Text}\{Path.GetFileName(txtBoxfilePath.Text).Substring(0, Path.GetFileName(txtBoxfilePath.Text).Length - 4)}_Protected{extension}";
            image.SaveImageWithSecret(encyrptedMessage, protectedFilename, imageFormat, StegoKeySize.Two);
            File.WriteAllText($@"{Directory.GetCurrentDirectory()}\{materialComboBox1.Text}\hash[{Username}].txt", hashPlainText);
            SetStatus("Successfully encrypt message & create hash!", Color.FromArgb(0, 255, 153));
            Thread.Sleep(new Random().Next(800,2000));
            Task.Run(async () =>
            {
                string toUsername = materialComboBox1.Text;
                SetStatus($"Sending encrypt message to {toUsername}...", Color.Magenta);
                string toEmail = databaseClass.GetEmailByUsername(toUsername);
                var isSent = await Dropbox.UploadFile(toUsername, $"{Username}_Message{Path.GetExtension(txtBoxfilePath.Text)}", protectedFilename);
                if (isSent)
                {
                    MailClass.SendMailTo(toEmail, toUsername, hashPlainText, keyTextBox.Text, Username);
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        MaterialMessageBox.Show("The secret message sent successfully!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, false, ButtonsPosition.Fill);
                        new Thread(() =>
                        {
                            SetStatus($"Encrypt message sent successfully to {toUsername}...", Color.FromArgb(0, 204, 0));
                            Thread.Sleep(2400);
                            SetStatus($"idle..", Color.FromArgb(255, 255, 255));

                        }).Start();
                        _Refresh();
                    });
                }
                else
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        MaterialMessageBox.Show("Failed to send secert message\nMay be the cloud not connected!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, false, ButtonsPosition.Fill);
                        _Refresh();
                    });
                }
            });
            Thread.Sleep((int)0.9);
            _Refresh();
        }
        private (string, ImageFormat) GetImageExtensionAndFormat(string filename)
        {
            ImageFormat imageFormat = ImageFormat.Bmp;
            string imageExtension = Path.GetExtension(filename).ToLower();
            switch (imageExtension)
            {
                case ".png":
                    imageFormat = ImageFormat.Png;
                    break;
                case ".gif":
                    imageFormat = ImageFormat.Gif;
                    break;

                case ".jpg":
                    imageFormat = ImageFormat.Jpeg;
                    break;

                case ".bmp":
                    imageFormat = ImageFormat.Bmp;
                    break;

                case ".tiff":
                    imageFormat = ImageFormat.Tiff;
                    break;

                case ".emf":
                    imageFormat = ImageFormat.Emf;
                    break;

                case ".wmf":
                    imageFormat = ImageFormat.Wmf;
                    break;
                default:
                    imageFormat = ImageFormat.Bmp;
                    break;
            }
            return (imageExtension, imageFormat);
        }
        private void decodebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxfilePath.Text))
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    MaterialMessageBox.Show(this, "Please select an image first.", "Image not found", MessageBoxButtons.OK, MessageBoxIcon.Error, false, ButtonsPosition.Center);
                    _Refresh();
                });
                return;
            }
            if (string.IsNullOrEmpty(keyTextBox.Text))
            {
                MaterialMessageBox.Show(this, "Encryption key is required", "Key empty", MessageBoxButtons.OK, MessageBoxIcon.Error, false, ButtonsPosition.Center);
                _Refresh();
                return;
            }
            int keyLength = keyTextBox.Text.Length;
            int indexOfKeyLength = 0;
            if (keyLength == 24)
                indexOfKeyLength = 1;
            if (keyLength == 32)
                indexOfKeyLength = 2;
            keyLengthComboBox.SelectedIndex = indexOfKeyLength;
            SetStatus("Decypting message ...", Color.FromArgb(9, 172, 214));
            Image image = Image.FromFile(txtBoxfilePath.Text);
            var items = GetImageExtensionAndFormat(txtBoxfilePath.Text);
            ImageFormat imageFormat = items.Item2;
            var result = image.GetSecretFromImage(imageFormat, StegoKeySize.Two);
            string decyrptedMessage = DecryptString(result, keyTextBox.Text, keyLength).TrimEnd('\0');
            var newHash = CreateHash(decyrptedMessage);
            var oldHash = hashTextBox.Text;
            if (oldHash == newHash)
            {
                txtBoxMessage.Text = decyrptedMessage;
            }
            else
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    MaterialMessageBox.Show(this,
                    "This message has likely been modified. Original content cannot be trusted.",
                    "Data Tampering Suspected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    , false, ButtonsPosition.Center);
                    _Refresh();
                });
            }
            SetStatus("idle..", Color.FromArgb(255, 255, 255));

        }
        private void materialButton1_Click(object sender, EventArgs e)
        {

            Task.Run(async () =>
            {
                string toUsername = materialComboBox1.Text;
                string toEmail = databaseClass.GetEmailByUsername(toUsername);
                var isSent = await Dropbox.UploadFile(toUsername, $"{Username}_Message{Path.GetExtension(txtBoxfilePath.Text)}", txtBoxfilePath.Text);
                if (isSent)
                {
                    MailClass.SendMailTo(toEmail, toUsername, System.IO.File.ReadAllText(@".\Hash.txt"), "1234567812345678", Username);
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        MaterialMessageBox.Show("The secret message sent successfully!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, false, ButtonsPosition.Fill);
                        _Refresh();
                    });
                }
                else
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        MaterialMessageBox.Show("Failed to send secert message\nMay be the cloud not connected!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, false, ButtonsPosition.Fill);
                        _Refresh();
                    });
                }
            });
            Thread.Sleep((int)0.9);
        }

        private async void materialButton2_Click(object sender, EventArgs e)
        {
            var files = await Dropbox.GetFiles(Username);
            if (files.Item1 != null)
                this.BeginInvoke((MethodInvoker)delegate
                {
                    MaterialMessageBox.Show($"{(files.Item2.Split('\n').Length > 0 ? $"You have [{files.Item2.Split('\n').Count():N0}] secret message!" : "You don't have any message")}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Question, false, ButtonsPosition.Fill);
                    _Refresh();
                });
            else this.BeginInvoke((MethodInvoker)delegate
            {
                MaterialMessageBox.Show($"You don't have any message", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, false, ButtonsPosition.Fill);
                _Refresh();
            });
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private string EncryptString(string plainText, string password, int keyBytes)
        {
            using (Aes aesAlg = Aes.Create())
            {
                using (var sha = SHA256.Create())
                {
                    byte[] key = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                    byte[] truncatedKey = new byte[keyBytes];
                    Array.Copy(key, truncatedKey, keyBytes);
                    aesAlg.Key = truncatedKey;
                }

                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        private string DecryptString(string cipherText, string password, int keyBytes)
        {
            using (Aes aesAlg = Aes.Create())
            {
                using (var sha = SHA256.Create())
                {
                    byte[] key = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                    byte[] truncatedKey = new byte[keyBytes];
                    Array.Copy(key, truncatedKey, keyBytes);
                    aesAlg.Key = truncatedKey;
                }

                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                try
                {
                    using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
                catch (CryptographicException)
                {
                    return "Decryption failed - incorrect key";
                }
                catch (FormatException ex)
                {
                    return "Invalid data format";
                }
            }
        }
        string CreateHash(string text)
        {
            string result = string.Empty;
            using (MD5 md5 = MD5.Create())
            {
                try
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("x2"));
                    }
                    result = sb.ToString();
                }
                catch
                {
                    result = "Error in convert to md5 :(";
                }
            }
            return result;
        }
        private async Task CheckInbox()
        {
            var files = await Dropbox.GetFiles(Username);
            if (files.Item2.Split('\n').Length == 0)
                return;
            Thread.Sleep(200);
            DialogResult answerUser = 0;
            this.BeginInvoke((MethodInvoker)delegate
            {
                answerUser = MaterialMessageBox.Show(this, $"You have [{files.Item2.Split('\n').Count():N0}] secret message!\nWant to see it?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, false);
                _Refresh();
                if (answerUser == DialogResult.Yes)
                {
                    var targetMessage = string.Empty;
                    var sendersNames = files.Item1.Split('\n');
                    if (sendersNames.Length > 1)
                    {
                        string formatted = $@"
Who do you want to read a message from?
{string.Join("        ", sendersNames
              .Select((name, index) => $"[{index + 1}] {name}"))}";

                        var choice = 0;
                        if (!int.TryParse(Interaction.InputBox(formatted, this.Text, "1"), out choice))
                            return;
                        targetMessage = files.Item2.Split('\n').Select(filename => filename.StartsWith(sendersNames[(choice - 1)])).ToString();
                    }
                    else
                    {
                        targetMessage = files.Item2;
                    }
                    Task.Run(async () =>
                    {
                        SetStatus("Downloading files, Please wait...", Color.FromArgb(9, 172, 214));
                        var tempFile = await DownloadSecretMessage(targetMessage);
                        if (tempFile != null)
                            SetStatus("Successfully downloaded!", Color.FromArgb(0, 200, 0));
                        else
                            SetStatus("Failed to download message!", Color.FromArgb(255, 68, 68));
                        pictureBox1.ImageLocation = tempFile;
                        txtBoxfilePath.Text = tempFile;
                        Thread.Sleep(200);
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            MaterialMessageBox.Show($"🔐 Make sure to input the 𝗛𝗔𝗦𝗛 that you received on your 𝗘𝗠𝗔𝗜𝗟", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, false, ButtonsPosition.Fill);
                        });
                        SetStatus("idle..", Color.FromArgb(255, 255, 255));

                        _Refresh();
                        Application.DoEvents();
                    });
                  
                }
            });
        }
        private async Task<string> DownloadSecretMessage(string fileName)
        {
            try
            {
                var tempFilePath = Path.Combine(
        Path.GetTempPath(),
        fileName);
                await Dropbox.DownloadFile(Username, fileName, tempFilePath);

                return tempFilePath;
            }
            catch
            {

            }
            return null;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {

                Task.Run(async () => await loadAllUsers());
                Task.Run(async () =>
                {
                    Dropbox.Initialize();
                    await CheckInbox();
                });
            }).Start();
            _Refresh();
            loginNamelbl.Text += Username;

        }
        private void _Refresh()
        {
            this.statusLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNamelbl.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh();
        }
        public void SetStatus(string message, Color color)
        {
            if (statusLabel.InvokeRequired)
            {
                statusLabel.Invoke(new Action(() => {
                    statusLabel.Text = $"Status: {message}";
                    statusLabel.ForeColor = color;
                }));
            }
            else
            {
                statusLabel.Text = $"Status: {message}";
                statusLabel.ForeColor = color;
            }
        }
        public static string GenerateAesKey(int keySizeInBits)
        {
            string ascii = "qwertyuiopasdfghjklzxcvbnm1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            StringBuilder randomKey = new StringBuilder();
            Random random = new Random();
            if (keySizeInBits != 128 && keySizeInBits != 192 && keySizeInBits != 256)
                throw new ArgumentException("Error please choose the key length");
            int keyLengthInBytes = keySizeInBits / 8;
            for (int i = 0; i < keyLengthInBytes; i++)
            {
                randomKey.Append(ascii[random.Next(0, ascii.Length)]);
            }
            return randomKey.ToString();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            int keySize = 128;
            if (keyLengthComboBox.SelectedItem != null)
            {
                keySize = int.Parse(keyLengthComboBox.SelectedItem.ToString());
            }
            string encryptionKey = GenerateAesKey(keySize);
            keyTextBox.Text = encryptionKey;

        }
    }
}

using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ShadowKey
{
    public partial class LoginForm : MaterialForm
    {
        DatabaseClass database = new DatabaseClass();
        readonly MaterialSkinManager skinManager = MaterialSkinManager.Instance;
        public LoginForm()
        {
            InitializeComponent();
            skinManager.EnforceBackcolorOnAllComponents = true;
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Purple600, Primary.Purple700, Primary.Purple900, Accent.Purple100, TextShade.WHITE);
            this.Sizable = false;
            skinManager.AddFormToManage(this);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string username = loginUsernameTextBox.Text.ToLower().Trim();
            string password = loginPasswordTextBox.Text;
            if (string.IsNullOrEmpty(loginUsernameTextBox.Text) || string.IsNullOrWhiteSpace(loginUsernameTextBox.Text) || string.IsNullOrEmpty(loginPasswordTextBox.Text) || string.IsNullOrWhiteSpace(loginPasswordTextBox.Text))
            {
                MessageBox.Show("Username or password most be not empty!");
                return;
            }
            bool isValid = database.Login(username, password);

            if (!isValid)
            {
                MaterialMessageBox.Show("Username or password is incorrect!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error,false,FlexibleMaterialForm.ButtonsPosition.Fill);
            }
            else
            {
                MainForm.Username = username;
                MaterialMessageBox.Show($"Welcome {loginUsernameTextBox.Text}", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information, false);

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
            this.Show();
        }
    }
}

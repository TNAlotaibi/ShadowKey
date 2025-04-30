using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ShadowKey
{
    public partial class RegisterForm : MaterialForm
    {
        DatabaseClass databaseClass = new DatabaseClass();
        MaterialSkinManager skinManager = MaterialSkinManager.Instance;
        public RegisterForm()
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
            var itemsUserAndEmail = databaseClass.getUsernameAndEmail();
            if (string.IsNullOrEmpty(txtBoxUsername.Text) || string.IsNullOrWhiteSpace(txtBoxUsername.Text) || string.IsNullOrEmpty(txtBoxPassword.Text) || string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MaterialMessageBox.Show("Username or password must be not empty!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error, false, FlexibleMaterialForm.ButtonsPosition.Fill);
                return;
            }
            foreach (var items in itemsUserAndEmail)
            {
                if (items.Split(' ')[0] == txtBoxUsername.Text.ToLower() || items.Split(' ')[1] == txtBoxEmail.Text.ToLower())
                {
                    MaterialMessageBox.Show("Username or email isn't available!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error, false,FlexibleMaterialForm.ButtonsPosition.Fill);
                    break;
                }
            }

            string[] registerData = new string[] { txtBoxUsername.Text, txtBoxPassword.Text, txtBoxEmail.Text };
            bool isCreated = databaseClass.register(registerData);
            if (isCreated)
            {
                MaterialMessageBox.Show("Created successfully!", "Welcome @" + txtBoxUsername.Text, false);
                this.Close();
            }
            else
                MaterialMessageBox.Show("Something went wrong!", "Failed to register", MessageBoxButtons.OK, MessageBoxIcon.Error, false, FlexibleMaterialForm.ButtonsPosition.Fill);

        }

        private void toLoginFrom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

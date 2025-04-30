namespace ShadowKey
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.toLoginFrom = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(56, 243);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(117, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Register";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.AnimateReadOnly = false;
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsername.Depth = 0;
            this.txtBoxUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxUsername.Hint = "Username";
            this.txtBoxUsername.LeadingIcon = null;
            this.txtBoxUsername.Location = new System.Drawing.Point(12, 74);
            this.txtBoxUsername.MaxLength = 50;
            this.txtBoxUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxUsername.Multiline = false;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(211, 50);
            this.txtBoxUsername.TabIndex = 1;
            this.txtBoxUsername.Text = "";
            this.txtBoxUsername.TrailingIcon = null;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.AnimateReadOnly = false;
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Depth = 0;
            this.txtBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPassword.Hint = "Password";
            this.txtBoxPassword.LeadingIcon = null;
            this.txtBoxPassword.Location = new System.Drawing.Point(12, 130);
            this.txtBoxPassword.MaxLength = 50;
            this.txtBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPassword.Multiline = false;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(211, 50);
            this.txtBoxPassword.TabIndex = 2;
            this.txtBoxPassword.Text = "";
            this.txtBoxPassword.TrailingIcon = null;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.AnimateReadOnly = false;
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEmail.Depth = 0;
            this.txtBoxEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEmail.Hint = "Email";
            this.txtBoxEmail.LeadingIcon = null;
            this.txtBoxEmail.Location = new System.Drawing.Point(12, 186);
            this.txtBoxEmail.MaxLength = 50;
            this.txtBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxEmail.Multiline = false;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(211, 50);
            this.txtBoxEmail.TabIndex = 3;
            this.txtBoxEmail.Text = "";
            this.txtBoxEmail.TrailingIcon = null;
            // 
            // toLoginFrom
            // 
            this.toLoginFrom.ActiveLinkColor = System.Drawing.Color.Purple;
            this.toLoginFrom.AutoSize = true;
            this.toLoginFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLoginFrom.LinkColor = System.Drawing.Color.Silver;
            this.toLoginFrom.Location = new System.Drawing.Point(190, 269);
            this.toLoginFrom.Name = "toLoginFrom";
            this.toLoginFrom.Size = new System.Drawing.Size(40, 16);
            this.toLoginFrom.TabIndex = 4;
            this.toLoginFrom.TabStop = true;
            this.toLoginFrom.Text = "Login";
            this.toLoginFrom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.toLoginFrom_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 288);
            this.Controls.Add(this.toLoginFrom);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.materialButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox txtBoxUsername;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox txtBoxEmail;
        private System.Windows.Forms.LinkLabel toLoginFrom;
    }
}
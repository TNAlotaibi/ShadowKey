namespace ShadowKey
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.loginUsernameTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.loginPasswordTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            this.materialButton1.Location = new System.Drawing.Point(64, 178);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(120, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Login";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.AllowPromptAsInput = true;
            this.loginUsernameTextBox.AnimateReadOnly = false;
            this.loginUsernameTextBox.AsciiOnly = false;
            this.loginUsernameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginUsernameTextBox.BeepOnError = false;
            this.loginUsernameTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.loginUsernameTextBox.Depth = 0;
            this.loginUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginUsernameTextBox.HidePromptOnLeave = false;
            this.loginUsernameTextBox.HideSelection = true;
            this.loginUsernameTextBox.Hint = "Username";
            this.loginUsernameTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.loginUsernameTextBox.LeadingIcon = null;
            this.loginUsernameTextBox.Location = new System.Drawing.Point(5, 71);
            this.loginUsernameTextBox.Mask = "";
            this.loginUsernameTextBox.MaxLength = 32767;
            this.loginUsernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.PasswordChar = '\0';
            this.loginUsernameTextBox.PrefixSuffixText = null;
            this.loginUsernameTextBox.PromptChar = '_';
            this.loginUsernameTextBox.ReadOnly = false;
            this.loginUsernameTextBox.RejectInputOnFirstFailure = false;
            this.loginUsernameTextBox.ResetOnPrompt = true;
            this.loginUsernameTextBox.ResetOnSpace = true;
            this.loginUsernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginUsernameTextBox.SelectedText = "";
            this.loginUsernameTextBox.SelectionLength = 0;
            this.loginUsernameTextBox.SelectionStart = 0;
            this.loginUsernameTextBox.ShortcutsEnabled = true;
            this.loginUsernameTextBox.Size = new System.Drawing.Size(250, 48);
            this.loginUsernameTextBox.SkipLiterals = true;
            this.loginUsernameTextBox.TabIndex = 1;
            this.loginUsernameTextBox.TabStop = false;
            this.loginUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginUsernameTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.loginUsernameTextBox.TrailingIcon = null;
            this.loginUsernameTextBox.UseSystemPasswordChar = false;
            this.loginUsernameTextBox.ValidatingType = null;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.AllowPromptAsInput = true;
            this.loginPasswordTextBox.AnimateReadOnly = false;
            this.loginPasswordTextBox.AsciiOnly = false;
            this.loginPasswordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginPasswordTextBox.BeepOnError = false;
            this.loginPasswordTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.loginPasswordTextBox.Depth = 0;
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginPasswordTextBox.HidePromptOnLeave = false;
            this.loginPasswordTextBox.HideSelection = true;
            this.loginPasswordTextBox.Hint = "Password";
            this.loginPasswordTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.loginPasswordTextBox.LeadingIcon = null;
            this.loginPasswordTextBox.Location = new System.Drawing.Point(5, 125);
            this.loginPasswordTextBox.Mask = "";
            this.loginPasswordTextBox.MaxLength = 32767;
            this.loginPasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '●';
            this.loginPasswordTextBox.PrefixSuffixText = null;
            this.loginPasswordTextBox.PromptChar = '_';
            this.loginPasswordTextBox.ReadOnly = false;
            this.loginPasswordTextBox.RejectInputOnFirstFailure = false;
            this.loginPasswordTextBox.ResetOnPrompt = true;
            this.loginPasswordTextBox.ResetOnSpace = true;
            this.loginPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginPasswordTextBox.SelectedText = "";
            this.loginPasswordTextBox.SelectionLength = 0;
            this.loginPasswordTextBox.SelectionStart = 0;
            this.loginPasswordTextBox.ShortcutsEnabled = true;
            this.loginPasswordTextBox.Size = new System.Drawing.Size(250, 48);
            this.loginPasswordTextBox.SkipLiterals = true;
            this.loginPasswordTextBox.TabIndex = 2;
            this.loginPasswordTextBox.TabStop = false;
            this.loginPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginPasswordTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.loginPasswordTextBox.TrailingIcon = null;
            this.loginPasswordTextBox.UseSystemPasswordChar = true;
            this.loginPasswordTextBox.ValidatingType = null;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Purple;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(200, 213);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 233);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginUsernameTextBox);
            this.Controls.Add(this.materialButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox loginUsernameTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox loginPasswordTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
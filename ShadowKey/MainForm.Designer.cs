namespace ShadowKey
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.encodeBtn = new MaterialSkin.Controls.MaterialButton();
            this.decodebtn = new MaterialSkin.Controls.MaterialButton();
            this.loadImage = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxMessage = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtBoxfilePath = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.hashTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.keyLengthComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.keyTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.loginNamelbl = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.btnGenerateKey = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.picPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picPanel
            // 
            this.picPanel.Controls.Add(this.pictureBox1);
            this.picPanel.Location = new System.Drawing.Point(521, 219);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(275, 205);
            this.picPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.materialSwitch1);
            this.panel1.Controls.Add(this.encodeBtn);
            this.panel1.Controls.Add(this.decodebtn);
            this.panel1.Location = new System.Drawing.Point(2, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 43);
            this.panel1.TabIndex = 2;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(379, 6);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(115, 29);
            this.materialButton2.TabIndex = 10;
            this.materialButton2.Text = "Check Inbox";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(277, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(94, 30);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Send";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(731, 3);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(58, 37);
            this.materialSwitch1.TabIndex = 7;
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // encodeBtn
            // 
            this.encodeBtn.AutoSize = false;
            this.encodeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.encodeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.encodeBtn.Depth = 0;
            this.encodeBtn.HighEmphasis = true;
            this.encodeBtn.Icon = null;
            this.encodeBtn.Location = new System.Drawing.Point(5, 6);
            this.encodeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.encodeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.encodeBtn.Name = "encodeBtn";
            this.encodeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.encodeBtn.Size = new System.Drawing.Size(110, 30);
            this.encodeBtn.TabIndex = 4;
            this.encodeBtn.Text = "Hide Message";
            this.encodeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.encodeBtn.UseAccentColor = false;
            this.encodeBtn.UseVisualStyleBackColor = true;
            this.encodeBtn.Click += new System.EventHandler(this.encodeBtn_Click);
            // 
            // decodebtn
            // 
            this.decodebtn.AutoSize = false;
            this.decodebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.decodebtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.decodebtn.Depth = 0;
            this.decodebtn.HighEmphasis = true;
            this.decodebtn.Icon = null;
            this.decodebtn.Location = new System.Drawing.Point(119, 6);
            this.decodebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.decodebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.decodebtn.Name = "decodebtn";
            this.decodebtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.decodebtn.Size = new System.Drawing.Size(142, 30);
            this.decodebtn.TabIndex = 8;
            this.decodebtn.Text = "Extract Message";
            this.decodebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.decodebtn.UseAccentColor = false;
            this.decodebtn.UseVisualStyleBackColor = true;
            this.decodebtn.Click += new System.EventHandler(this.decodebtn_Click);
            // 
            // loadImage
            // 
            this.loadImage.AutoSize = false;
            this.loadImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loadImage.Depth = 0;
            this.loadImage.HighEmphasis = true;
            this.loadImage.Icon = null;
            this.loadImage.Location = new System.Drawing.Point(594, 431);
            this.loadImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loadImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadImage.Name = "loadImage";
            this.loadImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loadImage.Size = new System.Drawing.Size(130, 31);
            this.loadImage.TabIndex = 3;
            this.loadImage.Text = "Select Image";
            this.loadImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loadImage.UseAccentColor = false;
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.AnimateReadOnly = false;
            this.txtBoxMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxMessage.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxMessage.Depth = 0;
            this.txtBoxMessage.HideSelection = true;
            this.txtBoxMessage.Hint = "Message";
            this.txtBoxMessage.Location = new System.Drawing.Point(2, 259);
            this.txtBoxMessage.MaxLength = 32767;
            this.txtBoxMessage.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.PasswordChar = '\0';
            this.txtBoxMessage.ReadOnly = false;
            this.txtBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxMessage.SelectedText = "";
            this.txtBoxMessage.SelectionLength = 0;
            this.txtBoxMessage.SelectionStart = 0;
            this.txtBoxMessage.ShortcutsEnabled = true;
            this.txtBoxMessage.Size = new System.Drawing.Size(365, 172);
            this.txtBoxMessage.TabIndex = 6;
            this.txtBoxMessage.TabStop = false;
            this.txtBoxMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxMessage.UseSystemPasswordChar = false;
            // 
            // txtBoxfilePath
            // 
            this.txtBoxfilePath.AnimateReadOnly = false;
            this.txtBoxfilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxfilePath.Depth = 0;
            this.txtBoxfilePath.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxfilePath.Hint = "File path (READ ONLY)";
            this.txtBoxfilePath.LeadingIcon = null;
            this.txtBoxfilePath.Location = new System.Drawing.Point(2, 156);
            this.txtBoxfilePath.MaxLength = 50;
            this.txtBoxfilePath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxfilePath.Multiline = false;
            this.txtBoxfilePath.Name = "txtBoxfilePath";
            this.txtBoxfilePath.Size = new System.Drawing.Size(795, 50);
            this.txtBoxfilePath.TabIndex = 7;
            this.txtBoxfilePath.Text = "";
            this.txtBoxfilePath.TrailingIcon = null;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Send to";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(3, 206);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(364, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 9;
            // 
            // hashTextBox
            // 
            this.hashTextBox.AnimateReadOnly = false;
            this.hashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hashTextBox.Depth = 0;
            this.hashTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hashTextBox.Hint = "Message Integrity Hash";
            this.hashTextBox.LeadingIcon = null;
            this.hashTextBox.Location = new System.Drawing.Point(2, 521);
            this.hashTextBox.MaxLength = 50;
            this.hashTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.hashTextBox.Multiline = false;
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.Size = new System.Drawing.Size(794, 50);
            this.hashTextBox.TabIndex = 10;
            this.hashTextBox.Text = "";
            this.hashTextBox.TrailingIcon = null;
            // 
            // keyLengthComboBox
            // 
            this.keyLengthComboBox.AutoResize = false;
            this.keyLengthComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.keyLengthComboBox.Depth = 0;
            this.keyLengthComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.keyLengthComboBox.DropDownHeight = 174;
            this.keyLengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyLengthComboBox.DropDownWidth = 121;
            this.keyLengthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.keyLengthComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.keyLengthComboBox.FormattingEnabled = true;
            this.keyLengthComboBox.Hint = "Encryption Strength";
            this.keyLengthComboBox.IntegralHeight = false;
            this.keyLengthComboBox.ItemHeight = 43;
            this.keyLengthComboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.keyLengthComboBox.Location = new System.Drawing.Point(215, 434);
            this.keyLengthComboBox.MaxDropDownItems = 4;
            this.keyLengthComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.keyLengthComboBox.Name = "keyLengthComboBox";
            this.keyLengthComboBox.Size = new System.Drawing.Size(152, 49);
            this.keyLengthComboBox.StartIndex = 0;
            this.keyLengthComboBox.TabIndex = 12;
            // 
            // keyTextBox
            // 
            this.keyTextBox.AllowPromptAsInput = true;
            this.keyTextBox.AnimateReadOnly = false;
            this.keyTextBox.AsciiOnly = false;
            this.keyTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.keyTextBox.BeepOnError = false;
            this.keyTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.keyTextBox.Depth = 0;
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.keyTextBox.HidePromptOnLeave = false;
            this.keyTextBox.HideSelection = true;
            this.keyTextBox.Hint = "Encryption Key";
            this.keyTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.keyTextBox.LeadingIcon = null;
            this.keyTextBox.Location = new System.Drawing.Point(4, 435);
            this.keyTextBox.Mask = "";
            this.keyTextBox.MaxLength = 32767;
            this.keyTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.PasswordChar = '\0';
            this.keyTextBox.PrefixSuffixText = null;
            this.keyTextBox.PromptChar = '_';
            this.keyTextBox.ReadOnly = false;
            this.keyTextBox.RejectInputOnFirstFailure = false;
            this.keyTextBox.ResetOnPrompt = true;
            this.keyTextBox.ResetOnSpace = true;
            this.keyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.keyTextBox.SelectedText = "";
            this.keyTextBox.SelectionLength = 0;
            this.keyTextBox.SelectionStart = 0;
            this.keyTextBox.ShortcutsEnabled = true;
            this.keyTextBox.Size = new System.Drawing.Size(198, 48);
            this.keyTextBox.SkipLiterals = true;
            this.keyTextBox.TabIndex = 11;
            this.keyTextBox.TabStop = false;
            this.keyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.keyTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.keyTextBox.TrailingIcon = null;
            this.keyTextBox.UseSystemPasswordChar = false;
            this.keyTextBox.ValidatingType = null;
            // 
            // loginNamelbl
            // 
            this.loginNamelbl.AutoSize = true;
            this.loginNamelbl.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNamelbl.Location = new System.Drawing.Point(5, 67);
            this.loginNamelbl.Name = "loginNamelbl";
            this.loginNamelbl.Size = new System.Drawing.Size(119, 21);
            this.loginNamelbl.TabIndex = 13;
            this.loginNamelbl.Text = "Login Name @";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Silver;
            this.statusLabel.Location = new System.Drawing.Point(3, 584);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(122, 23);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "Status : idle..";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.AutoSize = false;
            this.btnGenerateKey.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerateKey.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerateKey.Depth = 0;
            this.btnGenerateKey.HighEmphasis = true;
            this.btnGenerateKey.Icon = null;
            this.btnGenerateKey.Location = new System.Drawing.Point(9, 487);
            this.btnGenerateKey.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerateKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerateKey.Size = new System.Drawing.Size(175, 31);
            this.btnGenerateKey.TabIndex = 15;
            this.btnGenerateKey.Text = "Random Key";
            this.btnGenerateKey.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerateKey.UseAccentColor = false;
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.loginNamelbl);
            this.Controls.Add(this.keyLengthComboBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.hashTextBox);
            this.Controls.Add(this.txtBoxfilePath);
            this.Controls.Add(this.txtBoxMessage);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShadowKey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.picPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel picPanel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton loadImage;
        private MaterialSkin.Controls.MaterialButton encodeBtn;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtBoxMessage;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialTextBox txtBoxfilePath;
        private MaterialSkin.Controls.MaterialButton decodebtn;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialTextBox hashTextBox;
        private MaterialSkin.Controls.MaterialComboBox keyLengthComboBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox keyTextBox;
        private System.Windows.Forms.Label loginNamelbl;
        private System.Windows.Forms.Label statusLabel;
        private MaterialSkin.Controls.MaterialButton btnGenerateKey;
    }
}


namespace IrishNote
{
    using System.Windows.Forms;

    partial class IrishMain
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
            Button btnLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IrishMain));
            this.btnSignUp = new Button();
            this.pageSetupDialog1 = new PageSetupDialog();
            this.firstNameInput = new TextBox();
            this.lastNameInput = new TextBox();
            this.userNameInput = new TextBox();
            this.emailInput = new TextBox();
            this.PasswordInput = new TextBox();
            this.registerTxtBox = new RichTextBox();
            this.AboutHyperlink = new LinkLabel();
            this.userNameLabel = new Label();
            this.passwordLabel = new Label();
            this.fontDialog1 = new FontDialog();
            this.richTextBox1 = new RichTextBox();
            this.btnExit = new Button();
            this.haveProfilBox = new RichTextBox();
            this.userameInput = new TextBox();
            this.userPasswordInput = new TextBox();
            btnLogin = new Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AccessibleDescription = "";
            btnLogin.AccessibleRole = AccessibleRole.Application;
            btnLogin.BackColor = System.Drawing.Color.DarkRed;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            btnLogin.Font = new System.Drawing.Font("MicroSquare", 15.75F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogin.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            btnLogin.Location = new System.Drawing.Point(532, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(136, 42);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Log In";
            btnLogin.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogin.UseMnemonic = false;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new System.EventHandler(this.LoginClicked);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DarkRed;
            this.btnSignUp.Cursor = Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("MicroSquare", 15.75F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(163, 335);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(147, 42);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // firstNameInput
            // 
            this.firstNameInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.firstNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInput.ForeColor = System.Drawing.Color.Transparent;
            this.firstNameInput.Location = new System.Drawing.Point(177, 137);
            this.firstNameInput.MaxLength = 15;
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(115, 28);
            this.firstNameInput.TabIndex = 8;
            this.firstNameInput.Text = "First name";
            this.firstNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameInput
            // 
            this.lastNameInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lastNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInput.ForeColor = System.Drawing.Color.Transparent;
            this.lastNameInput.Location = new System.Drawing.Point(177, 173);
            this.lastNameInput.MaxLength = 15;
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(115, 28);
            this.lastNameInput.TabIndex = 7;
            this.lastNameInput.Text = "Last name";
            this.lastNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userNameInput
            // 
            this.userNameInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameInput.ForeColor = System.Drawing.Color.Transparent;
            this.userNameInput.Location = new System.Drawing.Point(177, 212);
            this.userNameInput.MaxLength = 13;
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(115, 28);
            this.userNameInput.TabIndex = 11;
            this.userNameInput.Text = "User name";
            this.userNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.ForeColor = System.Drawing.Color.Transparent;
            this.emailInput.Location = new System.Drawing.Point(177, 250);
            this.emailInput.MaxLength = 30;
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(115, 28);
            this.emailInput.TabIndex = 12;
            this.emailInput.Text = "Email";
            this.emailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordInput
            // 
            this.PasswordInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.ForeColor = System.Drawing.Color.Transparent;
            this.PasswordInput.Location = new System.Drawing.Point(177, 284);
            this.PasswordInput.MaxLength = 20;
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(115, 28);
            this.PasswordInput.TabIndex = 13;
            this.PasswordInput.Text = "Password";
            this.PasswordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registerTxtBox
            // 
            this.registerTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTxtBox.AutoWordSelection = true;
            this.registerTxtBox.BackColor = System.Drawing.Color.SlateGray;
            this.registerTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtBox.BulletIndent = 1;
            this.registerTxtBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.registerTxtBox.Font = new System.Drawing.Font("MicroSquare", 15.7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTxtBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerTxtBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.registerTxtBox.Location = new System.Drawing.Point(163, 47);
            this.registerTxtBox.MaxLength = 50;
            this.registerTxtBox.Name = "registerTxtBox";
            this.registerTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.registerTxtBox.ShowSelectionMargin = true;
            this.registerTxtBox.Size = new System.Drawing.Size(151, 58);
            this.registerTxtBox.TabIndex = 14;
            this.registerTxtBox.Text = "Register \n    for  Free:";
            // 
            // AboutHyperlink
            // 
            this.AboutHyperlink.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutHyperlink.BackColor = System.Drawing.Color.DarkRed;
            this.AboutHyperlink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AboutHyperlink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutHyperlink.DisabledLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutHyperlink.Font = new System.Drawing.Font("MicroSquare", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutHyperlink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutHyperlink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AboutHyperlink.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutHyperlink.Location = new System.Drawing.Point(747, 16);
            this.AboutHyperlink.Name = "AboutHyperlink";
            this.AboutHyperlink.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.AboutHyperlink.Size = new System.Drawing.Size(77, 43);
            this.AboutHyperlink.TabIndex = 15;
            this.AboutHyperlink.TabStop = true;
            this.AboutHyperlink.Text = "About";
            this.AboutHyperlink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AboutHyperlink.VisitedLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutHyperlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutClicked_LinkClicked_1);
            // 
            // userNameLabel
            // 
            this.userNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userNameLabel.Location = new System.Drawing.Point(449, 216);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(107, 29);
            this.userNameLabel.TabIndex = 16;
            this.userNameLabel.Text = "User name:";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordLabel.Location = new System.Drawing.Point(449, 264);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(107, 29);
            this.passwordLabel.TabIndex = 17;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SlateGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.richTextBox1.Location = new System.Drawing.Point(531, 69);
            this.richTextBox1.MaxLength = 20;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 62);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "If you have already an account";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(651, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 43);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // haveProfilBox
            // 
            this.haveProfilBox.BackColor = System.Drawing.Color.SlateGray;
            this.haveProfilBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.haveProfilBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.haveProfilBox.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveProfilBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.haveProfilBox.Location = new System.Drawing.Point(514, 137);
            this.haveProfilBox.MaxLength = 30;
            this.haveProfilBox.Name = "haveProfilBox";
            this.haveProfilBox.ScrollBars = RichTextBoxScrollBars.None;
            this.haveProfilBox.ShowSelectionMargin = true;
            this.haveProfilBox.Size = new System.Drawing.Size(182, 57);
            this.haveProfilBox.TabIndex = 20;
            this.haveProfilBox.Tag = "";
            this.haveProfilBox.Text = "If you have already an account:";
            // 
            // userameInput
            // 
            this.userameInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userameInput.BorderStyle = BorderStyle.FixedSingle;
            this.userameInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userameInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userameInput.Location = new System.Drawing.Point(586, 214);
            this.userameInput.MaxLength = 15;
            this.userameInput.Name = "userameInput";
            this.userameInput.Size = new System.Drawing.Size(110, 28);
            this.userameInput.TabIndex = 21;

            //
            //Methods for input placeholders
            //
            //public void RemoveText(TextBox textBox, object sender, EventArgs e)
            //{
            //    textBox.Text = "";
            //}

            //public void AddText(TextBox textBox, object sender, EventArgs e)
            //{
            //    if (String.IsNullOrWhiteSpace(textBox.Text))
            //        textBox.Text = "Enter text here...";
            //}
            // 
            // userPasswordInput
            // 
            this.userPasswordInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userPasswordInput.BorderStyle = BorderStyle.FixedSingle;
            this.userPasswordInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userPasswordInput.Location = new System.Drawing.Point(586, 261);
            this.userPasswordInput.Name = "userPasswordInput";
            this.userPasswordInput.Size = new System.Drawing.Size(110, 28);
            this.userPasswordInput.TabIndex = 22;
            // 
            // IrishMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = Properties.Resources.IrishNoteLogo;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(846, 466);
            this.Controls.Add(this.userPasswordInput);
            this.Controls.Add(this.userameInput);
            this.Controls.Add(this.haveProfilBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.AboutHyperlink);
            this.Controls.Add(this.registerTxtBox);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(btnLogin);
            this.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = ImeMode.On;
            this.Location = new System.Drawing.Point(12, 3);
            this.Margin = new 
                Padding(5);
            this.MaximizeBox = false;
            this.Name = "IrishMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "~Irish Note~";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Activated += new System.EventHandler(this.IrishMain_Activated);
            this.Load += new System.EventHandler(this.IrishMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSignUp;
        private PageSetupDialog pageSetupDialog1;
        private TextBox lastNameInput;
        private TextBox userNameInput;
        private TextBox emailInput;
        private TextBox PasswordInput;
        private RichTextBox registerTxtBox;
        private LinkLabel AboutHyperlink;
        private TextBox firstNameInput;
        private Label userNameLabel;
        private Label passwordLabel;
        private FontDialog fontDialog1;
        private RichTextBox richTextBox1;
        private Button btnExit;
        private RichTextBox haveProfilBox;
        private TextBox userameInput;
        private TextBox userPasswordInput;
    }
}


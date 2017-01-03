namespace IrishNote
{
    using System.ComponentModel;
    using System.Drawing;
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
            System.Windows.Forms.Button btnLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IrishMain));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.registerTxtBox = new System.Windows.Forms.RichTextBox();
            this.AboutHyperlink = new System.Windows.Forms.LinkLabel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.haveProfilBox = new System.Windows.Forms.RichTextBox();
            this.userameInput = new System.Windows.Forms.TextBox();
            this.userPasswordInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordSign = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AccessibleDescription = "";
            btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            btnLogin.BackColor = System.Drawing.Color.DarkRed;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            btnLogin.Font = new System.Drawing.Font("MicroSquare", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogin.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            btnLogin.Location = new System.Drawing.Point(532, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(136, 42);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Log In";
            btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLogin.UseMnemonic = false;
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DarkRed;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("MicroSquare", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(167, 335);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(147, 42);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSignUp.UseVisualStyleBackColor = false;
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
            this.registerTxtBox.Location = new System.Drawing.Point(163, 16);
            this.registerTxtBox.MaxLength = 50;
            this.registerTxtBox.Name = "registerTxtBox";
            this.registerTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.registerTxtBox.ShowSelectionMargin = true;
            this.registerTxtBox.Size = new System.Drawing.Size(151, 58);
            this.registerTxtBox.TabIndex = 12;
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
            this.AboutHyperlink.TabIndex = 10;
            this.AboutHyperlink.TabStop = true;
            this.AboutHyperlink.Text = "About";
            this.AboutHyperlink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AboutHyperlink.VisitedLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // userNameLabel
            // 
            this.userNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userNameLabel.Location = new System.Drawing.Point(449, 216);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(107, 29);
            this.userNameLabel.TabIndex = 19;
            this.userNameLabel.Text = "User name:";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordLabel.Location = new System.Drawing.Point(449, 264);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(107, 29);
            this.passwordLabel.TabIndex = 20;
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
            this.btnExit.Location = new System.Drawing.Point(654, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 43);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // haveProfilBox
            // 
            this.haveProfilBox.BackColor = System.Drawing.Color.SlateGray;
            this.haveProfilBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.haveProfilBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.haveProfilBox.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveProfilBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.haveProfilBox.Location = new System.Drawing.Point(514, 137);
            this.haveProfilBox.MaxLength = 30;
            this.haveProfilBox.Name = "haveProfilBox";
            this.haveProfilBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.haveProfilBox.ShowSelectionMargin = true;
            this.haveProfilBox.Size = new System.Drawing.Size(182, 57);
            this.haveProfilBox.TabIndex = 18;
            this.haveProfilBox.Tag = "";
            this.haveProfilBox.Text = "If you have already an account:";
            // 
            // userameInput
            // 
            this.userameInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userameInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userameInput.ForeColor = System.Drawing.Color.DarkRed;
            this.userameInput.Location = new System.Drawing.Point(586, 217);
            this.userameInput.MaxLength = 15;
            this.userameInput.Name = "userameInput";
            this.userameInput.Size = new System.Drawing.Size(110, 28);
            this.userameInput.TabIndex = 6;
            // 
            // userPasswordInput
            // 
            this.userPasswordInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPasswordInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordInput.ForeColor = System.Drawing.Color.DarkRed;
            this.userPasswordInput.Location = new System.Drawing.Point(586, 265);
            this.userPasswordInput.Name = "userPasswordInput";
            this.userPasswordInput.Size = new System.Drawing.Size(110, 28);
            this.userPasswordInput.TabIndex = 7;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstNameLabel.Location = new System.Drawing.Point(111, 96);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(107, 29);
            this.firstNameLabel.TabIndex = 13;
            this.firstNameLabel.Text = "First name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastNameLabel.Location = new System.Drawing.Point(111, 137);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(107, 29);
            this.lastNameLabel.TabIndex = 14;
            this.lastNameLabel.Text = "Last name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailLabel.Location = new System.Drawing.Point(111, 233);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(107, 29);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userLabel
            // 
            this.userLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userLabel.Location = new System.Drawing.Point(111, 185);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(107, 29);
            this.userLabel.TabIndex = 15;
            this.userLabel.Text = "User name:";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordSign
            // 
            this.passwordSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordSign.Location = new System.Drawing.Point(111, 275);
            this.passwordSign.Name = "passwordSign";
            this.passwordSign.Size = new System.Drawing.Size(107, 29);
            this.passwordSign.TabIndex = 17;
            this.passwordSign.Text = "Password:";
            this.passwordSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox1.Location = new System.Drawing.Point(235, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 28);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox2.Location = new System.Drawing.Point(235, 96);
            this.textBox2.MaxLength = 15;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 28);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox3.Location = new System.Drawing.Point(235, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 28);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox4.Location = new System.Drawing.Point(235, 186);
            this.textBox4.MaxLength = 15;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 28);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox5.Location = new System.Drawing.Point(235, 285);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(110, 28);
            this.textBox5.TabIndex = 4;
            // 
            // IrishMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::IrishNote.Properties.Resources.IrishNoteLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(846, 466);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.passwordSign);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.userPasswordInput);
            this.Controls.Add(this.userameInput);
            this.Controls.Add(this.haveProfilBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.AboutHyperlink);
            this.Controls.Add(this.registerTxtBox);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(btnLogin);
            this.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Location = new System.Drawing.Point(12, 3);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "IrishMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~Irish Note~";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Activated += new System.EventHandler(this.IrishMain_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Button btnSignUp;
        private PageSetupDialog pageSetupDialog1;
        private RichTextBox registerTxtBox;
        private LinkLabel AboutHyperlink;
        private Label userNameLabel;
        private Label passwordLabel;
        private FontDialog fontDialog1;
        private RichTextBox richTextBox1;
        private Button btnExit;
        private RichTextBox haveProfilBox;
        private TextBox userameInput;
        private TextBox userPasswordInput;
        private Label firstNameLabel;
        private Label emailLabel;
        private Label userLabel;
        private Label passwordSign;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        internal Label lastNameLabel;
    }

}


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
            System.Windows.Forms.Button btnCustomNote;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IrishMain));
            this.AboutHyperlink = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.loginSignData = new System.Windows.Forms.Panel();
            this.displayMenuItems = new System.Windows.Forms.Panel();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.registerTxtBox = new System.Windows.Forms.RichTextBox();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputUserName = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordSign = new System.Windows.Forms.Label();
            this.haveProfilBox = new System.Windows.Forms.RichTextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.userameInput = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userPasswordInput = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.btnEvents = new System.Windows.Forms.Button();
            this.textBase = new System.Windows.Forms.RichTextBox();
            this.itemTitle = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            btnCustomNote = new System.Windows.Forms.Button();
            this.loginSignData.SuspendLayout();
            this.displayMenuItems.SuspendLayout();
            this.menuPanel.SuspendLayout();
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
            btnLogin.Location = new System.Drawing.Point(450, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(136, 42);
            btnLogin.TabIndex = 29;
            btnLogin.Text = "Log In";
            btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLogin.UseMnemonic = false;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCustomNote
            // 
            btnCustomNote.AccessibleDescription = "";
            btnCustomNote.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            btnCustomNote.BackColor = System.Drawing.Color.DarkRed;
            btnCustomNote.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCustomNote.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            btnCustomNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            btnCustomNote.Font = new System.Drawing.Font("MicroSquare", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCustomNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnCustomNote.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            btnCustomNote.Location = new System.Drawing.Point(399, 17);
            btnCustomNote.Name = "btnCustomNote";
            btnCustomNote.Size = new System.Drawing.Size(151, 42);
            btnCustomNote.TabIndex = 40;
            btnCustomNote.Text = "Custom Note";
            btnCustomNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCustomNote.UseMnemonic = false;
            btnCustomNote.UseVisualStyleBackColor = false;
            btnCustomNote.Click += new System.EventHandler(this.btnCustomNote_Click);
            // 
            // AboutHyperlink
            // 
            this.AboutHyperlink.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutHyperlink.BackColor = System.Drawing.Color.DarkRed;
            this.AboutHyperlink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AboutHyperlink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutHyperlink.DisabledLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutHyperlink.Font = new System.Drawing.Font("MicroSquare", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.AboutHyperlink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AboutHyperlink_MouseClick);
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
            // loginSignData
            // 
            this.loginSignData.BackColor = System.Drawing.Color.Transparent;
            this.loginSignData.Controls.Add(this.inputPassword);
            this.loginSignData.Controls.Add(this.registerTxtBox);
            this.loginSignData.Controls.Add(this.inputEmail);
            this.loginSignData.Controls.Add(btnLogin);
            this.loginSignData.Controls.Add(this.inputUserName);
            this.loginSignData.Controls.Add(this.btnSignUp);
            this.loginSignData.Controls.Add(this.inputLastName);
            this.loginSignData.Controls.Add(this.userNameLabel);
            this.loginSignData.Controls.Add(this.inputFirstName);
            this.loginSignData.Controls.Add(this.passwordLabel);
            this.loginSignData.Controls.Add(this.passwordSign);
            this.loginSignData.Controls.Add(this.haveProfilBox);
            this.loginSignData.Controls.Add(this.emailLabel);
            this.loginSignData.Controls.Add(this.userameInput);
            this.loginSignData.Controls.Add(this.userLabel);
            this.loginSignData.Controls.Add(this.userPasswordInput);
            this.loginSignData.Controls.Add(this.lastNameLabel);
            this.loginSignData.Controls.Add(this.firstNameLabel);
            this.loginSignData.Location = new System.Drawing.Point(106, 74);
            this.loginSignData.Name = "loginSignData";
            this.loginSignData.Size = new System.Drawing.Size(635, 380);
            this.loginSignData.TabIndex = 11;
            // 
            // displayMenuItems
            // 
            this.displayMenuItems.BackgroundImage = global::IrishNote.Properties.Resources.menuItemBackground;
            this.displayMenuItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayMenuItems.Controls.Add(this.btnClear);
            this.displayMenuItems.Controls.Add(this.titleLabel);
            this.displayMenuItems.Controls.Add(this.itemTitle);
            this.displayMenuItems.Controls.Add(this.textBase);
            this.displayMenuItems.Location = new System.Drawing.Point(29, 65);
            this.displayMenuItems.Name = "displayMenuItems";
            this.displayMenuItems.Size = new System.Drawing.Size(805, 401);
            this.displayMenuItems.TabIndex = 39;
            this.displayMenuItems.Visible = false;
            this.displayMenuItems.Paint += new System.Windows.Forms.PaintEventHandler(this.displayMenuPanel_Paint);
            // 
            // inputPassword
            // 
            this.inputPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPassword.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.inputPassword.Location = new System.Drawing.Point(142, 262);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(110, 28);
            this.inputPassword.TabIndex = 25;
            // 
            // registerTxtBox
            // 
            this.registerTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTxtBox.AutoWordSelection = true;
            this.registerTxtBox.BackColor = System.Drawing.Color.SlateGray;
            this.registerTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtBox.BulletIndent = 1;
            this.registerTxtBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.registerTxtBox.Font = new System.Drawing.Font("MicroSquare", 15.65F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTxtBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerTxtBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.registerTxtBox.Location = new System.Drawing.Point(70, 3);
            this.registerTxtBox.MaxLength = 50;
            this.registerTxtBox.Name = "registerTxtBox";
            this.registerTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.registerTxtBox.ShowSelectionMargin = true;
            this.registerTxtBox.Size = new System.Drawing.Size(151, 58);
            this.registerTxtBox.TabIndex = 30;
            this.registerTxtBox.Text = "Register \n    for  Free:";
            // 
            // inputEmail
            // 
            this.inputEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputEmail.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEmail.ForeColor = System.Drawing.Color.DarkRed;
            this.inputEmail.Location = new System.Drawing.Point(142, 220);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(110, 28);
            this.inputEmail.TabIndex = 24;
            // 
            // inputUserName
            // 
            this.inputUserName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputUserName.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUserName.ForeColor = System.Drawing.Color.DarkRed;
            this.inputUserName.Location = new System.Drawing.Point(142, 173);
            this.inputUserName.MaxLength = 15;
            this.inputUserName.Name = "inputUserName";
            this.inputUserName.Size = new System.Drawing.Size(110, 28);
            this.inputUserName.TabIndex = 23;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DarkRed;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("MicroSquare", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(74, 322);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(147, 42);
            this.btnSignUp.TabIndex = 26;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // inputLastName
            // 
            this.inputLastName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputLastName.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLastName.ForeColor = System.Drawing.Color.DarkRed;
            this.inputLastName.Location = new System.Drawing.Point(142, 125);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(110, 28);
            this.inputLastName.TabIndex = 22;
            // 
            // userNameLabel
            // 
            this.userNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userNameLabel.Location = new System.Drawing.Point(339, 221);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(107, 29);
            this.userNameLabel.TabIndex = 37;
            this.userNameLabel.Text = "User name:";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputFirstName
            // 
            this.inputFirstName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFirstName.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFirstName.ForeColor = System.Drawing.Color.DarkRed;
            this.inputFirstName.Location = new System.Drawing.Point(142, 83);
            this.inputFirstName.MaxLength = 15;
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(110, 28);
            this.inputFirstName.TabIndex = 21;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordLabel.Location = new System.Drawing.Point(339, 263);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(107, 29);
            this.passwordLabel.TabIndex = 38;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordSign
            // 
            this.passwordSign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordSign.Location = new System.Drawing.Point(18, 262);
            this.passwordSign.Name = "passwordSign";
            this.passwordSign.Size = new System.Drawing.Size(107, 29);
            this.passwordSign.TabIndex = 35;
            this.passwordSign.Text = "Password:";
            this.passwordSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // haveProfilBox
            // 
            this.haveProfilBox.BackColor = System.Drawing.Color.SlateGray;
            this.haveProfilBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.haveProfilBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.haveProfilBox.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveProfilBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.haveProfilBox.Location = new System.Drawing.Point(404, 144);
            this.haveProfilBox.MaxLength = 30;
            this.haveProfilBox.Name = "haveProfilBox";
            this.haveProfilBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.haveProfilBox.ShowSelectionMargin = true;
            this.haveProfilBox.Size = new System.Drawing.Size(182, 57);
            this.haveProfilBox.TabIndex = 36;
            this.haveProfilBox.Tag = "";
            this.haveProfilBox.Text = "If you have already an account:";
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailLabel.Location = new System.Drawing.Point(18, 220);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(107, 29);
            this.emailLabel.TabIndex = 34;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userameInput
            // 
            this.userameInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userameInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userameInput.ForeColor = System.Drawing.Color.DarkRed;
            this.userameInput.Location = new System.Drawing.Point(476, 222);
            this.userameInput.MaxLength = 15;
            this.userameInput.Name = "userameInput";
            this.userameInput.Size = new System.Drawing.Size(110, 28);
            this.userameInput.TabIndex = 27;
            // 
            // userLabel
            // 
            this.userLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userLabel.Location = new System.Drawing.Point(18, 172);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(107, 29);
            this.userLabel.TabIndex = 33;
            this.userLabel.Text = "User name:";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userPasswordInput
            // 
            this.userPasswordInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPasswordInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordInput.ForeColor = System.Drawing.Color.DarkRed;
            this.userPasswordInput.Location = new System.Drawing.Point(476, 264);
            this.userPasswordInput.Name = "userPasswordInput";
            this.userPasswordInput.Size = new System.Drawing.Size(110, 28);
            this.userPasswordInput.TabIndex = 28;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastNameLabel.Location = new System.Drawing.Point(18, 124);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(107, 29);
            this.lastNameLabel.TabIndex = 32;
            this.lastNameLabel.Text = "Last name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.firstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstNameLabel.Location = new System.Drawing.Point(18, 83);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(107, 29);
            this.firstNameLabel.TabIndex = 31;
            this.firstNameLabel.Text = "First name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.btnCalendar);
            this.menuPanel.Controls.Add(this.btnNotes);
            this.menuPanel.Controls.Add(this.btnTasks);
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Controls.Add(this.btnEvents);
            this.menuPanel.Location = new System.Drawing.Point(12, -1);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(174, 467);
            this.menuPanel.TabIndex = 41;
            this.menuPanel.Visible = false;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Location = new System.Drawing.Point(32, 387);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(103, 33);
            this.btnCalendar.TabIndex = 4;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(32, 137);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(103, 33);
            this.btnNotes.TabIndex = 3;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(32, 194);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(103, 33);
            this.btnTasks.TabIndex = 2;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Teal;
            this.menuLabel.Font = new System.Drawing.Font("MicroSquare", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(48, 18);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(61, 24);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(32, 78);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(103, 33);
            this.btnEvents.TabIndex = 0;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEvents_MouseClick);
            // 
            // textBase
            // 
            this.textBase.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBase.Location = new System.Drawing.Point(147, 76);
            this.textBase.Name = "textBase";
            this.textBase.Size = new System.Drawing.Size(625, 297);
            this.textBase.TabIndex = 0;
            this.textBase.Text = "";
            // 
            // itemTitle
            // 
            this.itemTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.itemTitle.Font = new System.Drawing.Font("MicroSquare", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemTitle.Location = new System.Drawing.Point(264, 24);
            this.itemTitle.MaxLength = 50;
            this.itemTitle.Name = "itemTitle";
            this.itemTitle.Size = new System.Drawing.Size(381, 30);
            this.itemTitle.TabIndex = 1;
            this.itemTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(147, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(89, 30);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Caption:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkRed;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(556, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(87, 43);
            this.btnHome.TabIndex = 42;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(3, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear note";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // IrishMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::IrishNote.Properties.Resources.appBackgroundHome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(846, 466);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.displayMenuItems);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(btnCustomNote);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.AboutHyperlink);
            this.Controls.Add(this.loginSignData);
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
            this.loginSignData.ResumeLayout(false);
            this.loginSignData.PerformLayout();
            this.displayMenuItems.ResumeLayout(false);
            this.displayMenuItems.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private LinkLabel AboutHyperlink;
        private RichTextBox richTextBox1;
        private Button btnExit;
        private Panel loginSignData;
        private TextBox inputPassword;
        private RichTextBox registerTxtBox;
        private TextBox inputEmail;
        private TextBox inputUserName;
        private Button btnSignUp;
        private TextBox inputLastName;
        private Label userNameLabel;
        private TextBox inputFirstName;
        private Label passwordLabel;
        private Label passwordSign;
        private RichTextBox haveProfilBox;
        private Label emailLabel;
        private TextBox userameInput;
        private Label userLabel;
        private TextBox userPasswordInput;
        internal Label lastNameLabel;
        private Label firstNameLabel;
        private Panel menuPanel;
        private Button btnCalendar;
        private Button btnNotes;
        private Button btnTasks;
        private Label menuLabel;
        private Button btnEvents;
        private Panel displayMenuItems;
        private RichTextBox textBase;
        private Label titleLabel;
        private TextBox itemTitle;
        private Button btnHome;
        private Button btnClear;
    }

}


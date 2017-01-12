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
            this.btnAbout = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.loginSignContainer = new System.Windows.Forms.Panel();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.registerLbl = new System.Windows.Forms.RichTextBox();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputUserName = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.userNameUserLbl = new System.Windows.Forms.Label();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.passwordUserLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.UserLoginLbl = new System.Windows.Forms.RichTextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.userameInput = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userPasswordInput = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.displayMenuItems = new System.Windows.Forms.Panel();
            this.btnChangeBackColor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.titleNoteLbl = new System.Windows.Forms.Label();
            this.titleNoteContainer = new System.Windows.Forms.TextBox();
            this.textNoteContainer = new System.Windows.Forms.RichTextBox();
            this.menuContainer = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.btnEvents = new System.Windows.Forms.Button();
            this.welcomeUserPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnChangeTextColor = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            btnCustomNote = new System.Windows.Forms.Button();
            this.loginSignContainer.SuspendLayout();
            this.displayMenuItems.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.welcomeUserPanel.SuspendLayout();
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
            btnLogin.Location = new System.Drawing.Point(416, 320);
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
            btnCustomNote.Location = new System.Drawing.Point(507, 10);
            btnCustomNote.Name = "btnCustomNote";
            btnCustomNote.Size = new System.Drawing.Size(151, 42);
            btnCustomNote.TabIndex = 40;
            btnCustomNote.Text = "Custom Note";
            btnCustomNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnCustomNote.UseMnemonic = false;
            btnCustomNote.UseVisualStyleBackColor = false;
            btnCustomNote.Click += new System.EventHandler(this.btnCustomNote_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbout.BackColor = System.Drawing.Color.DarkRed;
            this.btnAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.DisabledLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnAbout.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Location = new System.Drawing.Point(757, 9);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(77, 43);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.TabStop = true;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbout.VisitedLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAbout_LinkClicked);
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
            this.btnExit.Location = new System.Drawing.Point(664, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 43);
            this.btnExit.TabIndex = 9;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // loginSignContainer
            // 
            this.loginSignContainer.BackColor = System.Drawing.Color.Transparent;
            this.loginSignContainer.Controls.Add(this.inputPassword);
            this.loginSignContainer.Controls.Add(this.registerLbl);
            this.loginSignContainer.Controls.Add(this.inputEmail);
            this.loginSignContainer.Controls.Add(btnLogin);
            this.loginSignContainer.Controls.Add(this.inputUserName);
            this.loginSignContainer.Controls.Add(this.btnSignUp);
            this.loginSignContainer.Controls.Add(this.inputLastName);
            this.loginSignContainer.Controls.Add(this.userNameUserLbl);
            this.loginSignContainer.Controls.Add(this.inputFirstName);
            this.loginSignContainer.Controls.Add(this.passwordUserLbl);
            this.loginSignContainer.Controls.Add(this.passwordLbl);
            this.loginSignContainer.Controls.Add(this.UserLoginLbl);
            this.loginSignContainer.Controls.Add(this.emailLbl);
            this.loginSignContainer.Controls.Add(this.userameInput);
            this.loginSignContainer.Controls.Add(this.userNameLbl);
            this.loginSignContainer.Controls.Add(this.userPasswordInput);
            this.loginSignContainer.Controls.Add(this.lastNameLbl);
            this.loginSignContainer.Controls.Add(this.firstNameLbl);
            this.loginSignContainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginSignContainer.Location = new System.Drawing.Point(106, 74);
            this.loginSignContainer.Name = "loginSignContainer";
            this.loginSignContainer.Size = new System.Drawing.Size(635, 380);
            this.loginSignContainer.TabIndex = 11;
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
            // registerLbl
            // 
            this.registerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerLbl.AutoWordSelection = true;
            this.registerLbl.BackColor = System.Drawing.Color.SlateGray;
            this.registerLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerLbl.BulletIndent = 1;
            this.registerLbl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.registerLbl.Font = new System.Drawing.Font("MicroSquare", 15.6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerLbl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.registerLbl.Location = new System.Drawing.Point(70, 3);
            this.registerLbl.MaxLength = 50;
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.registerLbl.ShowSelectionMargin = true;
            this.registerLbl.Size = new System.Drawing.Size(151, 58);
            this.registerLbl.TabIndex = 30;
            this.registerLbl.Text = "Register \n    for  Free";
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
            // userNameUserLbl
            // 
            this.userNameUserLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userNameUserLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userNameUserLbl.Location = new System.Drawing.Point(376, 230);
            this.userNameUserLbl.Name = "userNameUserLbl";
            this.userNameUserLbl.Size = new System.Drawing.Size(107, 29);
            this.userNameUserLbl.TabIndex = 37;
            this.userNameUserLbl.Text = "User name";
            this.userNameUserLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // passwordUserLbl
            // 
            this.passwordUserLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordUserLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordUserLbl.Location = new System.Drawing.Point(376, 272);
            this.passwordUserLbl.Name = "passwordUserLbl";
            this.passwordUserLbl.Size = new System.Drawing.Size(107, 29);
            this.passwordUserLbl.TabIndex = 38;
            this.passwordUserLbl.Text = "Password";
            this.passwordUserLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordLbl
            // 
            this.passwordLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordLbl.Location = new System.Drawing.Point(18, 262);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(107, 29);
            this.passwordLbl.TabIndex = 35;
            this.passwordLbl.Text = "Password";
            this.passwordLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserLoginLbl
            // 
            this.UserLoginLbl.BackColor = System.Drawing.Color.SlateGray;
            this.UserLoginLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLoginLbl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UserLoginLbl.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoginLbl.ForeColor = System.Drawing.SystemColors.Menu;
            this.UserLoginLbl.Location = new System.Drawing.Point(404, 144);
            this.UserLoginLbl.MaxLength = 30;
            this.UserLoginLbl.Name = "UserLoginLbl";
            this.UserLoginLbl.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.UserLoginLbl.ShowSelectionMargin = true;
            this.UserLoginLbl.Size = new System.Drawing.Size(182, 57);
            this.UserLoginLbl.TabIndex = 36;
            this.UserLoginLbl.Tag = "";
            this.UserLoginLbl.Text = "If you have already an account";
            // 
            // emailLbl
            // 
            this.emailLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emailLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailLbl.Location = new System.Drawing.Point(18, 220);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(107, 29);
            this.emailLbl.TabIndex = 34;
            this.emailLbl.Text = "Email";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userameInput
            // 
            this.userameInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userameInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userameInput.ForeColor = System.Drawing.Color.DarkRed;
            this.userameInput.Location = new System.Drawing.Point(500, 230);
            this.userameInput.MaxLength = 15;
            this.userameInput.Name = "userameInput";
            this.userameInput.Size = new System.Drawing.Size(110, 28);
            this.userameInput.TabIndex = 27;
            // 
            // userNameLbl
            // 
            this.userNameLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userNameLbl.Location = new System.Drawing.Point(18, 172);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(107, 29);
            this.userNameLbl.TabIndex = 33;
            this.userNameLbl.Text = "User name";
            this.userNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userPasswordInput
            // 
            this.userPasswordInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPasswordInput.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordInput.ForeColor = System.Drawing.Color.DarkRed;
            this.userPasswordInput.Location = new System.Drawing.Point(500, 273);
            this.userPasswordInput.Name = "userPasswordInput";
            this.userPasswordInput.Size = new System.Drawing.Size(110, 28);
            this.userPasswordInput.TabIndex = 28;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lastNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastNameLbl.Location = new System.Drawing.Point(18, 124);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(107, 29);
            this.lastNameLbl.TabIndex = 32;
            this.lastNameLbl.Text = "Last name";
            this.lastNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.firstNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstNameLbl.Location = new System.Drawing.Point(18, 83);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(107, 29);
            this.firstNameLbl.TabIndex = 31;
            this.firstNameLbl.Text = "First name";
            this.firstNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // displayMenuItems
            // 
            this.displayMenuItems.BackgroundImage = global::IrishNote.Properties.Resources.menuItemBackground;
            this.displayMenuItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayMenuItems.Controls.Add(this.btnChangeTextColor);
            this.displayMenuItems.Controls.Add(this.btnChangeBackColor);
            this.displayMenuItems.Controls.Add(this.btnSave);
            this.displayMenuItems.Controls.Add(this.btnClear);
            this.displayMenuItems.Controls.Add(this.titleNoteLbl);
            this.displayMenuItems.Controls.Add(this.titleNoteContainer);
            this.displayMenuItems.Controls.Add(this.textNoteContainer);
            this.displayMenuItems.Location = new System.Drawing.Point(7, 71);
            this.displayMenuItems.Name = "displayMenuItems";
            this.displayMenuItems.Size = new System.Drawing.Size(849, 410);
            this.displayMenuItems.TabIndex = 39;
            this.displayMenuItems.Visible = false;
            // 
            // btnChangeBackColor
            // 
            this.btnChangeBackColor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChangeBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeBackColor.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBackColor.Location = new System.Drawing.Point(151, 372);
            this.btnChangeBackColor.Name = "btnChangeBackColor";
            this.btnChangeBackColor.Size = new System.Drawing.Size(159, 34);
            this.btnChangeBackColor.TabIndex = 10;
            this.btnChangeBackColor.TabStop = false;
            this.btnChangeBackColor.Text = "Background";
            this.btnChangeBackColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangeBackColor.UseVisualStyleBackColor = false;
            this.btnChangeBackColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChangeBackColor_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(599, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseMnemonic = false;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(705, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseMnemonic = false;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // titleNoteLbl
            // 
            this.titleNoteLbl.BackColor = System.Drawing.Color.DarkRed;
            this.titleNoteLbl.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleNoteLbl.Location = new System.Drawing.Point(147, 24);
            this.titleNoteLbl.Name = "titleNoteLbl";
            this.titleNoteLbl.Size = new System.Drawing.Size(89, 30);
            this.titleNoteLbl.TabIndex = 2;
            this.titleNoteLbl.Text = "Title";
            this.titleNoteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleNoteContainer
            // 
            this.titleNoteContainer.BackColor = System.Drawing.Color.White;
            this.titleNoteContainer.Font = new System.Drawing.Font("MicroSquare", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleNoteContainer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleNoteContainer.Location = new System.Drawing.Point(264, 24);
            this.titleNoteContainer.MaxLength = 50;
            this.titleNoteContainer.Name = "titleNoteContainer";
            this.titleNoteContainer.Size = new System.Drawing.Size(381, 30);
            this.titleNoteContainer.TabIndex = 0;
            this.titleNoteContainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNoteContainer
            // 
            this.textNoteContainer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textNoteContainer.Location = new System.Drawing.Point(143, 76);
            this.textNoteContainer.Name = "textNoteContainer";
            this.textNoteContainer.Size = new System.Drawing.Size(662, 291);
            this.textNoteContainer.TabIndex = 1;
            this.textNoteContainer.Text = "";
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.Transparent;
            this.menuContainer.Controls.Add(this.btnCalendar);
            this.menuContainer.Controls.Add(this.btnNotes);
            this.menuContainer.Controls.Add(this.btnTasks);
            this.menuContainer.Controls.Add(this.menuLabel);
            this.menuContainer.Controls.Add(this.btnEvents);
            this.menuContainer.Location = new System.Drawing.Point(1, -1);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(117, 482);
            this.menuContainer.TabIndex = 41;
            this.menuContainer.Visible = false;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Location = new System.Drawing.Point(6, 367);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(103, 33);
            this.btnCalendar.TabIndex = 4;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = false;
            // 
            // btnNotes
            // 
            this.btnNotes.BackColor = System.Drawing.Color.DarkRed;
            this.btnNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotes.Location = new System.Drawing.Point(6, 167);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(103, 33);
            this.btnNotes.TabIndex = 3;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = false;
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.Color.DarkRed;
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.Location = new System.Drawing.Point(6, 231);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(103, 33);
            this.btnTasks.TabIndex = 2;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = false;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Teal;
            this.menuLabel.Font = new System.Drawing.Font("MicroSquare", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(25, 36);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(61, 24);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.DarkRed;
            this.btnEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvents.Location = new System.Drawing.Point(6, 103);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(103, 33);
            this.btnEvents.TabIndex = 0;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = false;
            // 
            // welcomeUserPanel
            // 
            this.welcomeUserPanel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeUserPanel.Controls.Add(this.welcomeLabel);
            this.welcomeUserPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.welcomeUserPanel.ForeColor = System.Drawing.Color.DarkRed;
            this.welcomeUserPanel.Location = new System.Drawing.Point(150, 55);
            this.welcomeUserPanel.Name = "welcomeUserPanel";
            this.welcomeUserPanel.Size = new System.Drawing.Size(645, 426);
            this.welcomeUserPanel.TabIndex = 39;
            this.welcomeUserPanel.Visible = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("MicroSquare", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(140, 159);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(280, 59);
            this.welcomeLabel.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkRed;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(414, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(87, 43);
            this.btnMenu.TabIndex = 42;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Visible = false;
            // 
            // colorDialog
            // 
            this.colorDialog.SolidColorOnly = true;
            // 
            // btnChangeTextColor
            // 
            this.btnChangeTextColor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChangeTextColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeTextColor.Font = new System.Drawing.Font("MicroSquare", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTextColor.Location = new System.Drawing.Point(316, 372);
            this.btnChangeTextColor.Name = "btnChangeTextColor";
            this.btnChangeTextColor.Size = new System.Drawing.Size(159, 34);
            this.btnChangeTextColor.TabIndex = 11;
            this.btnChangeTextColor.TabStop = false;
            this.btnChangeTextColor.Text = "Text";
            this.btnChangeTextColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangeTextColor.UseVisualStyleBackColor = false;
            this.btnChangeTextColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChangeTextColor_MouseClick);
            // 
            // IrishMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::IrishNote.Properties.Resources.appBackgroundHome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(868, 483);
            this.Controls.Add(this.displayMenuItems);
            this.Controls.Add(this.loginSignContainer);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.menuContainer);
            this.Controls.Add(btnCustomNote);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.welcomeUserPanel);
            this.Font = new System.Drawing.Font("MicroSquare", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Location = new System.Drawing.Point(12, 3);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "IrishMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~Irish Note~";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.loginSignContainer.ResumeLayout(false);
            this.loginSignContainer.PerformLayout();
            this.displayMenuItems.ResumeLayout(false);
            this.displayMenuItems.PerformLayout();
            this.menuContainer.ResumeLayout(false);
            this.menuContainer.PerformLayout();
            this.welcomeUserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private LinkLabel btnAbout;
        private RichTextBox richTextBox1;
        private Button btnExit;
        private Panel loginSignContainer;
        private TextBox inputPassword;
        private RichTextBox registerLbl;
        private TextBox inputEmail;
        private TextBox inputUserName;
        private Button btnSignUp;
        private TextBox inputLastName;
        private Label userNameUserLbl;
        private TextBox inputFirstName;
        private Label passwordUserLbl;
        private Label passwordLbl;
        private RichTextBox UserLoginLbl;
        private Label emailLbl;
        private TextBox userameInput;
        private Label userNameLbl;
        private TextBox userPasswordInput;
        internal Label lastNameLbl;
        private Label firstNameLbl;
        private Panel menuContainer;
        private Button btnCalendar;
        private Button btnNotes;
        private Button btnTasks;
        private Label menuLabel;
        private Button btnEvents;
        private Panel displayMenuItems;
        private RichTextBox textNoteContainer;
        private Label titleNoteLbl;
        private TextBox titleNoteContainer;
        private Button btnClear;
        private Button btnSave;
        private Panel welcomeUserPanel;
        private Label welcomeLabel;
        private Button btnMenu;
        public ColorDialog colorDialog;
        private Button btnChangeBackColor;
        private Button btnChangeTextColor;
    }

}


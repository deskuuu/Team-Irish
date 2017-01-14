namespace IrishNote
{
    using System;
    using System.Windows.Forms;

    using Common.Constants;
    using Common.Contracts;
    using Common.DataLogic;
    using Common.Exceptions;
    using Common.ExtensionMethods;
    using Common.Models;

    public partial class IrishMain : Form
    {
        private IUser user = new User();
        private bool isClickedSignUp = false;
        private bool isCleckedLogOn = false;

        public IrishMain()
        {
            this.InitializeComponent();
        }

        private void PrintMenuLogged(string username)
        {
            var transformName = username.StartWithCapitalLetter();
            MessageBox.Show(AppConstants.UserLoggedMsg + $" {transformName}", AppConstants.Logged, MessageBoxButtons.OK, MessageBoxIcon.Information);
            loginSignContainer.Visible = false;
            menuContainer.Visible = true;
            welcomeUserPanel.Visible = true;
            welcomeLabel.Text = AppConstants.WelcomeMsg + $" {transformName}";
            btnMenu.Visible = false;
        }

        private void ChangeBGColor(RichTextBox container, TextBox contaner)
        {
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                container.BackColor = colorDialog.Color;
                contaner.BackColor = colorDialog.Color;
            }
        }

        private void ChangeTextColor(RichTextBox container, TextBox contaner)
        {
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                container.ForeColor = colorDialog.Color;
                contaner.ForeColor = colorDialog.Color;
            }
        }

        private bool IsLogged()
        {
            var isLogged = this.isClickedSignUp || this.isCleckedLogOn;

            return isLogged;
        }

        private void ClearNewUserInputs()
        {
            inputFirstName.Clear();
            inputLastName.Clear();
            inputUserName.Clear();
            inputEmail.Clear();
            inputPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var msgBxCaption = ErrorMessagesConstants.MsgBoxCaptionAboutClick;

            try
            {
                System.Diagnostics.Process.Start(AppConstants.AppSourceLink);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(ErrorMessagesConstants.InvalidHyperlink, msgBxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, msgBxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = userameInput.Text;
            var password = userPasswordInput.Text;
            var isValidUsername = DataMethods.CheckLoginUsername(username);
            var isValidPassword = DataMethods.CheckLoginData(username, password);

            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    throw new InvalidUserDataException();
                }
                else if (isValidUsername)
                {
                    if (!isValidPassword)
                    {
                        throw new InvalidPasswordException();

                    }

                    this.PrintMenuLogged(username);
                    this.isCleckedLogOn = true;
                    // ToDO: make logic btw user and his data
                }
                else
                {
                    throw new InvalidUsernameException();
                }
            }
            catch (InvalidUsernameException msg)
            {
                MessageBox.Show(msg.Message, ErrorMessagesConstants.MsgBoxLoginDataCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (InvalidPasswordException msg)
            {
                MessageBox.Show(msg.Message, ErrorMessagesConstants.MsgBoxLoginDataCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (InvalidUserDataException msg)
            {
                MessageBox.Show(msg.Message, ErrorMessagesConstants.MsgBoxLoginDataCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSignUp_MouseClick(object sender, MouseEventArgs e)
        {
            var candidateFirstName = inputFirstName.Text;
            var candidateLastName = inputLastName.Text;
            var candidateUserName = inputUserName.Text;
            var candidateEmail = inputEmail.Text;
            var candidatePassword = inputPassword.Text;

            var messageBoxCaption = ErrorMessagesConstants.MsgBoxCaptionUser;

            try
            {
                var isRegistered = DataMethods.CheckLoginUsername(candidateUserName);

                if (isRegistered)
                {
                    inputUserName.Clear();
                    MessageBox.Show(ErrorMessagesConstants.UserExcistMsg, messageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    this.user.FirstName = candidateFirstName;
                    this.user.LastName = candidateLastName;
                    this.user.Username = candidateUserName;
                    this.user.Email = candidateEmail;
                    this.user.Password = candidatePassword;

                    UserData.AddUser(candidateUserName, candidatePassword);
                    this.PrintMenuLogged(candidateUserName);
                    this.isClickedSignUp = true;
                }

                this.ClearNewUserInputs();
            }
            catch (ArgumentException)
            {
                MessageBox.Show(ErrorMessagesConstants.UserExcistMsg, messageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (FormatException msg)
            {
                MessageBox.Show(msg.Message, messageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, messageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCustomNote_Click(object sender, EventArgs e)
        {
            loginSignContainer.Visible = false;
            displayMenuItems.Visible = true;
            menuContainer.Visible = false;
            welcomeUserPanel.Visible = false;

            var logged = this.IsLogged();

            if (logged)
            {
                btnMenu.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var areLoggedUser = this.IsLogged();

            if (!areLoggedUser)
            {
                MessageBox.Show(ErrorMessagesConstants.SaveWithougthUser, ErrorMessagesConstants.MsgBoxSaveCaption);
                userameInput.Clear();
                userPasswordInput.Clear();
                displayMenuItems.Visible = false;
                loginSignContainer.Visible = true;
            }
            else
            {
               //this.user.NotesList.Add(new Note("dgfg", Common.Enums.StatusType.Ongoing, DateTime.Now, "gfdgfd"));
                SaveTxt.Save(@"../../Notes/customNotes.txt", "dsfd");
            }
        }

        private void btnChangeBackColor_MouseClick(object sender, MouseEventArgs e)
        {
            this.ChangeBGColor(textNoteContainer, titleNoteContainer);
        }

        private void btnChangeTextColor_Click(object sender, EventArgs e)
        {
            this.ChangeTextColor(textNoteContainer, titleNoteContainer);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textNoteContainer.Clear();
            titleNoteContainer.Clear();
        }

        private void btnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            menuContainer.Visible = true;
            displayMenuItems.Visible = true;
            loginSignContainer.Visible = false;
            welcomeUserPanel.Visible = true;
            displayMenuItems.Visible = false;
            btnMenu.Visible = false;
        }
    }
}

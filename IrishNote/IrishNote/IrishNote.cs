namespace IrishNote
{
    using Common.Constants;
    using Common.Contracts;
    using Common.DataLogic;
    using Common.Models;
    using System;
    using System.Windows.Forms;

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
            MessageBox.Show(AppConstants.UserLoggedMsg + $" {username}", AppConstants.Logged, MessageBoxButtons.OK, MessageBoxIcon.Information);
            loginSignContainer.Visible = false;
            menuContainer.Visible = true;
            welcomeUserPanel.Visible = true;
            welcomeLabel.Text = AppConstants.WelcomeMsg + $" {username}";
            btnMenu.Visible = true;
        }

        private void ChangeBGColor(RichTextBox container)
        {
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                container.BackColor = colorDialog.Color;
            }
        }

        private void ChangeBGColor(TextBox container)
        {
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                container.BackColor = colorDialog.Color;
            }
        }

        private void ChangeTextColor(TextBox container)
        {
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                container.ForeColor = colorDialog.Color;
            }
        }

        private bool IsLogged()
        {
            var isLogged = this.isClickedSignUp || this.isCleckedLogOn;

            return isLogged;
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var candidateFirstName = "dsfds";// inputFirstName.Text;
            var candidateLastName = "dsfds";//inputLastName.Text;
            var candidateUserName = "ninja";//inputUserName.Text;
            var candidateEmail = "dsfds";// inputEmail.Text;
            var candidatePassword = "dsfds";//inputPassword.Text;

            var messageBoxCaption = ErrorMessagesConstants.MsgBoxCaptionUser;

            try
            {
                var isRegistered = DataMethods.CheckLoginData(candidateUserName);

                if (isRegistered)
                {
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = userameInput.Text;
            var password = userPasswordInput.Text;
            var isRegistered = DataMethods.CheckLoginData(username, password);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(ErrorMessagesConstants.NullDataMsg, ErrorMessagesConstants.MsgBoxLoginDataCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if(isRegistered)
            {  
                // ToDO: make logic btw user and his data
                this.PrintMenuLogged(username);
                this.isCleckedLogOn = true;
            }
            else
            {
                MessageBox.Show(ErrorMessagesConstants.InvalidLoginDataMsg, ErrorMessagesConstants.MsgBoxLoginDataCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuContainer.Visible = false;
            displayMenuItems.Visible = false;
            loginSignContainer.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var areLoggedUser = this.IsLogged();

            if (!areLoggedUser)
            {
                MessageBox.Show(ErrorMessagesConstants.SaveWithougthUser,ErrorMessagesConstants.MsgBoxSaveCaption);
                displayMenuItems.Visible = false;
                loginSignContainer.Visible = true;
            }
            else
            {
                
            }
        }

        private void btnChangeBackColor_MouseClick(object sender, MouseEventArgs e)
        {
            this.ChangeBGColor(textNoteContainer);
            this.ChangeBGColor(titleNoteContainer);

        }

        private void btnChangeTextColor_MouseClick(object sender, MouseEventArgs e)
        {
            this.ChangeBGColor(titleNoteContainer);
            this.ChangeBGColor(titleNoteContainer);
        }
    }
}

namespace IrishNote
{
    using System;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    using Contracts;

    using Models;
    using System.Collections.Generic;
    using Exceptions;
    using System.Xml.Serialization;
    using System.Xml.Linq;
    using System.Linq;
    using System.Xml;
    using System.Data;
    using global::Common.IOFile;
    using global::Common.Constants;
    using Common.Constants;

    public partial class IrishMain : Form
    {
        private IUser user = new User();
        private bool isClickedSignUp = false;
        private bool isCleckedLogOn = false;

        public IrishMain()
        {
            this.InitializeComponent();
        }

        private bool CheckUserExcist(string userName, string password)
        {
            var data = UserData.GetLoginData();
            var isRegistered = data.Where(x => x.Key == userName).ToList();

            if (isRegistered.Count == 0)
            {
                return false;
            }
            else
            {
                var isCorrectData = data.Where(x => x.Value == password).ToList();

                return isCorrectData.Count != 0 ? true : false;
            }
        }

        private void PrintMenuLogged(string username)
        {
            MessageBox.Show(AppConstants.UserLogged + $" {username}", AppConstants.Logged, MessageBoxButtons.OK, MessageBoxIcon.Information);
            loginSignContainer.Visible = false;
            menuContainer.Visible = true;
            welcomeUserPanel.Visible = true;
            welcomeLabel.Text = AppConstants.WelcomeBack + $" {username}";
            btnMenu.Visible = true;
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
            var candidateFirstName = inputFirstName.Text;
            var candidateLastName = inputLastName.Text;
            var candidateUserName = inputUserName.Text;
            var candidateEmail = inputEmail.Text;
            var candidatePassword = inputPassword.Text;

            var messageBoxCaption = ErrorMessagesConstants.MsgBoxCaptionUser;

            try
            {
                var isRegistered = this.CheckUserExcist(candidateUserName, candidatePassword);

                if (isRegistered)
                {
                    MessageBox.Show(ErrorMessagesConstants.MsgUserExcist, messageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    this.user.FirstName = candidateFirstName;
                    this.user.LastName = candidateLastName;
                    this.user.Username = candidateUserName;
                    this.user.Email = candidateEmail;
                    this.user.Password = candidatePassword;

                    UserData.CreateData(candidateUserName, candidatePassword);
                    this.PrintMenuLogged(candidateUserName);

                    this.isClickedSignUp = true;
                }
            }
            catch (ArgumentException msg)
            {
                MessageBox.Show(msg.Message, messageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (FormatException msg)
            {
                MessageBox.Show(msg.Message, messageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString(), messageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = userameInput.Text;
            var password = userPasswordInput.Text;
            var isRegistered = this.CheckUserExcist(username, password);

            if (isRegistered)
            {
                this.PrintMenuLogged(username);
                this.isCleckedLogOn = true;
            }
            else
            {
                MessageBox.Show(ErrorMessagesConstants.InvalidLoginData, ErrorMessagesConstants.MsgBoxLoginDataCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void button1_Click(object sender, EventArgs e)
        {
            var caption = string.Empty;
            var customText = string.Empty;

            titleNoteContainer.Text = caption;
            textNoteContainer.Text = customText;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuContainer.Visible = false;
            displayMenuItems.Visible = false;
            loginSignContainer.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}

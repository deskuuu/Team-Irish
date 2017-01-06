namespace IrishNote
{
    using System;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    using Constants;
    using Contracts;
    using IOFile;
    using Models;
    using System.Collections.Generic;

    public partial class IrishMain : Form
    {
        public IrishMain()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Open app source link in the browser.
        /// </summary>
        /// 
        private void AboutHyperlink_MouseClick(object sender, MouseEventArgs e)
        {
            var error = string.Empty;
            var hyperlink = AppConstants.AboutHyperlink;

            try
            {
                System.Diagnostics.Process.Start(hyperlink);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(ExceptionConstants.NotFoundHyperlinkException + hyperlink, ExceptionConstants.HyperlinkException, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ExceptionConstants.HyperlinkException, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Close app.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Create a new user, save data and redirect to the app menu.
        /// </summary>
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var firstName = "Desi";// inputFirstName.Text;
            var lastName = "Manova";// inputLastName.Text;
            var userName = "deskuuu";// inputUserName.Text;
            var email = "des@a.bg";// inputEmail.Text;
            var password = "hack";// inputPassword.Text;

            try
            {
                IUser newUser = new User(lastName, userName, email, password, firstName);

                SaveData.Save(newUser);

                loginSignData.Visible = false;
                menuPanel.Visible = true;
            }
            catch (ArgumentException msg)
            {
                MessageBox.Show(msg.Message, ExceptionConstants.Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            catch (FormatException msg)
            {
                MessageBox.Show(msg.Message, ExceptionConstants.Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, ExceptionConstants.Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// Check if has that user and redirect to the app menu.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get input data.
            var username = userameInput.Text;
            var password = userPasswordInput.Text;

            //Get all usersdata.
            var users = ReadData.GetData();


            //ToDo: Check if has user, connect user with his data
            //loginSignData.Visible = false;
            //menuPanel.Visible = true;
        }

        /// <summary>
        /// Create custom user with default data and redirect to custom note.(Do not save custom notes!).
        /// </summary>
        private void btnCustomNote_Click(object sender, EventArgs e)
        {
            var guest = new User();

            loginSignData.Visible = false;
            displayMenuItems.Visible = true;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEvents_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void displayMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            displayMenuItems.Visible = false;
            loginSignData.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var caption = string.Empty;
            var customText = string.Empty;

            itemTitle.Text = caption;
            textBase.Text = customText;
        }
    }
}

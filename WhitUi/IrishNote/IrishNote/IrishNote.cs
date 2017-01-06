namespace IrishNote
{
    using System;
    using System.Windows.Forms;
    using System.IO;

    using Contracts;
    using Constants;
    using Common.IOFile;
    using Models;
    using IOFile;
    using System.Text;

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
                MessageBox.Show($"The hyperlink address \"{hyperlink}\" was not found.", "Hyperlink exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hyperlink exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// 
        /// </summary>
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var firstName = inputFirstName.Text;
            var lastName = inputLastName.Text;
            var userName = inputUserName.Text;
            var email = inputEmail.Text;
            var password = inputPassword.Text;

            IUser newUser = new User(lastName, userName, email, password, firstName);

            SaveData.Save(newUser);

            loginSignnDatas.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var users = ReadData.GetData();
            var st = new StringBuilder();
            foreach (var item in users)
            {
                st.AppendLine(item.Key + ":" + item.Value);
            }
            MessageBox.Show(st.ToString(), "User data");
            // loginSignnDatas.Visible = false;
        }
    }
}

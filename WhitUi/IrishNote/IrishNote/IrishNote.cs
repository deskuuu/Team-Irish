namespace IrishNote
{
    using System;
    using System.Windows.Forms;

    using Common.AppConstants;

    public partial class IrishMain : Form
    {
        public IrishMain()
        {
            this.InitializeComponent();
        }

        private void IrishMain_Activated(object sender, EventArgs e)
        {
        }
    
        private void AboutHyperlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(AppConstants.AboutHyperlink);
            }
            catch (InvalidAboutHyperLinkException msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //Method for input text imitates placeholders.
        //
        public void RemoveInputText(TextBox textBox, object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }
    }
}

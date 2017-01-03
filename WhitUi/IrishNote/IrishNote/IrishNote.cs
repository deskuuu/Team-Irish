namespace IrishNote
{
    using System;
    using System.Windows.Forms;

    public partial class IrishMain : Form
    {
        public IrishMain()
        {
            InitializeComponent();
        }

        private void IrishMain_Activated(object sender, EventArgs e)
        {

        }

        private void LoginClicked(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AboutClicked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
               // System.Diagnostics.Process.Start(AppConstants.AboutHyperlink);
            }
            catch (InvalidAboutHyperLinkException msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AboutClicked_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void IrishMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

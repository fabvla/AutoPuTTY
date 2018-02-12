using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;

namespace AutoPuTTY
{
    public partial class popupAbout : Form
    {
        public popupAbout()
        {
            InitializeComponent();
            tVersion.Text = Properties.Settings.Default.version;
        }

        private void liWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(liWebsite.Text);
        }

        private void piAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
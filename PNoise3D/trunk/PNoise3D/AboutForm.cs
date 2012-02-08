using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PNoise3D
{
    partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Text = String.Format("About {0}", "PNoise3D");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("iexplore",
                          "http://www.xnamag.de/forum/viewtopic.php?t=4773&postdays=0&postorder=asc&start=0&sid=db0639228555117a428444eb90c770f7");
        }
    }
}

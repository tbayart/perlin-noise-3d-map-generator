using System;
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metric_Designer
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void email(string mailTo)
        {
            try
            {
                System.Diagnostics.Process.Start(mailTo);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("You do not appear to have a default Mail Client selected.");
            }
        }

        private void emailLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            email("mailto:jsh226@byu.edu");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            email("mailto:byutrg@gmail.com");
        }
    }
}

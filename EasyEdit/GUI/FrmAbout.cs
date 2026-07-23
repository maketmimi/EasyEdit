using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyEdit
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void LLbGithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LLbGithubLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/maketmimi");
        }
    }
}

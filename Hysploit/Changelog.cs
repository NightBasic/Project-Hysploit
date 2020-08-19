using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hysploit
{
    public partial class Changelog : Form
    {
        public Changelog()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://pastebin.com/raw/M3tVuYxs");
        }

    }
}

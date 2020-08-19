using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hysploit;
using Azuki;

namespace Hysploit
{
    public partial class Links : Form
    {
        public Links()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/NekoHynix/Project-Hysploit");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/X2xcVsT");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://wearedevs.net/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://pastebin.com/1WwBzGYv");
        }
    }
}

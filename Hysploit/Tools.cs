using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hysploit;
using Azuki;

namespace Hysploit
{
    public partial class Tools : Form
    {
        ExploitAPI api = new ExploitAPI();

        public Tools()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           api.SendCommand("btools me");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed=100");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            api.SendCommand("kill me");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            api.SendCommand("boxesp");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            api.SendCommand("float me");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            api.SendCommand("nofloat me");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName("RobloxPlayerBeta").Length > 0)
            {
                foreach (var a in System.Diagnostics.Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    a.Kill();
                }
            }
            else;
            {
                MessageBox.Show("Done!", "Project Hysploit");
            }
        }
    }
}

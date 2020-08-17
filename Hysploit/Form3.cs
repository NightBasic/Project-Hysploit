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
    public partial class Form3 : Form
    {
        ExploitAPI api = new ExploitAPI();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           api.SendCommand("btools me");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.SendLimitedLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed=100");
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
    }
}

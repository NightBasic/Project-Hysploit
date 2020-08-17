using System;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using Azuki;

namespace Exploit_Template_with_WRDAPI
{
    public partial class Form1 : Form
    {
        readonly ExploitAPI api = new ExploitAPI();




        public Form1()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://pastebin.com/raw/pvhQTkda").Contains("0.1"))
            {
                if (MessageBox.Show("Looks like a new update is out, would you like to Download now?", "Project Hysploit beta test", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/NekoHynix/Project/releases");
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("You are up to date :)", "Project Azuki");
            }
        }

        private void BtnInject_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string script = inputScript.Text;
            api.SendLuaScript(script);
        }

        private void BtnSpeed_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed=100");
        }

        private void BtnBtools_Click(object sender, EventArgs e)
        {
            api.SendCommand("btools me");
        }

        private void BtnTPTo_Click(object sender, EventArgs e)
        {
            string username = inputTPTo.Text;
            api.SendCommand("teleport " + username);
        }

        private void CheckInjected()
        {
            if (api.isAPIAttached())
            {
                txtIsInjected.Text = "Ready!";
            }
            else
            {
                txtIsInjected.Text = "Please Attach";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckInjected();
        }

        private void InjectedChecker_Tick(object sender, EventArgs e)
        {
            CheckInjected();
        }

        private void txtIsInjected_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.SendCommand("kill me");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            api.SendCommand("boxesp");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            api.SendCommand("nofloat me");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            api.SendCommand("float me");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/X2xcVsT");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            api.SendCommand("boxespteamcheck");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/1WwBzGYv");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/M3tVuYxs");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/M3tVuYxs");
        }
    }
}

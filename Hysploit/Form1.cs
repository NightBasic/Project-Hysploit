using System;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using Hysploit;
using System.IO;
using Azuki;

namespace Exploit_Template_with_WRDAPI
{
    public partial class Form1 : Form
    {
        ExploitAPI api = new ExploitAPI();




        public Form1()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://pastebin.com/raw/pvhQTkda").Contains("0.5"))
            {
                if (MessageBox.Show("Looks like a new update is out, would you like to Download it?", "Project Hysploit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/NekoHynix/Project-Hysploit/releases");
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("You are up to date :)", "Project Hysploit");
            }
        }

        private void BtnInject_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            api.SendLuaScript(script);
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

        private void button10_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "Project Hysploit", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}

using System;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using Hysploit;
using System.IO;
using Azuki;
using TrinitySeal;

namespace Hysploit
{
    public partial class Main : Form
    {
        ExploitAPI api = new ExploitAPI();




        public Main()
        {
            InitializeComponent();
            SealCheck.HashChecks();

            if (TrinitySeal.SealCheck.isValidDLL)
            {

                if (!TrinitySeal.ProgramVariables.Freemode)
                { 
                    TrinitySeal.Security.ChallengeCheck();
                }

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
            Links f2 = new Links();
            f2.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Tools f3 = new Tools();
            f3.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            About f4 = new About();
            f4.ShowDialog();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Changelog f5 = new Changelog();
            f5.ShowDialog();
        }
    }
}

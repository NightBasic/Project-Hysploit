using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinitySeal;

namespace Hysploit
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SealCheck.HashChecks(); //Checks the integrity of the TrinitySeal and Newtonsoft DLL

            if (SealCheck.isValidDLL)
            {
                TrinitySeal.Seal.Secret = "BksAuv0zwbHgnooDpv0eEEnjKMIN1pCKaRtAyhaWzh6Ln";
                TrinitySeal.Seal.Initialize("0.6");
            }

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            SealCheck.HashChecks(); 

            if (TrinitySeal.SealCheck.isValidDLL)
            {
                bool response = TrinitySeal.Seal.Login(username.Text, password.Text); 
                if (response)
                {
                    new Main().Show();
                    this.Hide();
                }
            }
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }
    }
}

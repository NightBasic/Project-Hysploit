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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            SealCheck.HashChecks(); // Check integrity of auth files

            if (SealCheck.isValidDLL)
            {
                // The register arguments goes in the order: username, password, email, token
                bool response = TrinitySeal.Seal.Register(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                if (response)
                {
                    // Register was successful
                }
                else
                {
                    // Register wasn't a success
                }
            }
        }
    }
}

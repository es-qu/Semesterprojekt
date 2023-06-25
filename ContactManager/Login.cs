using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            if(TxtUsername.Text != String.Empty && TxtPassword.Text != String.Empty)
            {
                if(TxtUsername.Text == "root" && TxtPassword.Text == "Password123")
                {
                    // Open menu
                    Program.Auth = true;
                    this.Close();
                } else
                {
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Wrong username or password", "Error", buttons, icon);
                }
            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Please type in username and password", "Error", buttons, icon);
            }
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CmdLogin_Click(sender, e);
            }
        }
    }
}

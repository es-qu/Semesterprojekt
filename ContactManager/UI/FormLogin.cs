using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ContactManager
{
    public partial class FormLogin : MaterialForm
    {
        MaterialSkinManager manager = Program.GetStandardManager();

        public FormLogin()
        {
            InitializeComponent();

            // Set up MaterialSkin
            manager.AddFormToManage(this);
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            Program.Auth = true;
            this.Close();


            /*if (TxtUsername.Text != String.Empty && TxtPassword.Text != String.Empty)
            {
                if (TxtUsername.Text == "root" && TxtPassword.Text == "Password123")
                {
                    // Open menu
                    Program.Auth = true;
                    FormMenu menu = new FormMenu();
                    menu.Show(this);
                    this.Hide();
                }
                else
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
            }*/
        }

        private void Any_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtUsername.Text != string.Empty || TxtUsername.Focused)
                {
                    if (TxtPassword.Text != string.Empty || TxtPassword.Focused)
                    {
                        CmdLogin_Click(sender, e);
                    }
                    else
                    {
                        TxtPassword.Focus();
                    }
                }
                else
                {
                    TxtUsername.Focus();
                }
            }
        }
    }
}

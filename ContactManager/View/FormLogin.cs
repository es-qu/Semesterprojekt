
using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ContactManager
{
    public partial class FormLogin : MaterialForm
    {
        // Declare a MaterialSkinManager instance to manage MaterialSkin theming.
        MaterialSkinManager manager = Program.GetStandardManager();

        public FormLogin()
        {
            InitializeComponent();

            // Set up MaterialSkin for this form.
            manager.AddFormToManage(this);
        }

        // Event handler for the login button click.
        private void CmdLogin_Click(object sender, EventArgs e)
        {
            // Check if both username and password fields are not empty.
            if (TxtUsername.Text != String.Empty && TxtPassword.Text != String.Empty)
            {
                //Check username and password
                if (TxtUsername.Text == "root" && TxtPassword.Text == "Password123")
                {
                    // Set the authentication flag to true.
                    Program.Auth = true;
                    // Open the main menu form and hide the login form.
                    FormMenu menu = new FormMenu();
                    menu.Show(this);
                    this.Hide();
                }
                else
                {
                    // Display an error message for wrong credentials.
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Wrong username or password", "Error", buttons, icon);
                }
            }
            else
            {
                // Display an error message if any of the fields are empty.
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Please type in username and password", "Error", buttons, icon);
            }
        }

        // Event handler for the 'Enter' key press in the form's controls.
        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            // Trigger login button click event if both fields are filled and 'Enter' is pressed.
            if (e.KeyCode == Keys.Enter)
            {
                // Check if the username field is filled or focused.
                if (TxtUsername.Text != string.Empty || TxtUsername.Focused)
                {
                    // Check if the password field is filled or focused.
                    if (TxtPassword.Text != string.Empty || TxtPassword.Focused)
                    {
                        CmdLogin_Click(sender, e);
                    }
                    else
                    {
                        // Set focus to the password field if it's empty.
                        TxtPassword.Focus();
                    }
                }
                else
                {
                    // Set focus to the username field if it's empty.
                    TxtUsername.Focus();
                }
            }
        }
    }
}
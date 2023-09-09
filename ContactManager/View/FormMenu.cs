using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.View;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ContactManager
{
    public partial class FormMenu : MaterialForm
    {
        MaterialSkinManager manager = Program.GetStandardManager();

        public FormMenu()
        {
            if (Program.Auth)
            {
                InitializeComponent();

                manager.AddFormToManage(this);
            }
            else
            {
                MessageBox.Show(this, "Error: authentication required");
                Application.Exit();
            }
        }

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            OpenMainForm(0);
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            OpenMainForm(1);
        }

        private void CmdImport_Click(object sender, EventArgs e)
        {
            Form formImport = new FormImport();
            formImport.Show();
        }


        private void OpenMainForm(int tab = 1)
        {
            Form main = new FormMain(tab);
            //main.ShowDialog();
            main.Show();
        }

        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    OpenMainForm(0);
                    break;

                case Keys.S:
                    OpenMainForm(1);
                    break;

                case Keys.I:
                    Form formImport = new FormImport();
                    formImport.Show();
                    break;

                case Keys.Q:
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        
    }
}

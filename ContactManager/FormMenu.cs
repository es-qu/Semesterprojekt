﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            OpenMainForm(2);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            OpenMainForm(3);
        }


        private void OpenMainForm(int tab = 1)
        {
            Form main = new FormMain(tab);
            main.ShowDialog();
        }

        private void Any_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    OpenMainForm(0);
                    break;

                case Keys.S:
                    OpenMainForm(1);
                    break;

                case Keys.E:
                    OpenMainForm(2);
                    break;

                case Keys.D:
                    OpenMainForm(3);
                    break;

                case Keys.Q:
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

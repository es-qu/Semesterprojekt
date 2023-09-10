using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.View
{
    public partial class FormImport : MaterialForm
    {

        MaterialSkinManager manager = Program.GetStandardManager();

        public FormImport()
        {
            InitializeComponent();
            // Set up MaterialSkin
            manager.AddFormToManage(this);

        }

        private void CmdImportFile_Click(object sender, EventArgs e)
        {

        }

        private void CmdImportConfirm_Click(object sender, EventArgs e)
        {

        }

        private void CmdImportCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

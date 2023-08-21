using System;
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
    public partial class FormSearchAdvanced : MaterialForm
    {
        MaterialSkinManager manager = Program.GetStandardManager();

        FormMain parentFormMain;

        public FormSearchAdvanced(FormMain parentFormMain)
        {
            if (Program.Auth)
            {
                InitializeComponent();

                manager.AddFormToManage(this);

                // Set fontstyle for headlines of filter information sections by type
                Font fontCurrent = LblSearchHeadlineGeneral.Font;
                Font newFont = new Font(fontCurrent.FontFamily, fontCurrent.Size + 1, FontStyle.Bold);
                LblSearchHeadlineGeneral.Font = newFont;
                LblSearchHeadlineCustomer.Font = newFont;
                LblSearchHeadlineTrainee.Font = newFont;
                LblSearchHeadlineEmployee.Font = newFont;

                // Sync the GUI with the filters object of FormMain
                this.parentFormMain = parentFormMain;
                syncAdvancedGUI();
            }
            else
            {
                MessageBox.Show(this, "Error: authentication required");
                Application.Exit();
            }
        }



        private void FormSearchAdvanced_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ChkSearchAdvancedType_CheckedChange
        /// is a method to change the fontcolor to black and disable the information panels by type
        /// </summary>
        private void ChkSearchAdvancedType_CheckedChange(object sender, EventArgs e)
        {
            PnlSearchAdvancedCustomer.Enabled = ChkSearchAdvancedTypeCustomer.Checked;
            PnlSearchAdvancedEmployee.Enabled = ChkSearchAdvancedTypeEmployee.Checked;
            PnlSearchAdvancedTrainee.Enabled = ChkSearchAdvancedTypeTrainee.Checked;
        }

        /// <summary>
        /// Store and sync states
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSearchAdvanced_FormClosing(object sender, FormClosingEventArgs e)
        {
            storeSearchAdvancedFilters();
            parentFormMain.syncSearchGUI();
            //parentFormMain.CmdSearchExec_Click(sender, e);
        }

        /// <summary>
        /// Save the states of all fields in advanced search into the filter object of FormMain
        /// </summary>
        public void storeSearchAdvancedFilters()
        {
            parentFormMain.filters.Inactive = ChkSearchAdvancedInactive.Checked;

            parentFormMain.filters.TypeCustomer = ChkSearchAdvancedTypeCustomer.Checked;
            parentFormMain.filters.TypeEmployee = ChkSearchAdvancedTypeEmployee.Checked;
            parentFormMain.filters.TypeTrainee = ChkSearchAdvancedTypeTrainee.Checked;
        }

        /// <summary>
        /// Copy the states in FormMain's filters object into FormSearchAdvanced's GUI
        /// </summary>
        public void syncAdvancedGUI()
        {
            ChkSearchAdvancedInactive.Checked = parentFormMain.filters.Inactive;

            ChkSearchAdvancedTypeCustomer.Checked = parentFormMain.filters.TypeCustomer;
            ChkSearchAdvancedTypeEmployee.Checked = parentFormMain.filters.TypeEmployee;
            ChkSearchAdvancedTypeTrainee.Checked = parentFormMain.filters.TypeTrainee;
        }
    }
}

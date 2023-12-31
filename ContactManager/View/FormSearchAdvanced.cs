﻿using MaterialSkin;
using MaterialSkin.Controls;
using ContactManager.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            parentFormMain.SyncSearchGUI();
            parentFormMain.CmdSearchExec_Click(sender, e);
        }

        /// <summary>
        /// Save the states of all fields in advanced search into the filter object of FormMain
        /// </summary>
        public void storeSearchAdvancedFilters()
        {
            // Storing checkbox states
            parentFormMain.filters.SearchInactive = ChkSearchAdvancedInactive.Checked;

            parentFormMain.filters.TypeCustomer = ChkSearchAdvancedTypeCustomer.Checked;
            parentFormMain.filters.TypeEmployee = ChkSearchAdvancedTypeEmployee.Checked;
            parentFormMain.filters.TypeTrainee = ChkSearchAdvancedTypeTrainee.Checked;

            // Storing General Information
            parentFormMain.filters.Number = TxtSearchAdvancedNumber.Text;
            parentFormMain.filters.Title = TxtSearchAdvancedTitle.Text;
            parentFormMain.filters.Gender = TxtSearchAdvancedGender.Text;
            parentFormMain.filters.Salutation = TxtSearchAdvancedSalutation.Text;
            parentFormMain.filters.FirstName = TxtSearchAdvancedFirstName.Text;
            parentFormMain.filters.LastName = TxtSearchAdvancedLastName.Text;
            parentFormMain.filters.Address = TxtSearchAdvancedAddress.Text;
            parentFormMain.filters.PostalCode = TxtSearchAdvancedPostalCode.Text;
            parentFormMain.filters.PlaceOfResidence = TxtSearchAdvancedPlaceOfResidence.Text;
            parentFormMain.filters.Nationality = TxtSearchAdvancedNationality.Text;
            parentFormMain.filters.OasiNumber = TxtSearchAdvancedOasiNr.Text;
            parentFormMain.filters.DateOfBirth = TxtSearchAdvancedDateOfBirth.Text;
            parentFormMain.filters.EmailAddress = TxtSearchAdvancedEmailAddress.Text;
            parentFormMain.filters.PrivatePhone = TxtSearchAdvancedPrivatePhone.Text;
            parentFormMain.filters.BusinessPhone = TxtSearchAdvancedBusinessPhone.Text;
            parentFormMain.filters.BusinessAddress = TxtSearchAdvancedBusinessAddress.Text;

            // Storing Customer Information
            parentFormMain.filters.CustomerType = TxtSearchAdvancedCustomerType.Text;
            parentFormMain.filters.CompanyName = TxtSearchAdvancedCompanyName.Text;
            parentFormMain.filters.CompanyContact = TxtSearchAdvancedCompanyContact.Text;

            // Storing Employee Information
            parentFormMain.filters.Departement = TxtSearchAdvancedDepartement.Text;
            parentFormMain.filters.Role = TxtSearchAdvancedRole.Text;
            parentFormMain.filters.CadreLevel = TxtSearchAdvancedCadreLevel.Text;
            parentFormMain.filters.DegreeOfEmployment = TxtSearchAdvancedDegreeOfEmployment.Text;
            parentFormMain.filters.DateOfJoining = TxtSearchAdvancedDateOfJoining.Text;
            parentFormMain.filters.DateOfLeaving = TxtSearchAdvancedDateOfLeaving.Text;

            // Storing Trainee Information
            parentFormMain.filters.CurrentApprenticeshipYear = TxtSearchAdvancedCurrentAppYear.Text;
            parentFormMain.filters.YearsOfApprenticeship = TxtSearchAdvancedYearOfApp.Text;
        }

        /// <summary>
        /// Copy the states in FormMain's filters object into FormSearchAdvanced's GUI
        /// </summary>
        public void syncAdvancedGUI()
        {
            // Syncing checkbox states
            ChkSearchAdvancedInactive.Checked = parentFormMain.filters.SearchInactive;

            ChkSearchAdvancedTypeCustomer.Checked = parentFormMain.filters.TypeCustomer;
            ChkSearchAdvancedTypeEmployee.Checked = parentFormMain.filters.TypeEmployee;
            ChkSearchAdvancedTypeTrainee.Checked = parentFormMain.filters.TypeTrainee;

            // Syncing General Information
            TxtSearchAdvancedNumber.Text = parentFormMain.filters.Number;
            TxtSearchAdvancedTitle.Text = parentFormMain.filters.Title;
            TxtSearchAdvancedGender.Text = parentFormMain.filters.Gender;
            TxtSearchAdvancedSalutation.Text = parentFormMain.filters.Salutation;
            TxtSearchAdvancedFirstName.Text = parentFormMain.filters.FirstName;
            TxtSearchAdvancedLastName.Text = parentFormMain.filters.LastName;
            TxtSearchAdvancedAddress.Text = parentFormMain.filters.Address;
            TxtSearchAdvancedPostalCode.Text = parentFormMain.filters.PostalCode;
            TxtSearchAdvancedPlaceOfResidence.Text = parentFormMain.filters.PlaceOfResidence;
            TxtSearchAdvancedNationality.Text = parentFormMain.filters.Nationality;
            TxtSearchAdvancedOasiNr.Text = parentFormMain.filters.OasiNumber;
            TxtSearchAdvancedDateOfBirth.Text = parentFormMain.filters.DateOfBirth;
            TxtSearchAdvancedEmailAddress.Text = parentFormMain.filters.EmailAddress;
            TxtSearchAdvancedPrivatePhone.Text = parentFormMain.filters.PrivatePhone;
            TxtSearchAdvancedBusinessPhone.Text = parentFormMain.filters.BusinessPhone;
            TxtSearchAdvancedBusinessAddress.Text = parentFormMain.filters.BusinessAddress;

            // Syncing Customer Information
            TxtSearchAdvancedCustomerType.Text = parentFormMain.filters.CustomerType;
            TxtSearchAdvancedCompanyName.Text = parentFormMain.filters.CompanyName;
            TxtSearchAdvancedCompanyContact.Text = parentFormMain.filters.CompanyContact;

            // Syncing Employee Information
            TxtSearchAdvancedDepartement.Text = parentFormMain.filters.Departement;
            TxtSearchAdvancedRole.Text = parentFormMain.filters.Role;
            TxtSearchAdvancedCadreLevel.Text = parentFormMain.filters.CadreLevel;
            TxtSearchAdvancedDegreeOfEmployment.Text = parentFormMain.filters.DegreeOfEmployment;
            TxtSearchAdvancedDateOfJoining.Text = parentFormMain.filters.DateOfJoining;
            TxtSearchAdvancedDateOfLeaving.Text = parentFormMain.filters.DateOfLeaving;

            // Syncing Trainee Information
            TxtSearchAdvancedCurrentAppYear.Text = parentFormMain.filters.CurrentApprenticeshipYear;
            TxtSearchAdvancedYearOfApp.Text = parentFormMain.filters.YearsOfApprenticeship;
        }

        private void CmdSearchAdvancedExec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdSearchAdvancedClear_Click(object sender, EventArgs e)
        {
            parentFormMain.filters = new SearchFilters();
            syncAdvancedGUI();
        }
    }
}

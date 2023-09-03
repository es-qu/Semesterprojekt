using System;

namespace ContactManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TCtrlMain = new MaterialSkin.Controls.MaterialTabControl();
            this.TabSearch = new System.Windows.Forms.TabPage();
            this.CmdSearchClear = new MaterialSkin.Controls.MaterialButton();
            this.LblSearchPerson = new MaterialSkin.Controls.MaterialLabel();
            this.LblNoResults = new System.Windows.Forms.Label();
            this.TxtSearchDateOfBirth = new MaterialSkin.Controls.MaterialTextBox();
            this.LblSearchDateOfBirth = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSearchAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtSearchPlaceOfResidence = new MaterialSkin.Controls.MaterialTextBox();
            this.LblSearchAddress = new MaterialSkin.Controls.MaterialLabel();
            this.LblSearchPlaceOfResidence = new MaterialSkin.Controls.MaterialLabel();
            this.ChkSearchInactive = new MaterialSkin.Controls.MaterialCheckbox();
            this.ChkSearchTypeTrainee = new MaterialSkin.Controls.MaterialCheckbox();
            this.ChkSearchTypeEmployee = new MaterialSkin.Controls.MaterialCheckbox();
            this.ChkSearchTypeCustomer = new MaterialSkin.Controls.MaterialCheckbox();
            this.TxtSearchNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.LblSearchNumber = new MaterialSkin.Controls.MaterialLabel();
            this.LblSearchFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.LblSearchLastName = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSearchFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtSearchLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.LblSearchResultCounter = new MaterialSkin.Controls.MaterialLabel();
            this.CmdSearchCreate = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CmdSearchAdvanced = new MaterialSkin.Controls.MaterialButton();
            this.CmdSearchExec = new MaterialSkin.Controls.MaterialButton();
            this.DataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.PnlSearchPreview = new System.Windows.Forms.Panel();
            this.CmdSearchCancel = new MaterialSkin.Controls.MaterialButton();
            this.LblSearchPreviewNumberOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewTypeOutput = new System.Windows.Forms.Label();
            this.CmdSearchNoteEdit = new MaterialSkin.Controls.MaterialButton();
            this.CmdSearchNoteSave = new MaterialSkin.Controls.MaterialButton();
            this.CmdSearchNoteClear = new MaterialSkin.Controls.MaterialButton();
            this.TxtSearchNote = new System.Windows.Forms.TextBox();
            this.LblSearchPreviewStatus = new System.Windows.Forms.Label();
            this.LblSearchPreviewStatusOutput = new System.Windows.Forms.Label();
            this.LblSearchNotes = new MaterialSkin.Controls.MaterialLabel();
            this.LblSearchPreviewType = new System.Windows.Forms.Label();
            this.LblSearchPreviewNumber = new System.Windows.Forms.Label();
            this.CmdSearchPersonEdit = new MaterialSkin.Controls.MaterialButton();
            this.PnlSearchPreviewCustomer = new System.Windows.Forms.Panel();
            this.LblSearchPreviewCompanyContactOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewCompanyNameOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewCustomerTypeOutput = new System.Windows.Forms.Label();
            this.LblSearchHeadlineCustomer = new System.Windows.Forms.Label();
            this.LblSearchPreviewCompanyContact = new System.Windows.Forms.Label();
            this.LblSearchPreviewCustomerType = new System.Windows.Forms.Label();
            this.LblSearchPreviewCompanyName = new System.Windows.Forms.Label();
            this.CmdSearchPersonDelete = new MaterialSkin.Controls.MaterialButton();
            this.PnlSearchPreviewTrainee = new System.Windows.Forms.Panel();
            this.LblSearchPreviewYearsOfAppOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewCurrentAppYearOutput = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LblSearchPreviewCurrentAppYear = new System.Windows.Forms.Label();
            this.LblSearchPreviewYearsOfApp = new System.Windows.Forms.Label();
            this.PnlSearchPreviewEmployee = new System.Windows.Forms.Panel();
            this.LblSearchPreviewDateOfLeaving = new System.Windows.Forms.Label();
            this.LblSearchPreviewDateOfJoining = new System.Windows.Forms.Label();
            this.LblSearchPreviewCadreLevel = new System.Windows.Forms.Label();
            this.LblSearchPreviewEmployee = new System.Windows.Forms.Label();
            this.LblSearchPreviewRole = new System.Windows.Forms.Label();
            this.LblSearchPreviewDegreeOfEmployment = new System.Windows.Forms.Label();
            this.LblSearchPreviewDepartement = new System.Windows.Forms.Label();
            this.LblSearchPreviewDateOfLeavingOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewDateOfJoiningOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewCadreLevelOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewRoleOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewDepartementOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewDegreeOfEmploymentOutput = new System.Windows.Forms.Label();
            this.PnlSearchPreviewGeneral = new System.Windows.Forms.Panel();
            this.LblSearchPreviewSalutationOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewSalutation = new System.Windows.Forms.Label();
            this.LblSearchPreviewGenderOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewGender = new System.Windows.Forms.Label();
            this.LblSearchPreviewBusinessAddressOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewBusinessPhoneOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewPrivatePhoneOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewEmailAddressOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewDateOfBirthOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewOasiNumberOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewNationalityOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewPlaceOfResidenceOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewPostalCodeOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewAddressOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewLastNameOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewFirstNameOutput = new System.Windows.Forms.Label();
            this.LblSearchPreviewTitleOutput = new System.Windows.Forms.Label();
            this.LblSearchHeadlineGeneral = new System.Windows.Forms.Label();
            this.LblSearchPreviewTitle = new System.Windows.Forms.Label();
            this.LblSearchPreviewFirstName = new System.Windows.Forms.Label();
            this.LblSearchPreviewLastName = new System.Windows.Forms.Label();
            this.LblSearchPreviewAddress = new System.Windows.Forms.Label();
            this.LblSearchPreviewBusinessAddress = new System.Windows.Forms.Label();
            this.LblSearchPreviewPostalCode = new System.Windows.Forms.Label();
            this.LblSearchPreviewEmailAddress = new System.Windows.Forms.Label();
            this.LblSearchPreviewPlaceOfResidence = new System.Windows.Forms.Label();
            this.LblSearchPreviewBusinessPhone = new System.Windows.Forms.Label();
            this.LblSearchPreviewNationality = new System.Windows.Forms.Label();
            this.LblSearchPreviewPrivatePhone = new System.Windows.Forms.Label();
            this.LblSearchPreviewOasiNumber = new System.Windows.Forms.Label();
            this.LblSearchPreviewDateOfBirth = new System.Windows.Forms.Label();
            this.TabCreateEdit = new System.Windows.Forms.TabPage();
            this.TabCreate = new MaterialSkin.Controls.MaterialCard();
            this.CmdCreateDeletePerson = new MaterialSkin.Controls.MaterialButton();
            this.CmdCreateNoteClear = new MaterialSkin.Controls.MaterialButton();
            this.TxtCreateNote = new System.Windows.Forms.TextBox();
            this.LblCreateNotes = new MaterialSkin.Controls.MaterialLabel();
            this.CmdCreateCancel = new MaterialSkin.Controls.MaterialButton();
            this.CmdCreatePersonSaveAndNew = new MaterialSkin.Controls.MaterialButton();
            this.LblCreateTypeSelection = new System.Windows.Forms.Label();
            this.PnlCreateInfoGeneral = new System.Windows.Forms.Panel();
            this.GrpCreateType = new System.Windows.Forms.GroupBox();
            this.RadCreateEmployee = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadCreateCustomer = new MaterialSkin.Controls.MaterialRadioButton();
            this.ChkCreateTrainee = new MaterialSkin.Controls.MaterialCheckbox();
            this.RadCreateOther = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadCreateFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadCreateMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.SwtCreateActive = new MaterialSkin.Controls.MaterialSwitch();
            this.LblCreateOasiNr = new MaterialSkin.Controls.MaterialLabel();
            this.DatCreateBirthday = new System.Windows.Forms.DateTimePicker();
            this.TxtCreatePlz = new MaterialSkin.Controls.MaterialTextBox();
            this.CmbCreateSalutation = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtCreateAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCreateSalutation = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCreateOasiNr = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtCreatePlaceOfResidence = new MaterialSkin.Controls.MaterialTextBox();
            this.CmbCreateNationality = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtCreateTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtCreateBusinessAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCreateFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.LblCreateBusinessAddress = new MaterialSkin.Controls.MaterialLabel();
            this.LblCreatePLZ = new MaterialSkin.Controls.MaterialLabel();
            this.LblCreateLastName = new MaterialSkin.Controls.MaterialLabel();
            this.LblCreateAddress = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCreateFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCreateNationality = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCreateLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCreatePlaceOfResidence = new MaterialSkin.Controls.MaterialLabel();
            this.LblCreateDateOfBirth = new MaterialSkin.Controls.MaterialLabel();
            this.LblCreateTitle = new MaterialSkin.Controls.MaterialLabel();
            this.LblCreateEmailAddress = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCreateEmailAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCreateBusnissPhone = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCreateBusnissPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCreatePrivatePhone = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCreatePrivatePhone = new MaterialSkin.Controls.MaterialTextBox();
            this.CmdCreateSavePerson = new MaterialSkin.Controls.MaterialButton();
            this.PnlCreateInfoCustomer = new System.Windows.Forms.Panel();
            this.TxtCreateCustomerNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCreateCustomerNumber = new MaterialSkin.Controls.MaterialLabel();
            this.LblCreateCompanyName = new MaterialSkin.Controls.MaterialLabel();
            this.CmbCreateCustomerType = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtCreateCompanyName = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCreateCustomerType = new MaterialSkin.Controls.MaterialLabel();
            this.LblCreateCompanyContact = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCreateCompanyContact = new MaterialSkin.Controls.MaterialTextBox();
            this.PnlCreateInfoEmployee = new System.Windows.Forms.Panel();
            this.NumCreateDegreeOfEmployment = new System.Windows.Forms.NumericUpDown();
            this.PrgDegreeOfEmployment = new MaterialSkin.Controls.MaterialProgressBar();
            this.PnlCreateInfoTrainee = new System.Windows.Forms.Panel();
            this.LblCreateYearOfApp = new MaterialSkin.Controls.MaterialLabel();
            this.NumCreateYearOfApp = new System.Windows.Forms.NumericUpDown();
            this.LblCreateCurrentAppYear = new MaterialSkin.Controls.MaterialLabel();
            this.NumCreateCurrentAppYear = new System.Windows.Forms.NumericUpDown();
            this.LblCreateDateOfJoining = new MaterialSkin.Controls.MaterialLabel();
            this.LblCreateDateOfLeaving = new MaterialSkin.Controls.MaterialLabel();
            this.DatCreateDateOfLeaving = new System.Windows.Forms.DateTimePicker();
            this.DatCreateDateOfJoining = new System.Windows.Forms.DateTimePicker();
            this.TxtCreateEmployeeNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.LblEmployeeNumber = new MaterialSkin.Controls.MaterialLabel();
            this.LblDepartement = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCreateDepartement = new MaterialSkin.Controls.MaterialTextBox();
            this.NumCadreLevel = new System.Windows.Forms.NumericUpDown();
            this.LblDegreeOfEmployment = new MaterialSkin.Controls.MaterialLabel();
            this.LblCadreLevel = new MaterialSkin.Controls.MaterialLabel();
            this.LblRole = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCreateRole = new MaterialSkin.Controls.MaterialTextBox();
            this.GrpCreateGender = new System.Windows.Forms.GroupBox();
            this.TCtrlMain.SuspendLayout();
            this.TabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSearchResult)).BeginInit();
            this.PnlSearchPreview.SuspendLayout();
            this.PnlSearchPreviewCustomer.SuspendLayout();
            this.PnlSearchPreviewTrainee.SuspendLayout();
            this.PnlSearchPreviewEmployee.SuspendLayout();
            this.PnlSearchPreviewGeneral.SuspendLayout();
            this.TabCreateEdit.SuspendLayout();
            this.TabCreate.SuspendLayout();
            this.PnlCreateInfoGeneral.SuspendLayout();
            this.GrpCreateType.SuspendLayout();
            this.PnlCreateInfoCustomer.SuspendLayout();
            this.PnlCreateInfoEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCreateDegreeOfEmployment)).BeginInit();
            this.PnlCreateInfoTrainee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCreateYearOfApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCreateCurrentAppYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // TCtrlMain
            // 
            this.TCtrlMain.Controls.Add(this.TabSearch);
            this.TCtrlMain.Controls.Add(this.TabCreateEdit);
            this.TCtrlMain.Depth = 0;
            this.TCtrlMain.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCtrlMain.Location = new System.Drawing.Point(4, 64);
            this.TCtrlMain.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TCtrlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCtrlMain.Multiline = true;
            this.TCtrlMain.Name = "TCtrlMain";
            this.TCtrlMain.SelectedIndex = 0;
            this.TCtrlMain.Size = new System.Drawing.Size(1275, 638);
            this.TCtrlMain.TabIndex = 0;
            this.TCtrlMain.SelectedIndexChanged += new System.EventHandler(this.TCtrlMain_SelectedIndexChanged);
            // 
            // TabSearch
            // 
            this.TabSearch.Controls.Add(this.CmdSearchClear);
            this.TabSearch.Controls.Add(this.LblSearchPerson);
            this.TabSearch.Controls.Add(this.LblNoResults);
            this.TabSearch.Controls.Add(this.TxtSearchDateOfBirth);
            this.TabSearch.Controls.Add(this.LblSearchDateOfBirth);
            this.TabSearch.Controls.Add(this.TxtSearchAddress);
            this.TabSearch.Controls.Add(this.TxtSearchPlaceOfResidence);
            this.TabSearch.Controls.Add(this.LblSearchAddress);
            this.TabSearch.Controls.Add(this.LblSearchPlaceOfResidence);
            this.TabSearch.Controls.Add(this.ChkSearchInactive);
            this.TabSearch.Controls.Add(this.ChkSearchTypeTrainee);
            this.TabSearch.Controls.Add(this.ChkSearchTypeEmployee);
            this.TabSearch.Controls.Add(this.ChkSearchTypeCustomer);
            this.TabSearch.Controls.Add(this.TxtSearchNumber);
            this.TabSearch.Controls.Add(this.LblSearchNumber);
            this.TabSearch.Controls.Add(this.LblSearchFirstName);
            this.TabSearch.Controls.Add(this.LblSearchLastName);
            this.TabSearch.Controls.Add(this.TxtSearchFirstName);
            this.TabSearch.Controls.Add(this.TxtSearchLastName);
            this.TabSearch.Controls.Add(this.LblSearchResultCounter);
            this.TabSearch.Controls.Add(this.CmdSearchCreate);
            this.TabSearch.Controls.Add(this.materialLabel1);
            this.TabSearch.Controls.Add(this.CmdSearchAdvanced);
            this.TabSearch.Controls.Add(this.CmdSearchExec);
            this.TabSearch.Controls.Add(this.DataGridViewSearchResult);
            this.TabSearch.Controls.Add(this.TxtSearch);
            this.TabSearch.Controls.Add(this.PnlSearchPreview);
            this.TabSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabSearch.Location = new System.Drawing.Point(4, 34);
            this.TabSearch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabSearch.Name = "TabSearch";
            this.TabSearch.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabSearch.Size = new System.Drawing.Size(1267, 600);
            this.TabSearch.TabIndex = 0;
            this.TabSearch.Text = "Search";
            this.TabSearch.UseVisualStyleBackColor = true;
            // 
            // CmdSearchClear
            // 
            this.CmdSearchClear.AutoSize = false;
            this.CmdSearchClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchClear.Depth = 0;
            this.CmdSearchClear.DrawShadows = true;
            this.CmdSearchClear.HighEmphasis = true;
            this.CmdSearchClear.Icon = null;
            this.CmdSearchClear.Location = new System.Drawing.Point(472, 70);
            this.CmdSearchClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchClear.Name = "CmdSearchClear";
            this.CmdSearchClear.Size = new System.Drawing.Size(145, 30);
            this.CmdSearchClear.TabIndex = 135;
            this.CmdSearchClear.Text = "CLEAR";
            this.CmdSearchClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchClear.UseAccentColor = false;
            this.CmdSearchClear.UseVisualStyleBackColor = true;
            this.CmdSearchClear.Click += new System.EventHandler(this.CmdSearchClear_Click);
            // 
            // LblSearchPerson
            // 
            this.LblSearchPerson.AutoSize = true;
            this.LblSearchPerson.Depth = 0;
            this.LblSearchPerson.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSearchPerson.Location = new System.Drawing.Point(10, 361);
            this.LblSearchPerson.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchPerson.Name = "LblSearchPerson";
            this.LblSearchPerson.Size = new System.Drawing.Size(53, 19);
            this.LblSearchPerson.TabIndex = 134;
            this.LblSearchPerson.Text = "Results";
            // 
            // LblNoResults
            // 
            this.LblNoResults.AutoSize = true;
            this.LblNoResults.BackColor = System.Drawing.Color.DimGray;
            this.LblNoResults.ForeColor = System.Drawing.Color.White;
            this.LblNoResults.Location = new System.Drawing.Point(279, 455);
            this.LblNoResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNoResults.Name = "LblNoResults";
            this.LblNoResults.Size = new System.Drawing.Size(59, 14);
            this.LblNoResults.TabIndex = 128;
            this.LblNoResults.Text = "No Results";
            this.LblNoResults.Visible = false;
            // 
            // TxtSearchDateOfBirth
            // 
            this.TxtSearchDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchDateOfBirth.Depth = 0;
            this.TxtSearchDateOfBirth.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSearchDateOfBirth.Location = new System.Drawing.Point(496, 265);
            this.TxtSearchDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtSearchDateOfBirth.MaxLength = 50;
            this.TxtSearchDateOfBirth.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchDateOfBirth.Multiline = false;
            this.TxtSearchDateOfBirth.Name = "TxtSearchDateOfBirth";
            this.TxtSearchDateOfBirth.Size = new System.Drawing.Size(121, 50);
            this.TxtSearchDateOfBirth.TabIndex = 11;
            this.TxtSearchDateOfBirth.Text = "";
            this.TxtSearchDateOfBirth.Enter += new System.EventHandler(this.SearchFilters_Enter);
            this.TxtSearchDateOfBirth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // LblSearchDateOfBirth
            // 
            this.LblSearchDateOfBirth.AutoSize = true;
            this.LblSearchDateOfBirth.Depth = 0;
            this.LblSearchDateOfBirth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchDateOfBirth.Location = new System.Drawing.Point(496, 238);
            this.LblSearchDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSearchDateOfBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchDateOfBirth.Name = "LblSearchDateOfBirth";
            this.LblSearchDateOfBirth.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblSearchDateOfBirth.Size = new System.Drawing.Size(89, 19);
            this.LblSearchDateOfBirth.TabIndex = 126;
            this.LblSearchDateOfBirth.Text = "Date of birth";
            // 
            // TxtSearchAddress
            // 
            this.TxtSearchAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchAddress.Depth = 0;
            this.TxtSearchAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSearchAddress.Location = new System.Drawing.Point(9, 265);
            this.TxtSearchAddress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtSearchAddress.MaxLength = 50;
            this.TxtSearchAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchAddress.Multiline = false;
            this.TxtSearchAddress.Name = "TxtSearchAddress";
            this.TxtSearchAddress.Size = new System.Drawing.Size(238, 50);
            this.TxtSearchAddress.TabIndex = 9;
            this.TxtSearchAddress.Text = "";
            this.TxtSearchAddress.Enter += new System.EventHandler(this.SearchFilters_Enter);
            this.TxtSearchAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // TxtSearchPlaceOfResidence
            // 
            this.TxtSearchPlaceOfResidence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchPlaceOfResidence.Depth = 0;
            this.TxtSearchPlaceOfResidence.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSearchPlaceOfResidence.Location = new System.Drawing.Point(266, 265);
            this.TxtSearchPlaceOfResidence.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtSearchPlaceOfResidence.MaxLength = 50;
            this.TxtSearchPlaceOfResidence.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchPlaceOfResidence.Multiline = false;
            this.TxtSearchPlaceOfResidence.Name = "TxtSearchPlaceOfResidence";
            this.TxtSearchPlaceOfResidence.Size = new System.Drawing.Size(210, 50);
            this.TxtSearchPlaceOfResidence.TabIndex = 10;
            this.TxtSearchPlaceOfResidence.Text = "";
            this.TxtSearchPlaceOfResidence.Enter += new System.EventHandler(this.SearchFilters_Enter);
            this.TxtSearchPlaceOfResidence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // LblSearchAddress
            // 
            this.LblSearchAddress.AutoSize = true;
            this.LblSearchAddress.Depth = 0;
            this.LblSearchAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchAddress.Location = new System.Drawing.Point(10, 238);
            this.LblSearchAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSearchAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchAddress.Name = "LblSearchAddress";
            this.LblSearchAddress.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblSearchAddress.Size = new System.Drawing.Size(58, 19);
            this.LblSearchAddress.TabIndex = 125;
            this.LblSearchAddress.Text = "Address";
            // 
            // LblSearchPlaceOfResidence
            // 
            this.LblSearchPlaceOfResidence.AutoSize = true;
            this.LblSearchPlaceOfResidence.Depth = 0;
            this.LblSearchPlaceOfResidence.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchPlaceOfResidence.Location = new System.Drawing.Point(263, 238);
            this.LblSearchPlaceOfResidence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSearchPlaceOfResidence.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchPlaceOfResidence.Name = "LblSearchPlaceOfResidence";
            this.LblSearchPlaceOfResidence.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblSearchPlaceOfResidence.Size = new System.Drawing.Size(130, 19);
            this.LblSearchPlaceOfResidence.TabIndex = 124;
            this.LblSearchPlaceOfResidence.Text = "Place of residence";
            // 
            // ChkSearchInactive
            // 
            this.ChkSearchInactive.AutoSize = true;
            this.ChkSearchInactive.Depth = 0;
            this.ChkSearchInactive.Location = new System.Drawing.Point(472, 17);
            this.ChkSearchInactive.Margin = new System.Windows.Forms.Padding(0);
            this.ChkSearchInactive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkSearchInactive.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkSearchInactive.Name = "ChkSearchInactive";
            this.ChkSearchInactive.Ripple = true;
            this.ChkSearchInactive.Size = new System.Drawing.Size(145, 37);
            this.ChkSearchInactive.TabIndex = 2;
            this.ChkSearchInactive.Text = "Include inactive";
            this.ChkSearchInactive.UseVisualStyleBackColor = true;
            // 
            // ChkSearchTypeTrainee
            // 
            this.ChkSearchTypeTrainee.AutoSize = true;
            this.ChkSearchTypeTrainee.Checked = true;
            this.ChkSearchTypeTrainee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSearchTypeTrainee.Depth = 0;
            this.ChkSearchTypeTrainee.Location = new System.Drawing.Point(243, 62);
            this.ChkSearchTypeTrainee.Margin = new System.Windows.Forms.Padding(0);
            this.ChkSearchTypeTrainee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkSearchTypeTrainee.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkSearchTypeTrainee.Name = "ChkSearchTypeTrainee";
            this.ChkSearchTypeTrainee.Ripple = true;
            this.ChkSearchTypeTrainee.Size = new System.Drawing.Size(88, 37);
            this.ChkSearchTypeTrainee.TabIndex = 5;
            this.ChkSearchTypeTrainee.Text = "Trainee";
            this.ChkSearchTypeTrainee.UseVisualStyleBackColor = true;
            // 
            // ChkSearchTypeEmployee
            // 
            this.ChkSearchTypeEmployee.AutoSize = true;
            this.ChkSearchTypeEmployee.Checked = true;
            this.ChkSearchTypeEmployee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSearchTypeEmployee.Depth = 0;
            this.ChkSearchTypeEmployee.Location = new System.Drawing.Point(125, 62);
            this.ChkSearchTypeEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.ChkSearchTypeEmployee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkSearchTypeEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkSearchTypeEmployee.Name = "ChkSearchTypeEmployee";
            this.ChkSearchTypeEmployee.Ripple = true;
            this.ChkSearchTypeEmployee.Size = new System.Drawing.Size(104, 37);
            this.ChkSearchTypeEmployee.TabIndex = 4;
            this.ChkSearchTypeEmployee.Text = "Employee";
            this.ChkSearchTypeEmployee.UseVisualStyleBackColor = true;
            // 
            // ChkSearchTypeCustomer
            // 
            this.ChkSearchTypeCustomer.AutoSize = true;
            this.ChkSearchTypeCustomer.Checked = true;
            this.ChkSearchTypeCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSearchTypeCustomer.Depth = 0;
            this.ChkSearchTypeCustomer.Location = new System.Drawing.Point(9, 62);
            this.ChkSearchTypeCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.ChkSearchTypeCustomer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkSearchTypeCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkSearchTypeCustomer.Name = "ChkSearchTypeCustomer";
            this.ChkSearchTypeCustomer.Ripple = true;
            this.ChkSearchTypeCustomer.Size = new System.Drawing.Size(103, 37);
            this.ChkSearchTypeCustomer.TabIndex = 3;
            this.ChkSearchTypeCustomer.Text = "Customer";
            this.ChkSearchTypeCustomer.UseVisualStyleBackColor = true;
            // 
            // TxtSearchNumber
            // 
            this.TxtSearchNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchNumber.Depth = 0;
            this.TxtSearchNumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSearchNumber.Location = new System.Drawing.Point(374, 159);
            this.TxtSearchNumber.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtSearchNumber.MaxLength = 50;
            this.TxtSearchNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchNumber.Multiline = false;
            this.TxtSearchNumber.Name = "TxtSearchNumber";
            this.TxtSearchNumber.Size = new System.Drawing.Size(181, 50);
            this.TxtSearchNumber.TabIndex = 8;
            this.TxtSearchNumber.Text = "";
            this.TxtSearchNumber.Enter += new System.EventHandler(this.SearchFilters_Enter);
            this.TxtSearchNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // LblSearchNumber
            // 
            this.LblSearchNumber.AutoSize = true;
            this.LblSearchNumber.Depth = 0;
            this.LblSearchNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchNumber.Location = new System.Drawing.Point(374, 133);
            this.LblSearchNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSearchNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchNumber.Name = "LblSearchNumber";
            this.LblSearchNumber.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblSearchNumber.Size = new System.Drawing.Size(181, 19);
            this.LblSearchNumber.TabIndex = 115;
            this.LblSearchNumber.Text = "Customer- / Employee-Nr.";
            // 
            // LblSearchFirstName
            // 
            this.LblSearchFirstName.AutoSize = true;
            this.LblSearchFirstName.Depth = 0;
            this.LblSearchFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchFirstName.Location = new System.Drawing.Point(10, 133);
            this.LblSearchFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSearchFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchFirstName.Name = "LblSearchFirstName";
            this.LblSearchFirstName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblSearchFirstName.Size = new System.Drawing.Size(76, 19);
            this.LblSearchFirstName.TabIndex = 113;
            this.LblSearchFirstName.Text = "First name";
            // 
            // LblSearchLastName
            // 
            this.LblSearchLastName.AutoSize = true;
            this.LblSearchLastName.Depth = 0;
            this.LblSearchLastName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchLastName.Location = new System.Drawing.Point(194, 133);
            this.LblSearchLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSearchLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchLastName.Name = "LblSearchLastName";
            this.LblSearchLastName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblSearchLastName.Size = new System.Drawing.Size(76, 19);
            this.LblSearchLastName.TabIndex = 114;
            this.LblSearchLastName.Text = "Last name";
            // 
            // TxtSearchFirstName
            // 
            this.TxtSearchFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchFirstName.Depth = 0;
            this.TxtSearchFirstName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSearchFirstName.Location = new System.Drawing.Point(9, 159);
            this.TxtSearchFirstName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtSearchFirstName.MaxLength = 50;
            this.TxtSearchFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchFirstName.Multiline = false;
            this.TxtSearchFirstName.Name = "TxtSearchFirstName";
            this.TxtSearchFirstName.Size = new System.Drawing.Size(162, 50);
            this.TxtSearchFirstName.TabIndex = 6;
            this.TxtSearchFirstName.Text = "";
            this.TxtSearchFirstName.Enter += new System.EventHandler(this.SearchFilters_Enter);
            this.TxtSearchFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // TxtSearchLastName
            // 
            this.TxtSearchLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchLastName.Depth = 0;
            this.TxtSearchLastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSearchLastName.Location = new System.Drawing.Point(193, 159);
            this.TxtSearchLastName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtSearchLastName.MaxLength = 50;
            this.TxtSearchLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchLastName.Multiline = false;
            this.TxtSearchLastName.Name = "TxtSearchLastName";
            this.TxtSearchLastName.Size = new System.Drawing.Size(162, 50);
            this.TxtSearchLastName.TabIndex = 7;
            this.TxtSearchLastName.Text = "";
            this.TxtSearchLastName.Enter += new System.EventHandler(this.SearchFilters_Enter);
            this.TxtSearchLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // LblSearchResultCounter
            // 
            this.LblSearchResultCounter.AutoSize = true;
            this.LblSearchResultCounter.Depth = 0;
            this.LblSearchResultCounter.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchResultCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSearchResultCounter.Location = new System.Drawing.Point(10, 570);
            this.LblSearchResultCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchResultCounter.Name = "LblSearchResultCounter";
            this.LblSearchResultCounter.Size = new System.Drawing.Size(70, 19);
            this.LblSearchResultCounter.TabIndex = 106;
            this.LblSearchResultCounter.Text = "Results: 0";
            // 
            // CmdSearchCreate
            // 
            this.CmdSearchCreate.AutoSize = false;
            this.CmdSearchCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchCreate.Depth = 0;
            this.CmdSearchCreate.DrawShadows = true;
            this.CmdSearchCreate.HighEmphasis = true;
            this.CmdSearchCreate.Icon = null;
            this.CmdSearchCreate.Location = new System.Drawing.Point(542, 569);
            this.CmdSearchCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchCreate.Name = "CmdSearchCreate";
            this.CmdSearchCreate.Size = new System.Drawing.Size(75, 30);
            this.CmdSearchCreate.TabIndex = 14;
            this.CmdSearchCreate.Text = "CREATE";
            this.CmdSearchCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchCreate.UseAccentColor = false;
            this.CmdSearchCreate.UseVisualStyleBackColor = true;
            this.CmdSearchCreate.Click += new System.EventHandler(this.CmdSearchCreate_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 102;
            this.materialLabel1.Text = "Full-text search";
            // 
            // CmdSearchAdvanced
            // 
            this.CmdSearchAdvanced.AutoSize = false;
            this.CmdSearchAdvanced.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchAdvanced.Depth = 0;
            this.CmdSearchAdvanced.DrawShadows = true;
            this.CmdSearchAdvanced.HighEmphasis = true;
            this.CmdSearchAdvanced.Icon = null;
            this.CmdSearchAdvanced.Location = new System.Drawing.Point(374, 70);
            this.CmdSearchAdvanced.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchAdvanced.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchAdvanced.Name = "CmdSearchAdvanced";
            this.CmdSearchAdvanced.Size = new System.Drawing.Size(87, 30);
            this.CmdSearchAdvanced.TabIndex = 13;
            this.CmdSearchAdvanced.Text = "Advanced";
            this.CmdSearchAdvanced.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchAdvanced.UseAccentColor = false;
            this.CmdSearchAdvanced.UseVisualStyleBackColor = true;
            this.CmdSearchAdvanced.Click += new System.EventHandler(this.CmdSearchAdvanced_Click);
            // 
            // CmdSearchExec
            // 
            this.CmdSearchExec.AutoSize = false;
            this.CmdSearchExec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchExec.Depth = 0;
            this.CmdSearchExec.DrawShadows = true;
            this.CmdSearchExec.HighEmphasis = true;
            this.CmdSearchExec.Icon = null;
            this.CmdSearchExec.Location = new System.Drawing.Point(374, 17);
            this.CmdSearchExec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchExec.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchExec.Name = "CmdSearchExec";
            this.CmdSearchExec.Size = new System.Drawing.Size(87, 42);
            this.CmdSearchExec.TabIndex = 12;
            this.CmdSearchExec.Text = "Search";
            this.CmdSearchExec.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchExec.UseAccentColor = false;
            this.CmdSearchExec.UseVisualStyleBackColor = true;
            this.CmdSearchExec.Click += new System.EventHandler(this.CmdSearchExec_Click);
            // 
            // DataGridViewSearchResult
            // 
            this.DataGridViewSearchResult.AllowUserToAddRows = false;
            this.DataGridViewSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewSearchResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewSearchResult.BackgroundColor = System.Drawing.Color.DimGray;
            this.DataGridViewSearchResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSearchResult.DefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewSearchResult.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewSearchResult.Location = new System.Drawing.Point(9, 383);
            this.DataGridViewSearchResult.MultiSelect = false;
            this.DataGridViewSearchResult.Name = "DataGridViewSearchResult";
            this.DataGridViewSearchResult.ReadOnly = true;
            this.DataGridViewSearchResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSearchResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewSearchResult.RowHeadersVisible = false;
            this.DataGridViewSearchResult.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewSearchResult.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridViewSearchResult.Size = new System.Drawing.Size(608, 184);
            this.DataGridViewSearchResult.TabIndex = 5;
            this.DataGridViewSearchResult.SelectionChanged += new System.EventHandler(this.DataGridViewSearchResultSelectionChanged_CellClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(141, 25);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(190, 20);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // PnlSearchPreview
            // 
            this.PnlSearchPreview.Controls.Add(this.CmdSearchCancel);
            this.PnlSearchPreview.Controls.Add(this.LblSearchPreviewNumberOutput);
            this.PnlSearchPreview.Controls.Add(this.LblSearchPreviewTypeOutput);
            this.PnlSearchPreview.Controls.Add(this.CmdSearchNoteEdit);
            this.PnlSearchPreview.Controls.Add(this.CmdSearchNoteSave);
            this.PnlSearchPreview.Controls.Add(this.CmdSearchNoteClear);
            this.PnlSearchPreview.Controls.Add(this.TxtSearchNote);
            this.PnlSearchPreview.Controls.Add(this.LblSearchPreviewStatus);
            this.PnlSearchPreview.Controls.Add(this.LblSearchPreviewStatusOutput);
            this.PnlSearchPreview.Controls.Add(this.LblSearchNotes);
            this.PnlSearchPreview.Controls.Add(this.LblSearchPreviewType);
            this.PnlSearchPreview.Controls.Add(this.LblSearchPreviewNumber);
            this.PnlSearchPreview.Controls.Add(this.CmdSearchPersonEdit);
            this.PnlSearchPreview.Controls.Add(this.PnlSearchPreviewCustomer);
            this.PnlSearchPreview.Controls.Add(this.CmdSearchPersonDelete);
            this.PnlSearchPreview.Controls.Add(this.PnlSearchPreviewTrainee);
            this.PnlSearchPreview.Controls.Add(this.PnlSearchPreviewEmployee);
            this.PnlSearchPreview.Controls.Add(this.PnlSearchPreviewGeneral);
            this.PnlSearchPreview.Location = new System.Drawing.Point(617, 5);
            this.PnlSearchPreview.Name = "PnlSearchPreview";
            this.PnlSearchPreview.Size = new System.Drawing.Size(653, 595);
            this.PnlSearchPreview.TabIndex = 107;
            // 
            // CmdSearchCancel
            // 
            this.CmdSearchCancel.AutoSize = false;
            this.CmdSearchCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchCancel.Depth = 0;
            this.CmdSearchCancel.DrawShadows = true;
            this.CmdSearchCancel.HighEmphasis = true;
            this.CmdSearchCancel.Icon = null;
            this.CmdSearchCancel.Location = new System.Drawing.Point(562, 564);
            this.CmdSearchCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchCancel.Name = "CmdSearchCancel";
            this.CmdSearchCancel.Size = new System.Drawing.Size(88, 30);
            this.CmdSearchCancel.TabIndex = 135;
            this.CmdSearchCancel.Text = "Cancel";
            this.CmdSearchCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchCancel.UseAccentColor = false;
            this.CmdSearchCancel.UseVisualStyleBackColor = true;
            this.CmdSearchCancel.Click += new System.EventHandler(this.CmdSearchCancel_Click);
            // 
            // LblSearchPreviewNumberOutput
            // 
            this.LblSearchPreviewNumberOutput.AutoSize = true;
            this.LblSearchPreviewNumberOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchPreviewNumberOutput.Location = new System.Drawing.Point(51, 3);
            this.LblSearchPreviewNumberOutput.Name = "LblSearchPreviewNumberOutput";
            this.LblSearchPreviewNumberOutput.Size = new System.Drawing.Size(13, 17);
            this.LblSearchPreviewNumberOutput.TabIndex = 134;
            this.LblSearchPreviewNumberOutput.Text = "-";
            // 
            // LblSearchPreviewTypeOutput
            // 
            this.LblSearchPreviewTypeOutput.AutoSize = true;
            this.LblSearchPreviewTypeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchPreviewTypeOutput.Location = new System.Drawing.Point(196, 3);
            this.LblSearchPreviewTypeOutput.Name = "LblSearchPreviewTypeOutput";
            this.LblSearchPreviewTypeOutput.Size = new System.Drawing.Size(13, 17);
            this.LblSearchPreviewTypeOutput.TabIndex = 133;
            this.LblSearchPreviewTypeOutput.Text = "-";
            // 
            // CmdSearchNoteEdit
            // 
            this.CmdSearchNoteEdit.AutoSize = false;
            this.CmdSearchNoteEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchNoteEdit.Depth = 0;
            this.CmdSearchNoteEdit.DrawShadows = true;
            this.CmdSearchNoteEdit.Enabled = false;
            this.CmdSearchNoteEdit.HighEmphasis = true;
            this.CmdSearchNoteEdit.Icon = null;
            this.CmdSearchNoteEdit.Location = new System.Drawing.Point(428, 564);
            this.CmdSearchNoteEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchNoteEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchNoteEdit.Name = "CmdSearchNoteEdit";
            this.CmdSearchNoteEdit.Size = new System.Drawing.Size(58, 30);
            this.CmdSearchNoteEdit.TabIndex = 19;
            this.CmdSearchNoteEdit.Text = "Edit";
            this.CmdSearchNoteEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchNoteEdit.UseAccentColor = false;
            this.CmdSearchNoteEdit.UseVisualStyleBackColor = true;
            // 
            // CmdSearchNoteSave
            // 
            this.CmdSearchNoteSave.AutoSize = false;
            this.CmdSearchNoteSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchNoteSave.Depth = 0;
            this.CmdSearchNoteSave.DrawShadows = true;
            this.CmdSearchNoteSave.Enabled = false;
            this.CmdSearchNoteSave.HighEmphasis = true;
            this.CmdSearchNoteSave.Icon = null;
            this.CmdSearchNoteSave.Location = new System.Drawing.Point(365, 564);
            this.CmdSearchNoteSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchNoteSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchNoteSave.Name = "CmdSearchNoteSave";
            this.CmdSearchNoteSave.Size = new System.Drawing.Size(58, 30);
            this.CmdSearchNoteSave.TabIndex = 18;
            this.CmdSearchNoteSave.Text = "SAVE";
            this.CmdSearchNoteSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchNoteSave.UseAccentColor = false;
            this.CmdSearchNoteSave.UseVisualStyleBackColor = true;
            this.CmdSearchNoteSave.Click += new System.EventHandler(this.CmdSearchNoteSave_Click);
            // 
            // CmdSearchNoteClear
            // 
            this.CmdSearchNoteClear.AutoSize = false;
            this.CmdSearchNoteClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchNoteClear.Depth = 0;
            this.CmdSearchNoteClear.DrawShadows = true;
            this.CmdSearchNoteClear.Enabled = false;
            this.CmdSearchNoteClear.HighEmphasis = true;
            this.CmdSearchNoteClear.Icon = null;
            this.CmdSearchNoteClear.Location = new System.Drawing.Point(491, 564);
            this.CmdSearchNoteClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchNoteClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchNoteClear.Name = "CmdSearchNoteClear";
            this.CmdSearchNoteClear.Size = new System.Drawing.Size(66, 30);
            this.CmdSearchNoteClear.TabIndex = 20;
            this.CmdSearchNoteClear.Text = "CLEAR";
            this.CmdSearchNoteClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchNoteClear.UseAccentColor = false;
            this.CmdSearchNoteClear.UseVisualStyleBackColor = true;
            // 
            // TxtSearchNote
            // 
            this.TxtSearchNote.Enabled = false;
            this.TxtSearchNote.Location = new System.Drawing.Point(20, 378);
            this.TxtSearchNote.Multiline = true;
            this.TxtSearchNote.Name = "TxtSearchNote";
            this.TxtSearchNote.Size = new System.Drawing.Size(630, 184);
            this.TxtSearchNote.TabIndex = 17;
            // 
            // LblSearchPreviewStatus
            // 
            this.LblSearchPreviewStatus.AutoSize = true;
            this.LblSearchPreviewStatus.Location = new System.Drawing.Point(345, 3);
            this.LblSearchPreviewStatus.Name = "LblSearchPreviewStatus";
            this.LblSearchPreviewStatus.Size = new System.Drawing.Size(44, 14);
            this.LblSearchPreviewStatus.TabIndex = 132;
            this.LblSearchPreviewStatus.Text = "Status: ";
            // 
            // LblSearchPreviewStatusOutput
            // 
            this.LblSearchPreviewStatusOutput.AutoSize = true;
            this.LblSearchPreviewStatusOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchPreviewStatusOutput.Location = new System.Drawing.Point(400, 3);
            this.LblSearchPreviewStatusOutput.Name = "LblSearchPreviewStatusOutput";
            this.LblSearchPreviewStatusOutput.Size = new System.Drawing.Size(13, 17);
            this.LblSearchPreviewStatusOutput.TabIndex = 132;
            this.LblSearchPreviewStatusOutput.Text = "-";
            // 
            // LblSearchNotes
            // 
            this.LblSearchNotes.AutoSize = true;
            this.LblSearchNotes.Depth = 0;
            this.LblSearchNotes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSearchNotes.Location = new System.Drawing.Point(18, 356);
            this.LblSearchNotes.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchNotes.Name = "LblSearchNotes";
            this.LblSearchNotes.Size = new System.Drawing.Size(42, 19);
            this.LblSearchNotes.TabIndex = 129;
            this.LblSearchNotes.Text = "Notes";
            // 
            // LblSearchPreviewType
            // 
            this.LblSearchPreviewType.AutoSize = true;
            this.LblSearchPreviewType.Location = new System.Drawing.Point(152, 3);
            this.LblSearchPreviewType.Name = "LblSearchPreviewType";
            this.LblSearchPreviewType.Size = new System.Drawing.Size(33, 14);
            this.LblSearchPreviewType.TabIndex = 120;
            this.LblSearchPreviewType.Text = "Type:";
            // 
            // LblSearchPreviewNumber
            // 
            this.LblSearchPreviewNumber.AutoSize = true;
            this.LblSearchPreviewNumber.Location = new System.Drawing.Point(17, 3);
            this.LblSearchPreviewNumber.Name = "LblSearchPreviewNumber";
            this.LblSearchPreviewNumber.Size = new System.Drawing.Size(23, 14);
            this.LblSearchPreviewNumber.TabIndex = 119;
            this.LblSearchPreviewNumber.Text = "Nr.:";
            // 
            // CmdSearchPersonEdit
            // 
            this.CmdSearchPersonEdit.AutoSize = false;
            this.CmdSearchPersonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchPersonEdit.Depth = 0;
            this.CmdSearchPersonEdit.DrawShadows = true;
            this.CmdSearchPersonEdit.Enabled = false;
            this.CmdSearchPersonEdit.HighEmphasis = true;
            this.CmdSearchPersonEdit.Icon = null;
            this.CmdSearchPersonEdit.Location = new System.Drawing.Point(18, 322);
            this.CmdSearchPersonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchPersonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchPersonEdit.Name = "CmdSearchPersonEdit";
            this.CmdSearchPersonEdit.Size = new System.Drawing.Size(58, 30);
            this.CmdSearchPersonEdit.TabIndex = 15;
            this.CmdSearchPersonEdit.Text = "Edit";
            this.CmdSearchPersonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchPersonEdit.UseAccentColor = false;
            this.CmdSearchPersonEdit.UseVisualStyleBackColor = true;
            this.CmdSearchPersonEdit.Click += new System.EventHandler(this.CmdSearchPersonEdit_Click);
            // 
            // PnlSearchPreviewCustomer
            // 
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchPreviewCompanyContactOutput);
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchPreviewCompanyNameOutput);
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchPreviewCustomerTypeOutput);
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchHeadlineCustomer);
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchPreviewCompanyContact);
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchPreviewCustomerType);
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchPreviewCompanyName);
            this.PnlSearchPreviewCustomer.Location = new System.Drawing.Point(333, 17);
            this.PnlSearchPreviewCustomer.Name = "PnlSearchPreviewCustomer";
            this.PnlSearchPreviewCustomer.Size = new System.Drawing.Size(317, 89);
            this.PnlSearchPreviewCustomer.TabIndex = 124;
            this.PnlSearchPreviewCustomer.Visible = false;
            // 
            // LblSearchPreviewCompanyContactOutput
            // 
            this.LblSearchPreviewCompanyContactOutput.AutoSize = true;
            this.LblSearchPreviewCompanyContactOutput.Location = new System.Drawing.Point(167, 66);
            this.LblSearchPreviewCompanyContactOutput.Name = "LblSearchPreviewCompanyContactOutput";
            this.LblSearchPreviewCompanyContactOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewCompanyContactOutput.TabIndex = 126;
            this.LblSearchPreviewCompanyContactOutput.Text = "-";
            // 
            // LblSearchPreviewCompanyNameOutput
            // 
            this.LblSearchPreviewCompanyNameOutput.AutoSize = true;
            this.LblSearchPreviewCompanyNameOutput.Location = new System.Drawing.Point(167, 48);
            this.LblSearchPreviewCompanyNameOutput.Name = "LblSearchPreviewCompanyNameOutput";
            this.LblSearchPreviewCompanyNameOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewCompanyNameOutput.TabIndex = 125;
            this.LblSearchPreviewCompanyNameOutput.Text = "-";
            // 
            // LblSearchPreviewCustomerTypeOutput
            // 
            this.LblSearchPreviewCustomerTypeOutput.AutoSize = true;
            this.LblSearchPreviewCustomerTypeOutput.Location = new System.Drawing.Point(167, 30);
            this.LblSearchPreviewCustomerTypeOutput.Name = "LblSearchPreviewCustomerTypeOutput";
            this.LblSearchPreviewCustomerTypeOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewCustomerTypeOutput.TabIndex = 124;
            this.LblSearchPreviewCustomerTypeOutput.Text = "-";
            // 
            // LblSearchHeadlineCustomer
            // 
            this.LblSearchHeadlineCustomer.AutoSize = true;
            this.LblSearchHeadlineCustomer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchHeadlineCustomer.Location = new System.Drawing.Point(12, 9);
            this.LblSearchHeadlineCustomer.Name = "LblSearchHeadlineCustomer";
            this.LblSearchHeadlineCustomer.Size = new System.Drawing.Size(130, 14);
            this.LblSearchHeadlineCustomer.TabIndex = 1;
            this.LblSearchHeadlineCustomer.Text = "Customer information";
            // 
            // LblSearchPreviewCompanyContact
            // 
            this.LblSearchPreviewCompanyContact.AutoSize = true;
            this.LblSearchPreviewCompanyContact.Location = new System.Drawing.Point(12, 66);
            this.LblSearchPreviewCompanyContact.Name = "LblSearchPreviewCompanyContact";
            this.LblSearchPreviewCompanyContact.Size = new System.Drawing.Size(91, 14);
            this.LblSearchPreviewCompanyContact.TabIndex = 123;
            this.LblSearchPreviewCompanyContact.Text = "Company contact";
            // 
            // LblSearchPreviewCustomerType
            // 
            this.LblSearchPreviewCustomerType.AutoSize = true;
            this.LblSearchPreviewCustomerType.Location = new System.Drawing.Point(12, 30);
            this.LblSearchPreviewCustomerType.Name = "LblSearchPreviewCustomerType";
            this.LblSearchPreviewCustomerType.Size = new System.Drawing.Size(106, 14);
            this.LblSearchPreviewCustomerType.TabIndex = 121;
            this.LblSearchPreviewCustomerType.Text = "Customer type (A-E)";
            // 
            // LblSearchPreviewCompanyName
            // 
            this.LblSearchPreviewCompanyName.AutoSize = true;
            this.LblSearchPreviewCompanyName.Location = new System.Drawing.Point(12, 48);
            this.LblSearchPreviewCompanyName.Name = "LblSearchPreviewCompanyName";
            this.LblSearchPreviewCompanyName.Size = new System.Drawing.Size(81, 14);
            this.LblSearchPreviewCompanyName.TabIndex = 122;
            this.LblSearchPreviewCompanyName.Text = "Company name";
            // 
            // CmdSearchPersonDelete
            // 
            this.CmdSearchPersonDelete.AutoSize = false;
            this.CmdSearchPersonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchPersonDelete.Depth = 0;
            this.CmdSearchPersonDelete.DrawShadows = true;
            this.CmdSearchPersonDelete.Enabled = false;
            this.CmdSearchPersonDelete.HighEmphasis = true;
            this.CmdSearchPersonDelete.Icon = null;
            this.CmdSearchPersonDelete.Location = new System.Drawing.Point(82, 322);
            this.CmdSearchPersonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchPersonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchPersonDelete.Name = "CmdSearchPersonDelete";
            this.CmdSearchPersonDelete.Size = new System.Drawing.Size(65, 30);
            this.CmdSearchPersonDelete.TabIndex = 16;
            this.CmdSearchPersonDelete.Text = "DELETE";
            this.CmdSearchPersonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchPersonDelete.UseAccentColor = false;
            this.CmdSearchPersonDelete.UseVisualStyleBackColor = true;
            this.CmdSearchPersonDelete.Click += new System.EventHandler(this.CmdSearchPersonDelete_Click);
            // 
            // PnlSearchPreviewTrainee
            // 
            this.PnlSearchPreviewTrainee.Controls.Add(this.LblSearchPreviewYearsOfAppOutput);
            this.PnlSearchPreviewTrainee.Controls.Add(this.LblSearchPreviewCurrentAppYearOutput);
            this.PnlSearchPreviewTrainee.Controls.Add(this.label14);
            this.PnlSearchPreviewTrainee.Controls.Add(this.LblSearchPreviewCurrentAppYear);
            this.PnlSearchPreviewTrainee.Controls.Add(this.LblSearchPreviewYearsOfApp);
            this.PnlSearchPreviewTrainee.Location = new System.Drawing.Point(333, 188);
            this.PnlSearchPreviewTrainee.Name = "PnlSearchPreviewTrainee";
            this.PnlSearchPreviewTrainee.Size = new System.Drawing.Size(317, 69);
            this.PnlSearchPreviewTrainee.TabIndex = 125;
            this.PnlSearchPreviewTrainee.Visible = false;
            // 
            // LblSearchPreviewYearsOfAppOutput
            // 
            this.LblSearchPreviewYearsOfAppOutput.AutoSize = true;
            this.LblSearchPreviewYearsOfAppOutput.Location = new System.Drawing.Point(167, 39);
            this.LblSearchPreviewYearsOfAppOutput.Name = "LblSearchPreviewYearsOfAppOutput";
            this.LblSearchPreviewYearsOfAppOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewYearsOfAppOutput.TabIndex = 133;
            this.LblSearchPreviewYearsOfAppOutput.Text = "-";
            // 
            // LblSearchPreviewCurrentAppYearOutput
            // 
            this.LblSearchPreviewCurrentAppYearOutput.AutoSize = true;
            this.LblSearchPreviewCurrentAppYearOutput.Location = new System.Drawing.Point(167, 21);
            this.LblSearchPreviewCurrentAppYearOutput.Name = "LblSearchPreviewCurrentAppYearOutput";
            this.LblSearchPreviewCurrentAppYearOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewCurrentAppYearOutput.TabIndex = 132;
            this.LblSearchPreviewCurrentAppYearOutput.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 14);
            this.label14.TabIndex = 1;
            this.label14.Text = "Trainee information";
            // 
            // LblSearchPreviewCurrentAppYear
            // 
            this.LblSearchPreviewCurrentAppYear.AutoSize = true;
            this.LblSearchPreviewCurrentAppYear.Location = new System.Drawing.Point(12, 21);
            this.LblSearchPreviewCurrentAppYear.Name = "LblSearchPreviewCurrentAppYear";
            this.LblSearchPreviewCurrentAppYear.Size = new System.Drawing.Size(142, 14);
            this.LblSearchPreviewCurrentAppYear.TabIndex = 121;
            this.LblSearchPreviewCurrentAppYear.Text = "Current apprenticeship year";
            // 
            // LblSearchPreviewYearsOfApp
            // 
            this.LblSearchPreviewYearsOfApp.AutoSize = true;
            this.LblSearchPreviewYearsOfApp.Location = new System.Drawing.Point(12, 39);
            this.LblSearchPreviewYearsOfApp.Name = "LblSearchPreviewYearsOfApp";
            this.LblSearchPreviewYearsOfApp.Size = new System.Drawing.Size(123, 14);
            this.LblSearchPreviewYearsOfApp.TabIndex = 122;
            this.LblSearchPreviewYearsOfApp.Text = "Years of apprenticeship";
            // 
            // PnlSearchPreviewEmployee
            // 
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDateOfLeaving);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDateOfJoining);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewCadreLevel);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewEmployee);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewRole);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDegreeOfEmployment);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDepartement);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDateOfLeavingOutput);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDateOfJoiningOutput);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewCadreLevelOutput);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewRoleOutput);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDepartementOutput);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDegreeOfEmploymentOutput);
            this.PnlSearchPreviewEmployee.Location = new System.Drawing.Point(333, 17);
            this.PnlSearchPreviewEmployee.Name = "PnlSearchPreviewEmployee";
            this.PnlSearchPreviewEmployee.Size = new System.Drawing.Size(317, 170);
            this.PnlSearchPreviewEmployee.TabIndex = 125;
            this.PnlSearchPreviewEmployee.Visible = false;
            // 
            // LblSearchPreviewDateOfLeaving
            // 
            this.LblSearchPreviewDateOfLeaving.AutoSize = true;
            this.LblSearchPreviewDateOfLeaving.Location = new System.Drawing.Point(12, 138);
            this.LblSearchPreviewDateOfLeaving.Name = "LblSearchPreviewDateOfLeaving";
            this.LblSearchPreviewDateOfLeaving.Size = new System.Drawing.Size(79, 14);
            this.LblSearchPreviewDateOfLeaving.TabIndex = 126;
            this.LblSearchPreviewDateOfLeaving.Text = "Date of leaving";
            // 
            // LblSearchPreviewDateOfJoining
            // 
            this.LblSearchPreviewDateOfJoining.AutoSize = true;
            this.LblSearchPreviewDateOfJoining.Location = new System.Drawing.Point(12, 120);
            this.LblSearchPreviewDateOfJoining.Name = "LblSearchPreviewDateOfJoining";
            this.LblSearchPreviewDateOfJoining.Size = new System.Drawing.Size(75, 14);
            this.LblSearchPreviewDateOfJoining.TabIndex = 125;
            this.LblSearchPreviewDateOfJoining.Text = "Date of joining";
            // 
            // LblSearchPreviewCadreLevel
            // 
            this.LblSearchPreviewCadreLevel.AutoSize = true;
            this.LblSearchPreviewCadreLevel.Location = new System.Drawing.Point(12, 84);
            this.LblSearchPreviewCadreLevel.Name = "LblSearchPreviewCadreLevel";
            this.LblSearchPreviewCadreLevel.Size = new System.Drawing.Size(88, 14);
            this.LblSearchPreviewCadreLevel.TabIndex = 124;
            this.LblSearchPreviewCadreLevel.Text = "Cadre level (0-5)";
            // 
            // LblSearchPreviewEmployee
            // 
            this.LblSearchPreviewEmployee.AutoSize = true;
            this.LblSearchPreviewEmployee.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchPreviewEmployee.Location = new System.Drawing.Point(12, 9);
            this.LblSearchPreviewEmployee.Name = "LblSearchPreviewEmployee";
            this.LblSearchPreviewEmployee.Size = new System.Drawing.Size(128, 14);
            this.LblSearchPreviewEmployee.TabIndex = 1;
            this.LblSearchPreviewEmployee.Text = "Employee information";
            // 
            // LblSearchPreviewRole
            // 
            this.LblSearchPreviewRole.AutoSize = true;
            this.LblSearchPreviewRole.Location = new System.Drawing.Point(12, 66);
            this.LblSearchPreviewRole.Name = "LblSearchPreviewRole";
            this.LblSearchPreviewRole.Size = new System.Drawing.Size(75, 14);
            this.LblSearchPreviewRole.TabIndex = 123;
            this.LblSearchPreviewRole.Text = "Role (Job title)";
            // 
            // LblSearchPreviewDegreeOfEmployment
            // 
            this.LblSearchPreviewDegreeOfEmployment.AutoSize = true;
            this.LblSearchPreviewDegreeOfEmployment.Location = new System.Drawing.Point(12, 30);
            this.LblSearchPreviewDegreeOfEmployment.Name = "LblSearchPreviewDegreeOfEmployment";
            this.LblSearchPreviewDegreeOfEmployment.Size = new System.Drawing.Size(123, 14);
            this.LblSearchPreviewDegreeOfEmployment.TabIndex = 121;
            this.LblSearchPreviewDegreeOfEmployment.Text = "Deg. of employment (%)";
            // 
            // LblSearchPreviewDepartement
            // 
            this.LblSearchPreviewDepartement.AutoSize = true;
            this.LblSearchPreviewDepartement.Location = new System.Drawing.Point(12, 48);
            this.LblSearchPreviewDepartement.Name = "LblSearchPreviewDepartement";
            this.LblSearchPreviewDepartement.Size = new System.Drawing.Size(68, 14);
            this.LblSearchPreviewDepartement.TabIndex = 122;
            this.LblSearchPreviewDepartement.Text = "Departement";
            // 
            // LblSearchPreviewDateOfLeavingOutput
            // 
            this.LblSearchPreviewDateOfLeavingOutput.AutoSize = true;
            this.LblSearchPreviewDateOfLeavingOutput.Location = new System.Drawing.Point(167, 139);
            this.LblSearchPreviewDateOfLeavingOutput.Name = "LblSearchPreviewDateOfLeavingOutput";
            this.LblSearchPreviewDateOfLeavingOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewDateOfLeavingOutput.TabIndex = 132;
            this.LblSearchPreviewDateOfLeavingOutput.Text = "-";
            // 
            // LblSearchPreviewDateOfJoiningOutput
            // 
            this.LblSearchPreviewDateOfJoiningOutput.AutoSize = true;
            this.LblSearchPreviewDateOfJoiningOutput.Location = new System.Drawing.Point(167, 120);
            this.LblSearchPreviewDateOfJoiningOutput.Name = "LblSearchPreviewDateOfJoiningOutput";
            this.LblSearchPreviewDateOfJoiningOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewDateOfJoiningOutput.TabIndex = 131;
            this.LblSearchPreviewDateOfJoiningOutput.Text = "-";
            // 
            // LblSearchPreviewCadreLevelOutput
            // 
            this.LblSearchPreviewCadreLevelOutput.AutoSize = true;
            this.LblSearchPreviewCadreLevelOutput.Location = new System.Drawing.Point(167, 84);
            this.LblSearchPreviewCadreLevelOutput.Name = "LblSearchPreviewCadreLevelOutput";
            this.LblSearchPreviewCadreLevelOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewCadreLevelOutput.TabIndex = 130;
            this.LblSearchPreviewCadreLevelOutput.Text = "-";
            // 
            // LblSearchPreviewRoleOutput
            // 
            this.LblSearchPreviewRoleOutput.AutoSize = true;
            this.LblSearchPreviewRoleOutput.Location = new System.Drawing.Point(167, 66);
            this.LblSearchPreviewRoleOutput.Name = "LblSearchPreviewRoleOutput";
            this.LblSearchPreviewRoleOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewRoleOutput.TabIndex = 129;
            this.LblSearchPreviewRoleOutput.Text = "-";
            // 
            // LblSearchPreviewDepartementOutput
            // 
            this.LblSearchPreviewDepartementOutput.AutoSize = true;
            this.LblSearchPreviewDepartementOutput.Location = new System.Drawing.Point(167, 48);
            this.LblSearchPreviewDepartementOutput.Name = "LblSearchPreviewDepartementOutput";
            this.LblSearchPreviewDepartementOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewDepartementOutput.TabIndex = 128;
            this.LblSearchPreviewDepartementOutput.Text = "-";
            // 
            // LblSearchPreviewDegreeOfEmploymentOutput
            // 
            this.LblSearchPreviewDegreeOfEmploymentOutput.AutoSize = true;
            this.LblSearchPreviewDegreeOfEmploymentOutput.Location = new System.Drawing.Point(167, 30);
            this.LblSearchPreviewDegreeOfEmploymentOutput.Name = "LblSearchPreviewDegreeOfEmploymentOutput";
            this.LblSearchPreviewDegreeOfEmploymentOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewDegreeOfEmploymentOutput.TabIndex = 127;
            this.LblSearchPreviewDegreeOfEmploymentOutput.Text = "-";
            // 
            // PnlSearchPreviewGeneral
            // 
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewSalutationOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewSalutation);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewGenderOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewGender);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewBusinessAddressOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewBusinessPhoneOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewPrivatePhoneOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewEmailAddressOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewDateOfBirthOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewOasiNumberOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewNationalityOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewPlaceOfResidenceOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewPostalCodeOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewAddressOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewLastNameOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewFirstNameOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewTitleOutput);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchHeadlineGeneral);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewTitle);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewFirstName);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewLastName);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewAddress);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewBusinessAddress);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewPostalCode);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewEmailAddress);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewPlaceOfResidence);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewBusinessPhone);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewNationality);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewPrivatePhone);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewOasiNumber);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchPreviewDateOfBirth);
            this.PnlSearchPreviewGeneral.Location = new System.Drawing.Point(6, 17);
            this.PnlSearchPreviewGeneral.Name = "PnlSearchPreviewGeneral";
            this.PnlSearchPreviewGeneral.Size = new System.Drawing.Size(333, 302);
            this.PnlSearchPreviewGeneral.TabIndex = 126;
            // 
            // LblSearchPreviewSalutationOutput
            // 
            this.LblSearchPreviewSalutationOutput.AutoSize = true;
            this.LblSearchPreviewSalutationOutput.Location = new System.Drawing.Point(144, 66);
            this.LblSearchPreviewSalutationOutput.Name = "LblSearchPreviewSalutationOutput";
            this.LblSearchPreviewSalutationOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewSalutationOutput.TabIndex = 135;
            this.LblSearchPreviewSalutationOutput.Text = "-";
            // 
            // LblSearchPreviewSalutation
            // 
            this.LblSearchPreviewSalutation.AutoSize = true;
            this.LblSearchPreviewSalutation.Location = new System.Drawing.Point(11, 66);
            this.LblSearchPreviewSalutation.Name = "LblSearchPreviewSalutation";
            this.LblSearchPreviewSalutation.Size = new System.Drawing.Size(54, 14);
            this.LblSearchPreviewSalutation.TabIndex = 134;
            this.LblSearchPreviewSalutation.Text = "Salutation";
            // 
            // LblSearchPreviewGenderOutput
            // 
            this.LblSearchPreviewGenderOutput.AutoSize = true;
            this.LblSearchPreviewGenderOutput.Location = new System.Drawing.Point(144, 48);
            this.LblSearchPreviewGenderOutput.Name = "LblSearchPreviewGenderOutput";
            this.LblSearchPreviewGenderOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewGenderOutput.TabIndex = 133;
            this.LblSearchPreviewGenderOutput.Text = "-";
            // 
            // LblSearchPreviewGender
            // 
            this.LblSearchPreviewGender.AutoSize = true;
            this.LblSearchPreviewGender.Location = new System.Drawing.Point(11, 48);
            this.LblSearchPreviewGender.Name = "LblSearchPreviewGender";
            this.LblSearchPreviewGender.Size = new System.Drawing.Size(43, 14);
            this.LblSearchPreviewGender.TabIndex = 132;
            this.LblSearchPreviewGender.Text = "Gender";
            // 
            // LblSearchPreviewBusinessAddressOutput
            // 
            this.LblSearchPreviewBusinessAddressOutput.AutoSize = true;
            this.LblSearchPreviewBusinessAddressOutput.Location = new System.Drawing.Point(144, 283);
            this.LblSearchPreviewBusinessAddressOutput.Name = "LblSearchPreviewBusinessAddressOutput";
            this.LblSearchPreviewBusinessAddressOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewBusinessAddressOutput.TabIndex = 131;
            this.LblSearchPreviewBusinessAddressOutput.Text = "-";
            // 
            // LblSearchPreviewBusinessPhoneOutput
            // 
            this.LblSearchPreviewBusinessPhoneOutput.AutoSize = true;
            this.LblSearchPreviewBusinessPhoneOutput.Location = new System.Drawing.Point(144, 265);
            this.LblSearchPreviewBusinessPhoneOutput.Name = "LblSearchPreviewBusinessPhoneOutput";
            this.LblSearchPreviewBusinessPhoneOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewBusinessPhoneOutput.TabIndex = 130;
            this.LblSearchPreviewBusinessPhoneOutput.Text = "-";
            // 
            // LblSearchPreviewPrivatePhoneOutput
            // 
            this.LblSearchPreviewPrivatePhoneOutput.AutoSize = true;
            this.LblSearchPreviewPrivatePhoneOutput.Location = new System.Drawing.Point(144, 247);
            this.LblSearchPreviewPrivatePhoneOutput.Name = "LblSearchPreviewPrivatePhoneOutput";
            this.LblSearchPreviewPrivatePhoneOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewPrivatePhoneOutput.TabIndex = 129;
            this.LblSearchPreviewPrivatePhoneOutput.Text = "-";
            // 
            // LblSearchPreviewEmailAddressOutput
            // 
            this.LblSearchPreviewEmailAddressOutput.AutoSize = true;
            this.LblSearchPreviewEmailAddressOutput.Location = new System.Drawing.Point(144, 229);
            this.LblSearchPreviewEmailAddressOutput.Name = "LblSearchPreviewEmailAddressOutput";
            this.LblSearchPreviewEmailAddressOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewEmailAddressOutput.TabIndex = 128;
            this.LblSearchPreviewEmailAddressOutput.Text = "-";
            // 
            // LblSearchPreviewDateOfBirthOutput
            // 
            this.LblSearchPreviewDateOfBirthOutput.AutoSize = true;
            this.LblSearchPreviewDateOfBirthOutput.Location = new System.Drawing.Point(144, 211);
            this.LblSearchPreviewDateOfBirthOutput.Name = "LblSearchPreviewDateOfBirthOutput";
            this.LblSearchPreviewDateOfBirthOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewDateOfBirthOutput.TabIndex = 127;
            this.LblSearchPreviewDateOfBirthOutput.Text = "-";
            // 
            // LblSearchPreviewOasiNumberOutput
            // 
            this.LblSearchPreviewOasiNumberOutput.AutoSize = true;
            this.LblSearchPreviewOasiNumberOutput.Location = new System.Drawing.Point(144, 193);
            this.LblSearchPreviewOasiNumberOutput.Name = "LblSearchPreviewOasiNumberOutput";
            this.LblSearchPreviewOasiNumberOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewOasiNumberOutput.TabIndex = 126;
            this.LblSearchPreviewOasiNumberOutput.Text = "-";
            // 
            // LblSearchPreviewNationalityOutput
            // 
            this.LblSearchPreviewNationalityOutput.AutoSize = true;
            this.LblSearchPreviewNationalityOutput.Location = new System.Drawing.Point(144, 175);
            this.LblSearchPreviewNationalityOutput.Name = "LblSearchPreviewNationalityOutput";
            this.LblSearchPreviewNationalityOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewNationalityOutput.TabIndex = 125;
            this.LblSearchPreviewNationalityOutput.Text = "-";
            // 
            // LblSearchPreviewPlaceOfResidenceOutput
            // 
            this.LblSearchPreviewPlaceOfResidenceOutput.AutoSize = true;
            this.LblSearchPreviewPlaceOfResidenceOutput.Location = new System.Drawing.Point(144, 157);
            this.LblSearchPreviewPlaceOfResidenceOutput.Name = "LblSearchPreviewPlaceOfResidenceOutput";
            this.LblSearchPreviewPlaceOfResidenceOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewPlaceOfResidenceOutput.TabIndex = 124;
            this.LblSearchPreviewPlaceOfResidenceOutput.Text = "-";
            // 
            // LblSearchPreviewPostalCodeOutput
            // 
            this.LblSearchPreviewPostalCodeOutput.AutoSize = true;
            this.LblSearchPreviewPostalCodeOutput.Location = new System.Drawing.Point(144, 139);
            this.LblSearchPreviewPostalCodeOutput.Name = "LblSearchPreviewPostalCodeOutput";
            this.LblSearchPreviewPostalCodeOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewPostalCodeOutput.TabIndex = 123;
            this.LblSearchPreviewPostalCodeOutput.Text = "-";
            // 
            // LblSearchPreviewAddressOutput
            // 
            this.LblSearchPreviewAddressOutput.AutoSize = true;
            this.LblSearchPreviewAddressOutput.Location = new System.Drawing.Point(144, 121);
            this.LblSearchPreviewAddressOutput.Name = "LblSearchPreviewAddressOutput";
            this.LblSearchPreviewAddressOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewAddressOutput.TabIndex = 122;
            this.LblSearchPreviewAddressOutput.Text = "-";
            // 
            // LblSearchPreviewLastNameOutput
            // 
            this.LblSearchPreviewLastNameOutput.AutoSize = true;
            this.LblSearchPreviewLastNameOutput.Location = new System.Drawing.Point(144, 103);
            this.LblSearchPreviewLastNameOutput.Name = "LblSearchPreviewLastNameOutput";
            this.LblSearchPreviewLastNameOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewLastNameOutput.TabIndex = 121;
            this.LblSearchPreviewLastNameOutput.Text = "-";
            // 
            // LblSearchPreviewFirstNameOutput
            // 
            this.LblSearchPreviewFirstNameOutput.AutoSize = true;
            this.LblSearchPreviewFirstNameOutput.Location = new System.Drawing.Point(144, 85);
            this.LblSearchPreviewFirstNameOutput.Name = "LblSearchPreviewFirstNameOutput";
            this.LblSearchPreviewFirstNameOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewFirstNameOutput.TabIndex = 120;
            this.LblSearchPreviewFirstNameOutput.Text = "-";
            // 
            // LblSearchPreviewTitleOutput
            // 
            this.LblSearchPreviewTitleOutput.AutoSize = true;
            this.LblSearchPreviewTitleOutput.Location = new System.Drawing.Point(144, 30);
            this.LblSearchPreviewTitleOutput.Name = "LblSearchPreviewTitleOutput";
            this.LblSearchPreviewTitleOutput.Size = new System.Drawing.Size(11, 14);
            this.LblSearchPreviewTitleOutput.TabIndex = 119;
            this.LblSearchPreviewTitleOutput.Text = "-";
            // 
            // LblSearchHeadlineGeneral
            // 
            this.LblSearchHeadlineGeneral.AutoSize = true;
            this.LblSearchHeadlineGeneral.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchHeadlineGeneral.Location = new System.Drawing.Point(12, 9);
            this.LblSearchHeadlineGeneral.Name = "LblSearchHeadlineGeneral";
            this.LblSearchHeadlineGeneral.Size = new System.Drawing.Size(50, 14);
            this.LblSearchHeadlineGeneral.TabIndex = 0;
            this.LblSearchHeadlineGeneral.Text = "General";
            // 
            // LblSearchPreviewTitle
            // 
            this.LblSearchPreviewTitle.AutoSize = true;
            this.LblSearchPreviewTitle.Location = new System.Drawing.Point(11, 30);
            this.LblSearchPreviewTitle.Name = "LblSearchPreviewTitle";
            this.LblSearchPreviewTitle.Size = new System.Drawing.Size(26, 14);
            this.LblSearchPreviewTitle.TabIndex = 106;
            this.LblSearchPreviewTitle.Text = "Title";
            // 
            // LblSearchPreviewFirstName
            // 
            this.LblSearchPreviewFirstName.AutoSize = true;
            this.LblSearchPreviewFirstName.Location = new System.Drawing.Point(11, 85);
            this.LblSearchPreviewFirstName.Name = "LblSearchPreviewFirstName";
            this.LblSearchPreviewFirstName.Size = new System.Drawing.Size(57, 14);
            this.LblSearchPreviewFirstName.TabIndex = 107;
            this.LblSearchPreviewFirstName.Text = "First name";
            // 
            // LblSearchPreviewLastName
            // 
            this.LblSearchPreviewLastName.AutoSize = true;
            this.LblSearchPreviewLastName.Location = new System.Drawing.Point(11, 103);
            this.LblSearchPreviewLastName.Name = "LblSearchPreviewLastName";
            this.LblSearchPreviewLastName.Size = new System.Drawing.Size(57, 14);
            this.LblSearchPreviewLastName.TabIndex = 108;
            this.LblSearchPreviewLastName.Text = "Last name";
            // 
            // LblSearchPreviewAddress
            // 
            this.LblSearchPreviewAddress.AutoSize = true;
            this.LblSearchPreviewAddress.Location = new System.Drawing.Point(11, 121);
            this.LblSearchPreviewAddress.Name = "LblSearchPreviewAddress";
            this.LblSearchPreviewAddress.Size = new System.Drawing.Size(49, 14);
            this.LblSearchPreviewAddress.TabIndex = 109;
            this.LblSearchPreviewAddress.Text = "Address";
            // 
            // LblSearchPreviewBusinessAddress
            // 
            this.LblSearchPreviewBusinessAddress.AutoSize = true;
            this.LblSearchPreviewBusinessAddress.Location = new System.Drawing.Point(11, 283);
            this.LblSearchPreviewBusinessAddress.Name = "LblSearchPreviewBusinessAddress";
            this.LblSearchPreviewBusinessAddress.Size = new System.Drawing.Size(95, 14);
            this.LblSearchPreviewBusinessAddress.TabIndex = 118;
            this.LblSearchPreviewBusinessAddress.Text = "Business address";
            // 
            // LblSearchPreviewPostalCode
            // 
            this.LblSearchPreviewPostalCode.AutoSize = true;
            this.LblSearchPreviewPostalCode.Location = new System.Drawing.Point(11, 139);
            this.LblSearchPreviewPostalCode.Name = "LblSearchPreviewPostalCode";
            this.LblSearchPreviewPostalCode.Size = new System.Drawing.Size(63, 14);
            this.LblSearchPreviewPostalCode.TabIndex = 110;
            this.LblSearchPreviewPostalCode.Text = "Postal code";
            // 
            // LblSearchPreviewEmailAddress
            // 
            this.LblSearchPreviewEmailAddress.AutoSize = true;
            this.LblSearchPreviewEmailAddress.Location = new System.Drawing.Point(11, 229);
            this.LblSearchPreviewEmailAddress.Name = "LblSearchPreviewEmailAddress";
            this.LblSearchPreviewEmailAddress.Size = new System.Drawing.Size(74, 14);
            this.LblSearchPreviewEmailAddress.TabIndex = 117;
            this.LblSearchPreviewEmailAddress.Text = "Email address";
            // 
            // LblSearchPreviewPlaceOfResidence
            // 
            this.LblSearchPreviewPlaceOfResidence.AutoSize = true;
            this.LblSearchPreviewPlaceOfResidence.Location = new System.Drawing.Point(11, 157);
            this.LblSearchPreviewPlaceOfResidence.Name = "LblSearchPreviewPlaceOfResidence";
            this.LblSearchPreviewPlaceOfResidence.Size = new System.Drawing.Size(97, 14);
            this.LblSearchPreviewPlaceOfResidence.TabIndex = 111;
            this.LblSearchPreviewPlaceOfResidence.Text = "Place of residence";
            // 
            // LblSearchPreviewBusinessPhone
            // 
            this.LblSearchPreviewBusinessPhone.AutoSize = true;
            this.LblSearchPreviewBusinessPhone.Location = new System.Drawing.Point(11, 265);
            this.LblSearchPreviewBusinessPhone.Name = "LblSearchPreviewBusinessPhone";
            this.LblSearchPreviewBusinessPhone.Size = new System.Drawing.Size(85, 14);
            this.LblSearchPreviewBusinessPhone.TabIndex = 116;
            this.LblSearchPreviewBusinessPhone.Text = "Business phone";
            // 
            // LblSearchPreviewNationality
            // 
            this.LblSearchPreviewNationality.AutoSize = true;
            this.LblSearchPreviewNationality.Location = new System.Drawing.Point(11, 175);
            this.LblSearchPreviewNationality.Name = "LblSearchPreviewNationality";
            this.LblSearchPreviewNationality.Size = new System.Drawing.Size(56, 14);
            this.LblSearchPreviewNationality.TabIndex = 112;
            this.LblSearchPreviewNationality.Text = "Nationality";
            // 
            // LblSearchPreviewPrivatePhone
            // 
            this.LblSearchPreviewPrivatePhone.AutoSize = true;
            this.LblSearchPreviewPrivatePhone.Location = new System.Drawing.Point(11, 247);
            this.LblSearchPreviewPrivatePhone.Name = "LblSearchPreviewPrivatePhone";
            this.LblSearchPreviewPrivatePhone.Size = new System.Drawing.Size(73, 14);
            this.LblSearchPreviewPrivatePhone.TabIndex = 115;
            this.LblSearchPreviewPrivatePhone.Text = "Private phone";
            // 
            // LblSearchPreviewOasiNumber
            // 
            this.LblSearchPreviewOasiNumber.AutoSize = true;
            this.LblSearchPreviewOasiNumber.Location = new System.Drawing.Point(11, 193);
            this.LblSearchPreviewOasiNumber.Name = "LblSearchPreviewOasiNumber";
            this.LblSearchPreviewOasiNumber.Size = new System.Drawing.Size(71, 14);
            this.LblSearchPreviewOasiNumber.TabIndex = 113;
            this.LblSearchPreviewOasiNumber.Text = "OASI number";
            // 
            // LblSearchPreviewDateOfBirth
            // 
            this.LblSearchPreviewDateOfBirth.AutoSize = true;
            this.LblSearchPreviewDateOfBirth.Location = new System.Drawing.Point(11, 211);
            this.LblSearchPreviewDateOfBirth.Name = "LblSearchPreviewDateOfBirth";
            this.LblSearchPreviewDateOfBirth.Size = new System.Drawing.Size(66, 14);
            this.LblSearchPreviewDateOfBirth.TabIndex = 114;
            this.LblSearchPreviewDateOfBirth.Text = "Date of birth";
            // 
            // TabCreateEdit
            // 
            this.TabCreateEdit.Controls.Add(this.TabCreate);
            this.TabCreateEdit.Location = new System.Drawing.Point(4, 34);
            this.TabCreateEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabCreateEdit.Name = "TabCreateEdit";
            this.TabCreateEdit.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabCreateEdit.Size = new System.Drawing.Size(1267, 600);
            this.TabCreateEdit.TabIndex = 1;
            this.TabCreateEdit.Text = "Create";
            this.TabCreateEdit.UseVisualStyleBackColor = true;
            // 
            // TabCreate
            // 
            this.TabCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabCreate.Controls.Add(this.CmdCreateDeletePerson);
            this.TabCreate.Controls.Add(this.CmdCreateNoteClear);
            this.TabCreate.Controls.Add(this.TxtCreateNote);
            this.TabCreate.Controls.Add(this.LblCreateNotes);
            this.TabCreate.Controls.Add(this.CmdCreateCancel);
            this.TabCreate.Controls.Add(this.CmdCreatePersonSaveAndNew);
            this.TabCreate.Controls.Add(this.LblCreateTypeSelection);
            this.TabCreate.Controls.Add(this.PnlCreateInfoGeneral);
            this.TabCreate.Controls.Add(this.CmdCreateSavePerson);
            this.TabCreate.Controls.Add(this.PnlCreateInfoCustomer);
            this.TabCreate.Controls.Add(this.PnlCreateInfoEmployee);
            this.TabCreate.Depth = 0;
            this.TabCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabCreate.Location = new System.Drawing.Point(0, 0);
            this.TabCreate.Margin = new System.Windows.Forms.Padding(9);
            this.TabCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabCreate.Name = "TabCreate";
            this.TabCreate.Padding = new System.Windows.Forms.Padding(9);
            this.TabCreate.Size = new System.Drawing.Size(1281, 600);
            this.TabCreate.TabIndex = 59;
            // 
            // CmdCreateDeletePerson
            // 
            this.CmdCreateDeletePerson.AutoSize = false;
            this.CmdCreateDeletePerson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdCreateDeletePerson.Depth = 0;
            this.CmdCreateDeletePerson.DrawShadows = true;
            this.CmdCreateDeletePerson.HighEmphasis = true;
            this.CmdCreateDeletePerson.Icon = null;
            this.CmdCreateDeletePerson.Location = new System.Drawing.Point(820, 552);
            this.CmdCreateDeletePerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdCreateDeletePerson.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCreateDeletePerson.Name = "CmdCreateDeletePerson";
            this.CmdCreateDeletePerson.Size = new System.Drawing.Size(63, 44);
            this.CmdCreateDeletePerson.TabIndex = 103;
            this.CmdCreateDeletePerson.Text = "DELETE";
            this.CmdCreateDeletePerson.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdCreateDeletePerson.UseAccentColor = true;
            this.CmdCreateDeletePerson.UseVisualStyleBackColor = true;
            this.CmdCreateDeletePerson.Visible = false;
            // 
            // CmdCreateNoteClear
            // 
            this.CmdCreateNoteClear.AutoSize = false;
            this.CmdCreateNoteClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdCreateNoteClear.Depth = 0;
            this.CmdCreateNoteClear.DrawShadows = true;
            this.CmdCreateNoteClear.HighEmphasis = true;
            this.CmdCreateNoteClear.Icon = null;
            this.CmdCreateNoteClear.Location = new System.Drawing.Point(637, 546);
            this.CmdCreateNoteClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdCreateNoteClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCreateNoteClear.Name = "CmdCreateNoteClear";
            this.CmdCreateNoteClear.Size = new System.Drawing.Size(54, 30);
            this.CmdCreateNoteClear.TabIndex = 102;
            this.CmdCreateNoteClear.Text = "CLEAR";
            this.CmdCreateNoteClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdCreateNoteClear.UseAccentColor = false;
            this.CmdCreateNoteClear.UseVisualStyleBackColor = true;
            // 
            // TxtCreateNote
            // 
            this.TxtCreateNote.Location = new System.Drawing.Point(637, 382);
            this.TxtCreateNote.Multiline = true;
            this.TxtCreateNote.Name = "TxtCreateNote";
            this.TxtCreateNote.Size = new System.Drawing.Size(627, 157);
            this.TxtCreateNote.TabIndex = 101;
            // 
            // LblCreateNotes
            // 
            this.LblCreateNotes.AutoSize = true;
            this.LblCreateNotes.Depth = 0;
            this.LblCreateNotes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateNotes.Location = new System.Drawing.Point(639, 360);
            this.LblCreateNotes.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateNotes.Name = "LblCreateNotes";
            this.LblCreateNotes.Size = new System.Drawing.Size(42, 19);
            this.LblCreateNotes.TabIndex = 93;
            this.LblCreateNotes.Text = "Notes";
            // 
            // CmdCreateCancel
            // 
            this.CmdCreateCancel.AutoSize = false;
            this.CmdCreateCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdCreateCancel.Depth = 0;
            this.CmdCreateCancel.DrawShadows = true;
            this.CmdCreateCancel.HighEmphasis = true;
            this.CmdCreateCancel.Icon = null;
            this.CmdCreateCancel.Location = new System.Drawing.Point(1176, 551);
            this.CmdCreateCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdCreateCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCreateCancel.Name = "CmdCreateCancel";
            this.CmdCreateCancel.Size = new System.Drawing.Size(88, 44);
            this.CmdCreateCancel.TabIndex = 100;
            this.CmdCreateCancel.Text = "Cancel";
            this.CmdCreateCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdCreateCancel.UseAccentColor = false;
            this.CmdCreateCancel.UseVisualStyleBackColor = true;
            this.CmdCreateCancel.Click += new System.EventHandler(this.CmdCreateCancel_Click);
            // 
            // CmdCreatePersonSaveAndNew
            // 
            this.CmdCreatePersonSaveAndNew.AutoSize = false;
            this.CmdCreatePersonSaveAndNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdCreatePersonSaveAndNew.Depth = 0;
            this.CmdCreatePersonSaveAndNew.DrawShadows = true;
            this.CmdCreatePersonSaveAndNew.HighEmphasis = true;
            this.CmdCreatePersonSaveAndNew.Icon = null;
            this.CmdCreatePersonSaveAndNew.Location = new System.Drawing.Point(1055, 551);
            this.CmdCreatePersonSaveAndNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdCreatePersonSaveAndNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCreatePersonSaveAndNew.Name = "CmdCreatePersonSaveAndNew";
            this.CmdCreatePersonSaveAndNew.Size = new System.Drawing.Size(115, 44);
            this.CmdCreatePersonSaveAndNew.TabIndex = 99;
            this.CmdCreatePersonSaveAndNew.Text = "Save & New";
            this.CmdCreatePersonSaveAndNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdCreatePersonSaveAndNew.UseAccentColor = false;
            this.CmdCreatePersonSaveAndNew.UseVisualStyleBackColor = true;
            // 
            // LblCreateTypeSelection
            // 
            this.LblCreateTypeSelection.AutoSize = true;
            this.LblCreateTypeSelection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblCreateTypeSelection.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateTypeSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblCreateTypeSelection.Location = new System.Drawing.Point(850, 200);
            this.LblCreateTypeSelection.Name = "LblCreateTypeSelection";
            this.LblCreateTypeSelection.Size = new System.Drawing.Size(331, 37);
            this.LblCreateTypeSelection.TabIndex = 86;
            this.LblCreateTypeSelection.Text = "Please select a contact type.";
            // 
            // PnlCreateInfoGeneral
            // 
            this.PnlCreateInfoGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCreateInfoGeneral.Controls.Add(this.GrpCreateType);
            this.PnlCreateInfoGeneral.Controls.Add(this.RadCreateOther);
            this.PnlCreateInfoGeneral.Controls.Add(this.RadCreateFemale);
            this.PnlCreateInfoGeneral.Controls.Add(this.RadCreateMale);
            this.PnlCreateInfoGeneral.Controls.Add(this.SwtCreateActive);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateOasiNr);
            this.PnlCreateInfoGeneral.Controls.Add(this.DatCreateBirthday);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreatePlz);
            this.PnlCreateInfoGeneral.Controls.Add(this.CmbCreateSalutation);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreateAddress);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateSalutation);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreateOasiNr);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreatePlaceOfResidence);
            this.PnlCreateInfoGeneral.Controls.Add(this.CmbCreateNationality);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreateTitle);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreateBusinessAddress);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateFirstName);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateBusinessAddress);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreatePLZ);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateLastName);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateAddress);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreateFirstName);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateNationality);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreateLastName);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreatePlaceOfResidence);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateDateOfBirth);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateTitle);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateEmailAddress);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreateEmailAddress);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreateBusnissPhone);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreateBusnissPhone);
            this.PnlCreateInfoGeneral.Controls.Add(this.LblCreatePrivatePhone);
            this.PnlCreateInfoGeneral.Controls.Add(this.TxtCreatePrivatePhone);
            this.PnlCreateInfoGeneral.Controls.Add(this.GrpCreateGender);
            this.PnlCreateInfoGeneral.Location = new System.Drawing.Point(5, 5);
            this.PnlCreateInfoGeneral.Name = "PnlCreateInfoGeneral";
            this.PnlCreateInfoGeneral.Size = new System.Drawing.Size(616, 591);
            this.PnlCreateInfoGeneral.TabIndex = 82;
            // 
            // GrpCreateType
            // 
            this.GrpCreateType.Controls.Add(this.RadCreateEmployee);
            this.GrpCreateType.Controls.Add(this.RadCreateCustomer);
            this.GrpCreateType.Controls.Add(this.ChkCreateTrainee);
            this.GrpCreateType.Location = new System.Drawing.Point(430, 372);
            this.GrpCreateType.Name = "GrpCreateType";
            this.GrpCreateType.Size = new System.Drawing.Size(172, 182);
            this.GrpCreateType.TabIndex = 79;
            this.GrpCreateType.TabStop = false;
            this.GrpCreateType.Text = "Type*";
            // 
            // RadCreateEmployee
            // 
            this.RadCreateEmployee.AutoSize = true;
            this.RadCreateEmployee.Depth = 0;
            this.RadCreateEmployee.Location = new System.Drawing.Point(25, 88);
            this.RadCreateEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.RadCreateEmployee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadCreateEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadCreateEmployee.Name = "RadCreateEmployee";
            this.RadCreateEmployee.Ripple = true;
            this.RadCreateEmployee.Size = new System.Drawing.Size(104, 37);
            this.RadCreateEmployee.TabIndex = 20;
            this.RadCreateEmployee.TabStop = true;
            this.RadCreateEmployee.Text = "Employee";
            this.RadCreateEmployee.UseVisualStyleBackColor = true;
            this.RadCreateEmployee.CheckedChanged += new System.EventHandler(this.RadCreateEmployee_CheckedChanged);
            // 
            // RadCreateCustomer
            // 
            this.RadCreateCustomer.AutoSize = true;
            this.RadCreateCustomer.Depth = 0;
            this.RadCreateCustomer.Location = new System.Drawing.Point(25, 40);
            this.RadCreateCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.RadCreateCustomer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadCreateCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadCreateCustomer.Name = "RadCreateCustomer";
            this.RadCreateCustomer.Ripple = true;
            this.RadCreateCustomer.Size = new System.Drawing.Size(103, 37);
            this.RadCreateCustomer.TabIndex = 19;
            this.RadCreateCustomer.TabStop = true;
            this.RadCreateCustomer.Text = "Customer";
            this.RadCreateCustomer.UseVisualStyleBackColor = true;
            this.RadCreateCustomer.CheckedChanged += new System.EventHandler(this.RadCreateCustomer_CheckedChanged);
            // 
            // ChkCreateTrainee
            // 
            this.ChkCreateTrainee.AutoSize = true;
            this.ChkCreateTrainee.Depth = 0;
            this.ChkCreateTrainee.Location = new System.Drawing.Point(53, 126);
            this.ChkCreateTrainee.Margin = new System.Windows.Forms.Padding(0);
            this.ChkCreateTrainee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkCreateTrainee.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkCreateTrainee.Name = "ChkCreateTrainee";
            this.ChkCreateTrainee.Ripple = true;
            this.ChkCreateTrainee.Size = new System.Drawing.Size(88, 37);
            this.ChkCreateTrainee.TabIndex = 21;
            this.ChkCreateTrainee.Text = "Trainee";
            this.ChkCreateTrainee.UseVisualStyleBackColor = true;
            this.ChkCreateTrainee.CheckedChanged += new System.EventHandler(this.ChkCreateTrainee_CheckedChanged);
            // 
            // RadCreateOther
            // 
            this.RadCreateOther.AutoSize = true;
            this.RadCreateOther.Depth = 0;
            this.RadCreateOther.Location = new System.Drawing.Point(309, 22);
            this.RadCreateOther.Margin = new System.Windows.Forms.Padding(0);
            this.RadCreateOther.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadCreateOther.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadCreateOther.Name = "RadCreateOther";
            this.RadCreateOther.Ripple = true;
            this.RadCreateOther.Size = new System.Drawing.Size(73, 37);
            this.RadCreateOther.TabIndex = 4;
            this.RadCreateOther.TabStop = true;
            this.RadCreateOther.Text = "Other";
            this.RadCreateOther.UseVisualStyleBackColor = true;
            // 
            // RadCreateFemale
            // 
            this.RadCreateFemale.AutoSize = true;
            this.RadCreateFemale.Depth = 0;
            this.RadCreateFemale.Location = new System.Drawing.Point(145, 22);
            this.RadCreateFemale.Margin = new System.Windows.Forms.Padding(0);
            this.RadCreateFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadCreateFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadCreateFemale.Name = "RadCreateFemale";
            this.RadCreateFemale.Ripple = true;
            this.RadCreateFemale.Size = new System.Drawing.Size(87, 37);
            this.RadCreateFemale.TabIndex = 2;
            this.RadCreateFemale.TabStop = true;
            this.RadCreateFemale.Text = "Female";
            this.RadCreateFemale.UseVisualStyleBackColor = true;
            // 
            // RadCreateMale
            // 
            this.RadCreateMale.AutoSize = true;
            this.RadCreateMale.Depth = 0;
            this.RadCreateMale.Location = new System.Drawing.Point(236, 22);
            this.RadCreateMale.Margin = new System.Windows.Forms.Padding(0);
            this.RadCreateMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadCreateMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadCreateMale.Name = "RadCreateMale";
            this.RadCreateMale.Ripple = true;
            this.RadCreateMale.Size = new System.Drawing.Size(70, 37);
            this.RadCreateMale.TabIndex = 3;
            this.RadCreateMale.TabStop = true;
            this.RadCreateMale.Text = "Male";
            this.RadCreateMale.UseVisualStyleBackColor = true;
            // 
            // SwtCreateActive
            // 
            this.SwtCreateActive.AutoSize = true;
            this.SwtCreateActive.Checked = true;
            this.SwtCreateActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SwtCreateActive.Depth = 0;
            this.SwtCreateActive.Location = new System.Drawing.Point(11, 23);
            this.SwtCreateActive.Margin = new System.Windows.Forms.Padding(0);
            this.SwtCreateActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwtCreateActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwtCreateActive.Name = "SwtCreateActive";
            this.SwtCreateActive.Ripple = true;
            this.SwtCreateActive.Size = new System.Drawing.Size(101, 37);
            this.SwtCreateActive.TabIndex = 1;
            this.SwtCreateActive.Text = "Active";
            this.SwtCreateActive.UseVisualStyleBackColor = true;
            // 
            // LblCreateOasiNr
            // 
            this.LblCreateOasiNr.AutoSize = true;
            this.LblCreateOasiNr.Depth = 0;
            this.LblCreateOasiNr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateOasiNr.Location = new System.Drawing.Point(250, 273);
            this.LblCreateOasiNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateOasiNr.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateOasiNr.Name = "LblCreateOasiNr";
            this.LblCreateOasiNr.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateOasiNr.Size = new System.Drawing.Size(94, 19);
            this.LblCreateOasiNr.TabIndex = 16;
            this.LblCreateOasiNr.Text = "OASI number";
            // 
            // DatCreateBirthday
            // 
            this.DatCreateBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatCreateBirthday.CustomFormat = "HTML Format";
            this.DatCreateBirthday.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatCreateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatCreateBirthday.Location = new System.Drawing.Point(480, 300);
            this.DatCreateBirthday.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DatCreateBirthday.Name = "DatCreateBirthday";
            this.DatCreateBirthday.Size = new System.Drawing.Size(114, 29);
            this.DatCreateBirthday.TabIndex = 14;
            this.DatCreateBirthday.Value = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            // 
            // TxtCreatePlz
            // 
            this.TxtCreatePlz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreatePlz.Depth = 0;
            this.TxtCreatePlz.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreatePlz.Location = new System.Drawing.Point(276, 207);
            this.TxtCreatePlz.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreatePlz.MaxLength = 50;
            this.TxtCreatePlz.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreatePlz.Multiline = false;
            this.TxtCreatePlz.Name = "TxtCreatePlz";
            this.TxtCreatePlz.Size = new System.Drawing.Size(96, 50);
            this.TxtCreatePlz.TabIndex = 10;
            this.TxtCreatePlz.Text = "";
            // 
            // CmbCreateSalutation
            // 
            this.CmbCreateSalutation.AutoResize = false;
            this.CmbCreateSalutation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbCreateSalutation.Depth = 0;
            this.CmbCreateSalutation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbCreateSalutation.DropDownHeight = 174;
            this.CmbCreateSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCreateSalutation.DropDownWidth = 121;
            this.CmbCreateSalutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbCreateSalutation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbCreateSalutation.FormattingEnabled = true;
            this.CmbCreateSalutation.IntegralHeight = false;
            this.CmbCreateSalutation.ItemHeight = 43;
            this.CmbCreateSalutation.Items.AddRange(new object[] {
            "-",
            "Ms",
            "Mr",
            "Mx"});
            this.CmbCreateSalutation.Location = new System.Drawing.Point(526, 20);
            this.CmbCreateSalutation.MaxDropDownItems = 4;
            this.CmbCreateSalutation.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbCreateSalutation.Name = "CmbCreateSalutation";
            this.CmbCreateSalutation.Size = new System.Drawing.Size(76, 49);
            this.CmbCreateSalutation.StartIndex = 0;
            this.CmbCreateSalutation.TabIndex = 5;
            // 
            // TxtCreateAddress
            // 
            this.TxtCreateAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateAddress.Depth = 0;
            this.TxtCreateAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateAddress.Location = new System.Drawing.Point(17, 207);
            this.TxtCreateAddress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateAddress.MaxLength = 50;
            this.TxtCreateAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateAddress.Multiline = false;
            this.TxtCreateAddress.Name = "TxtCreateAddress";
            this.TxtCreateAddress.Size = new System.Drawing.Size(238, 50);
            this.TxtCreateAddress.TabIndex = 9;
            this.TxtCreateAddress.Text = "";
            // 
            // LblCreateSalutation
            // 
            this.LblCreateSalutation.AutoSize = true;
            this.LblCreateSalutation.Depth = 0;
            this.LblCreateSalutation.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateSalutation.Location = new System.Drawing.Point(427, 32);
            this.LblCreateSalutation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateSalutation.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateSalutation.Name = "LblCreateSalutation";
            this.LblCreateSalutation.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateSalutation.Size = new System.Drawing.Size(74, 19);
            this.LblCreateSalutation.TabIndex = 42;
            this.LblCreateSalutation.Text = "Salutation";
            // 
            // TxtCreateOasiNr
            // 
            this.TxtCreateOasiNr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateOasiNr.Depth = 0;
            this.TxtCreateOasiNr.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateOasiNr.Location = new System.Drawing.Point(249, 299);
            this.TxtCreateOasiNr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateOasiNr.MaxLength = 50;
            this.TxtCreateOasiNr.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateOasiNr.Multiline = false;
            this.TxtCreateOasiNr.Name = "TxtCreateOasiNr";
            this.TxtCreateOasiNr.Size = new System.Drawing.Size(212, 50);
            this.TxtCreateOasiNr.TabIndex = 13;
            this.TxtCreateOasiNr.Text = "";
            // 
            // TxtCreatePlaceOfResidence
            // 
            this.TxtCreatePlaceOfResidence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreatePlaceOfResidence.Depth = 0;
            this.TxtCreatePlaceOfResidence.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreatePlaceOfResidence.Location = new System.Drawing.Point(393, 207);
            this.TxtCreatePlaceOfResidence.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreatePlaceOfResidence.MaxLength = 50;
            this.TxtCreatePlaceOfResidence.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreatePlaceOfResidence.Multiline = false;
            this.TxtCreatePlaceOfResidence.Name = "TxtCreatePlaceOfResidence";
            this.TxtCreatePlaceOfResidence.Size = new System.Drawing.Size(210, 50);
            this.TxtCreatePlaceOfResidence.TabIndex = 11;
            this.TxtCreatePlaceOfResidence.Text = "";
            // 
            // CmbCreateNationality
            // 
            this.CmbCreateNationality.AutoResize = false;
            this.CmbCreateNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbCreateNationality.Depth = 0;
            this.CmbCreateNationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbCreateNationality.DropDownHeight = 174;
            this.CmbCreateNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCreateNationality.DropDownWidth = 121;
            this.CmbCreateNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbCreateNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbCreateNationality.FormattingEnabled = true;
            this.CmbCreateNationality.IntegralHeight = false;
            this.CmbCreateNationality.ItemHeight = 43;
            this.CmbCreateNationality.Location = new System.Drawing.Point(16, 300);
            this.CmbCreateNationality.MaxDropDownItems = 4;
            this.CmbCreateNationality.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbCreateNationality.Name = "CmbCreateNationality";
            this.CmbCreateNationality.Size = new System.Drawing.Size(217, 49);
            this.CmbCreateNationality.StartIndex = 0;
            this.CmbCreateNationality.TabIndex = 12;
            // 
            // TxtCreateTitle
            // 
            this.TxtCreateTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateTitle.Depth = 0;
            this.TxtCreateTitle.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateTitle.Location = new System.Drawing.Point(18, 117);
            this.TxtCreateTitle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateTitle.MaxLength = 50;
            this.TxtCreateTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateTitle.Multiline = false;
            this.TxtCreateTitle.Name = "TxtCreateTitle";
            this.TxtCreateTitle.Size = new System.Drawing.Size(116, 50);
            this.TxtCreateTitle.TabIndex = 6;
            this.TxtCreateTitle.Text = "";
            // 
            // TxtCreateBusinessAddress
            // 
            this.TxtCreateBusinessAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateBusinessAddress.Depth = 0;
            this.TxtCreateBusinessAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateBusinessAddress.Location = new System.Drawing.Point(222, 504);
            this.TxtCreateBusinessAddress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateBusinessAddress.MaxLength = 50;
            this.TxtCreateBusinessAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateBusinessAddress.Multiline = false;
            this.TxtCreateBusinessAddress.Name = "TxtCreateBusinessAddress";
            this.TxtCreateBusinessAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TxtCreateBusinessAddress.Size = new System.Drawing.Size(175, 50);
            this.TxtCreateBusinessAddress.TabIndex = 18;
            this.TxtCreateBusinessAddress.Text = "";
            // 
            // LblCreateFirstName
            // 
            this.LblCreateFirstName.AutoSize = true;
            this.LblCreateFirstName.Depth = 0;
            this.LblCreateFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateFirstName.Location = new System.Drawing.Point(160, 91);
            this.LblCreateFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateFirstName.Name = "LblCreateFirstName";
            this.LblCreateFirstName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateFirstName.Size = new System.Drawing.Size(83, 19);
            this.LblCreateFirstName.TabIndex = 43;
            this.LblCreateFirstName.Text = "First name*";
            // 
            // LblCreateBusinessAddress
            // 
            this.LblCreateBusinessAddress.AutoSize = true;
            this.LblCreateBusinessAddress.Depth = 0;
            this.LblCreateBusinessAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateBusinessAddress.Location = new System.Drawing.Point(224, 477);
            this.LblCreateBusinessAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateBusinessAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateBusinessAddress.Name = "LblCreateBusinessAddress";
            this.LblCreateBusinessAddress.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateBusinessAddress.Size = new System.Drawing.Size(125, 19);
            this.LblCreateBusinessAddress.TabIndex = 31;
            this.LblCreateBusinessAddress.Text = "Business address";
            // 
            // LblCreatePLZ
            // 
            this.LblCreatePLZ.AutoSize = true;
            this.LblCreatePLZ.Depth = 0;
            this.LblCreatePLZ.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreatePLZ.Location = new System.Drawing.Point(277, 181);
            this.LblCreatePLZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePLZ.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreatePLZ.Name = "LblCreatePLZ";
            this.LblCreatePLZ.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreatePLZ.Size = new System.Drawing.Size(91, 19);
            this.LblCreatePLZ.TabIndex = 68;
            this.LblCreatePLZ.Text = "Postal code*";
            // 
            // LblCreateLastName
            // 
            this.LblCreateLastName.AutoSize = true;
            this.LblCreateLastName.Depth = 0;
            this.LblCreateLastName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateLastName.Location = new System.Drawing.Point(393, 91);
            this.LblCreateLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateLastName.Name = "LblCreateLastName";
            this.LblCreateLastName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateLastName.Size = new System.Drawing.Size(83, 19);
            this.LblCreateLastName.TabIndex = 44;
            this.LblCreateLastName.Text = "Last name*";
            // 
            // LblCreateAddress
            // 
            this.LblCreateAddress.AutoSize = true;
            this.LblCreateAddress.Depth = 0;
            this.LblCreateAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateAddress.Location = new System.Drawing.Point(17, 183);
            this.LblCreateAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateAddress.Name = "LblCreateAddress";
            this.LblCreateAddress.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateAddress.Size = new System.Drawing.Size(65, 19);
            this.LblCreateAddress.TabIndex = 67;
            this.LblCreateAddress.Text = "Address*";
            // 
            // TxtCreateFirstName
            // 
            this.TxtCreateFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateFirstName.Depth = 0;
            this.TxtCreateFirstName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateFirstName.Location = new System.Drawing.Point(159, 117);
            this.TxtCreateFirstName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateFirstName.MaxLength = 50;
            this.TxtCreateFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateFirstName.Multiline = false;
            this.TxtCreateFirstName.Name = "TxtCreateFirstName";
            this.TxtCreateFirstName.Size = new System.Drawing.Size(210, 50);
            this.TxtCreateFirstName.TabIndex = 7;
            this.TxtCreateFirstName.Text = "";
            // 
            // LblCreateNationality
            // 
            this.LblCreateNationality.AutoSize = true;
            this.LblCreateNationality.Depth = 0;
            this.LblCreateNationality.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateNationality.Location = new System.Drawing.Point(15, 274);
            this.LblCreateNationality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateNationality.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateNationality.Name = "LblCreateNationality";
            this.LblCreateNationality.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateNationality.Size = new System.Drawing.Size(78, 19);
            this.LblCreateNationality.TabIndex = 66;
            this.LblCreateNationality.Text = "Nationality";
            // 
            // TxtCreateLastName
            // 
            this.TxtCreateLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateLastName.Depth = 0;
            this.TxtCreateLastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateLastName.Location = new System.Drawing.Point(392, 117);
            this.TxtCreateLastName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateLastName.MaxLength = 50;
            this.TxtCreateLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateLastName.Multiline = false;
            this.TxtCreateLastName.Name = "TxtCreateLastName";
            this.TxtCreateLastName.Size = new System.Drawing.Size(210, 50);
            this.TxtCreateLastName.TabIndex = 8;
            this.TxtCreateLastName.Text = "";
            // 
            // LblCreatePlaceOfResidence
            // 
            this.LblCreatePlaceOfResidence.AutoSize = true;
            this.LblCreatePlaceOfResidence.Depth = 0;
            this.LblCreatePlaceOfResidence.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreatePlaceOfResidence.Location = new System.Drawing.Point(392, 181);
            this.LblCreatePlaceOfResidence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePlaceOfResidence.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreatePlaceOfResidence.Name = "LblCreatePlaceOfResidence";
            this.LblCreatePlaceOfResidence.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreatePlaceOfResidence.Size = new System.Drawing.Size(137, 19);
            this.LblCreatePlaceOfResidence.TabIndex = 65;
            this.LblCreatePlaceOfResidence.Text = "Place of residence*";
            // 
            // LblCreateDateOfBirth
            // 
            this.LblCreateDateOfBirth.AutoSize = true;
            this.LblCreateDateOfBirth.Depth = 0;
            this.LblCreateDateOfBirth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateDateOfBirth.Location = new System.Drawing.Point(479, 274);
            this.LblCreateDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateDateOfBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateDateOfBirth.Name = "LblCreateDateOfBirth";
            this.LblCreateDateOfBirth.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateDateOfBirth.Size = new System.Drawing.Size(96, 19);
            this.LblCreateDateOfBirth.TabIndex = 62;
            this.LblCreateDateOfBirth.Text = "Date of birth*";
            // 
            // LblCreateTitle
            // 
            this.LblCreateTitle.AutoSize = true;
            this.LblCreateTitle.Depth = 0;
            this.LblCreateTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateTitle.Location = new System.Drawing.Point(17, 90);
            this.LblCreateTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateTitle.Name = "LblCreateTitle";
            this.LblCreateTitle.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateTitle.Size = new System.Drawing.Size(32, 19);
            this.LblCreateTitle.TabIndex = 63;
            this.LblCreateTitle.Text = "Title";
            // 
            // LblCreateEmailAddress
            // 
            this.LblCreateEmailAddress.AutoSize = true;
            this.LblCreateEmailAddress.Depth = 0;
            this.LblCreateEmailAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateEmailAddress.Location = new System.Drawing.Point(223, 378);
            this.LblCreateEmailAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateEmailAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateEmailAddress.Name = "LblCreateEmailAddress";
            this.LblCreateEmailAddress.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateEmailAddress.Size = new System.Drawing.Size(108, 19);
            this.LblCreateEmailAddress.TabIndex = 75;
            this.LblCreateEmailAddress.Text = "Email address*";
            // 
            // TxtCreateEmailAddress
            // 
            this.TxtCreateEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateEmailAddress.Depth = 0;
            this.TxtCreateEmailAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateEmailAddress.Location = new System.Drawing.Point(223, 407);
            this.TxtCreateEmailAddress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateEmailAddress.MaxLength = 50;
            this.TxtCreateEmailAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateEmailAddress.Multiline = false;
            this.TxtCreateEmailAddress.Name = "TxtCreateEmailAddress";
            this.TxtCreateEmailAddress.Size = new System.Drawing.Size(175, 50);
            this.TxtCreateEmailAddress.TabIndex = 16;
            this.TxtCreateEmailAddress.Text = "";
            // 
            // LblCreateBusnissPhone
            // 
            this.LblCreateBusnissPhone.AutoSize = true;
            this.LblCreateBusnissPhone.Depth = 0;
            this.LblCreateBusnissPhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateBusnissPhone.Location = new System.Drawing.Point(21, 475);
            this.LblCreateBusnissPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateBusnissPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateBusnissPhone.Name = "LblCreateBusnissPhone";
            this.LblCreateBusnissPhone.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateBusnissPhone.Size = new System.Drawing.Size(113, 19);
            this.LblCreateBusnissPhone.TabIndex = 47;
            this.LblCreateBusnissPhone.Text = "Business phone";
            // 
            // TxtCreateBusnissPhone
            // 
            this.TxtCreateBusnissPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateBusnissPhone.Depth = 0;
            this.TxtCreateBusnissPhone.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateBusnissPhone.Location = new System.Drawing.Point(20, 504);
            this.TxtCreateBusnissPhone.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateBusnissPhone.MaxLength = 50;
            this.TxtCreateBusnissPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateBusnissPhone.Multiline = false;
            this.TxtCreateBusnissPhone.Name = "TxtCreateBusnissPhone";
            this.TxtCreateBusnissPhone.Size = new System.Drawing.Size(175, 50);
            this.TxtCreateBusnissPhone.TabIndex = 17;
            this.TxtCreateBusnissPhone.Text = "";
            // 
            // LblCreatePrivatePhone
            // 
            this.LblCreatePrivatePhone.AutoSize = true;
            this.LblCreatePrivatePhone.Depth = 0;
            this.LblCreatePrivatePhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreatePrivatePhone.Location = new System.Drawing.Point(17, 378);
            this.LblCreatePrivatePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePrivatePhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreatePrivatePhone.Name = "LblCreatePrivatePhone";
            this.LblCreatePrivatePhone.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreatePrivatePhone.Size = new System.Drawing.Size(98, 19);
            this.LblCreatePrivatePhone.TabIndex = 48;
            this.LblCreatePrivatePhone.Text = "Private phone";
            // 
            // TxtCreatePrivatePhone
            // 
            this.TxtCreatePrivatePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreatePrivatePhone.Depth = 0;
            this.TxtCreatePrivatePhone.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreatePrivatePhone.Location = new System.Drawing.Point(18, 407);
            this.TxtCreatePrivatePhone.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreatePrivatePhone.MaxLength = 50;
            this.TxtCreatePrivatePhone.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreatePrivatePhone.Multiline = false;
            this.TxtCreatePrivatePhone.Name = "TxtCreatePrivatePhone";
            this.TxtCreatePrivatePhone.Size = new System.Drawing.Size(175, 50);
            this.TxtCreatePrivatePhone.TabIndex = 15;
            this.TxtCreatePrivatePhone.Text = "";
            // 
            // CmdCreateSavePerson
            // 
            this.CmdCreateSavePerson.AutoSize = false;
            this.CmdCreateSavePerson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdCreateSavePerson.Depth = 0;
            this.CmdCreateSavePerson.DrawShadows = true;
            this.CmdCreateSavePerson.HighEmphasis = true;
            this.CmdCreateSavePerson.Icon = null;
            this.CmdCreateSavePerson.Location = new System.Drawing.Point(903, 551);
            this.CmdCreateSavePerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdCreateSavePerson.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCreateSavePerson.Name = "CmdCreateSavePerson";
            this.CmdCreateSavePerson.Size = new System.Drawing.Size(146, 44);
            this.CmdCreateSavePerson.TabIndex = 98;
            this.CmdCreateSavePerson.Text = "Save";
            this.CmdCreateSavePerson.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdCreateSavePerson.UseAccentColor = false;
            this.CmdCreateSavePerson.UseVisualStyleBackColor = true;
            this.CmdCreateSavePerson.Click += new System.EventHandler(this.CmdCreatePerson_Click);
            // 
            // PnlCreateInfoCustomer
            // 
            this.PnlCreateInfoCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCreateInfoCustomer.Controls.Add(this.TxtCreateCustomerNumber);
            this.PnlCreateInfoCustomer.Controls.Add(this.LblCreateCustomerNumber);
            this.PnlCreateInfoCustomer.Controls.Add(this.LblCreateCompanyName);
            this.PnlCreateInfoCustomer.Controls.Add(this.CmbCreateCustomerType);
            this.PnlCreateInfoCustomer.Controls.Add(this.TxtCreateCompanyName);
            this.PnlCreateInfoCustomer.Controls.Add(this.LblCreateCustomerType);
            this.PnlCreateInfoCustomer.Controls.Add(this.LblCreateCompanyContact);
            this.PnlCreateInfoCustomer.Controls.Add(this.TxtCreateCompanyContact);
            this.PnlCreateInfoCustomer.Location = new System.Drawing.Point(637, 5);
            this.PnlCreateInfoCustomer.Name = "PnlCreateInfoCustomer";
            this.PnlCreateInfoCustomer.Size = new System.Drawing.Size(630, 178);
            this.PnlCreateInfoCustomer.TabIndex = 85;
            // 
            // TxtCreateCustomerNumber
            // 
            this.TxtCreateCustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateCustomerNumber.Depth = 0;
            this.TxtCreateCustomerNumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateCustomerNumber.Location = new System.Drawing.Point(148, 13);
            this.TxtCreateCustomerNumber.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateCustomerNumber.MaxLength = 50;
            this.TxtCreateCustomerNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateCustomerNumber.Multiline = false;
            this.TxtCreateCustomerNumber.Name = "TxtCreateCustomerNumber";
            this.TxtCreateCustomerNumber.Size = new System.Drawing.Size(123, 50);
            this.TxtCreateCustomerNumber.TabIndex = 35;
            this.TxtCreateCustomerNumber.Text = "";
            // 
            // LblCreateCustomerNumber
            // 
            this.LblCreateCustomerNumber.AutoSize = true;
            this.LblCreateCustomerNumber.Depth = 0;
            this.LblCreateCustomerNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateCustomerNumber.Location = new System.Drawing.Point(10, 26);
            this.LblCreateCustomerNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateCustomerNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateCustomerNumber.Name = "LblCreateCustomerNumber";
            this.LblCreateCustomerNumber.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateCustomerNumber.Size = new System.Drawing.Size(127, 19);
            this.LblCreateCustomerNumber.TabIndex = 34;
            this.LblCreateCustomerNumber.Text = "Customer number";
            // 
            // LblCreateCompanyName
            // 
            this.LblCreateCompanyName.AutoSize = true;
            this.LblCreateCompanyName.Depth = 0;
            this.LblCreateCompanyName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateCompanyName.Location = new System.Drawing.Point(10, 92);
            this.LblCreateCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateCompanyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateCompanyName.Name = "LblCreateCompanyName";
            this.LblCreateCompanyName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateCompanyName.Size = new System.Drawing.Size(120, 19);
            this.LblCreateCompanyName.TabIndex = 30;
            this.LblCreateCompanyName.Text = "Company name*";
            // 
            // CmbCreateCustomerType
            // 
            this.CmbCreateCustomerType.AutoResize = false;
            this.CmbCreateCustomerType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbCreateCustomerType.Depth = 0;
            this.CmbCreateCustomerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbCreateCustomerType.DropDownHeight = 174;
            this.CmbCreateCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCreateCustomerType.DropDownWidth = 121;
            this.CmbCreateCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbCreateCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbCreateCustomerType.FormattingEnabled = true;
            this.CmbCreateCustomerType.IntegralHeight = false;
            this.CmbCreateCustomerType.ItemHeight = 43;
            this.CmbCreateCustomerType.Items.AddRange(new object[] {
            "-",
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.CmbCreateCustomerType.Location = new System.Drawing.Point(454, 12);
            this.CmbCreateCustomerType.MaxDropDownItems = 4;
            this.CmbCreateCustomerType.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbCreateCustomerType.Name = "CmbCreateCustomerType";
            this.CmbCreateCustomerType.Size = new System.Drawing.Size(76, 49);
            this.CmbCreateCustomerType.StartIndex = 0;
            this.CmbCreateCustomerType.TabIndex = 33;
            // 
            // TxtCreateCompanyName
            // 
            this.TxtCreateCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateCompanyName.Depth = 0;
            this.TxtCreateCompanyName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateCompanyName.Location = new System.Drawing.Point(10, 118);
            this.TxtCreateCompanyName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateCompanyName.MaxLength = 50;
            this.TxtCreateCompanyName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateCompanyName.Multiline = false;
            this.TxtCreateCompanyName.Name = "TxtCreateCompanyName";
            this.TxtCreateCompanyName.Size = new System.Drawing.Size(262, 50);
            this.TxtCreateCompanyName.TabIndex = 31;
            this.TxtCreateCompanyName.Text = "";
            // 
            // LblCreateCustomerType
            // 
            this.LblCreateCustomerType.AutoSize = true;
            this.LblCreateCustomerType.Depth = 0;
            this.LblCreateCustomerType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateCustomerType.Location = new System.Drawing.Point(292, 25);
            this.LblCreateCustomerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateCustomerType.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateCustomerType.Name = "LblCreateCustomerType";
            this.LblCreateCustomerType.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateCustomerType.Size = new System.Drawing.Size(148, 19);
            this.LblCreateCustomerType.TabIndex = 32;
            this.LblCreateCustomerType.Text = "Customer type* (A-E)";
            // 
            // LblCreateCompanyContact
            // 
            this.LblCreateCompanyContact.AutoSize = true;
            this.LblCreateCompanyContact.Depth = 0;
            this.LblCreateCompanyContact.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateCompanyContact.Location = new System.Drawing.Point(292, 91);
            this.LblCreateCompanyContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateCompanyContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateCompanyContact.Name = "LblCreateCompanyContact";
            this.LblCreateCompanyContact.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateCompanyContact.Size = new System.Drawing.Size(133, 19);
            this.LblCreateCompanyContact.TabIndex = 33;
            this.LblCreateCompanyContact.Text = "Company contact*";
            // 
            // TxtCreateCompanyContact
            // 
            this.TxtCreateCompanyContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateCompanyContact.Depth = 0;
            this.TxtCreateCompanyContact.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateCompanyContact.Location = new System.Drawing.Point(291, 118);
            this.TxtCreateCompanyContact.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateCompanyContact.MaxLength = 50;
            this.TxtCreateCompanyContact.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateCompanyContact.Multiline = false;
            this.TxtCreateCompanyContact.Name = "TxtCreateCompanyContact";
            this.TxtCreateCompanyContact.Size = new System.Drawing.Size(239, 50);
            this.TxtCreateCompanyContact.TabIndex = 32;
            this.TxtCreateCompanyContact.Text = "";
            // 
            // PnlCreateInfoEmployee
            // 
            this.PnlCreateInfoEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCreateInfoEmployee.Controls.Add(this.NumCreateDegreeOfEmployment);
            this.PnlCreateInfoEmployee.Controls.Add(this.PrgDegreeOfEmployment);
            this.PnlCreateInfoEmployee.Controls.Add(this.PnlCreateInfoTrainee);
            this.PnlCreateInfoEmployee.Controls.Add(this.LblCreateDateOfJoining);
            this.PnlCreateInfoEmployee.Controls.Add(this.LblCreateDateOfLeaving);
            this.PnlCreateInfoEmployee.Controls.Add(this.DatCreateDateOfLeaving);
            this.PnlCreateInfoEmployee.Controls.Add(this.DatCreateDateOfJoining);
            this.PnlCreateInfoEmployee.Controls.Add(this.TxtCreateEmployeeNumber);
            this.PnlCreateInfoEmployee.Controls.Add(this.LblEmployeeNumber);
            this.PnlCreateInfoEmployee.Controls.Add(this.LblDepartement);
            this.PnlCreateInfoEmployee.Controls.Add(this.TxtCreateDepartement);
            this.PnlCreateInfoEmployee.Controls.Add(this.NumCadreLevel);
            this.PnlCreateInfoEmployee.Controls.Add(this.LblDegreeOfEmployment);
            this.PnlCreateInfoEmployee.Controls.Add(this.LblCadreLevel);
            this.PnlCreateInfoEmployee.Controls.Add(this.LblRole);
            this.PnlCreateInfoEmployee.Controls.Add(this.TxtCreateRole);
            this.PnlCreateInfoEmployee.Location = new System.Drawing.Point(637, 5);
            this.PnlCreateInfoEmployee.Name = "PnlCreateInfoEmployee";
            this.PnlCreateInfoEmployee.Size = new System.Drawing.Size(630, 350);
            this.PnlCreateInfoEmployee.TabIndex = 83;
            // 
            // NumCreateDegreeOfEmployment
            // 
            this.NumCreateDegreeOfEmployment.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCreateDegreeOfEmployment.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumCreateDegreeOfEmployment.Location = new System.Drawing.Point(484, 27);
            this.NumCreateDegreeOfEmployment.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NumCreateDegreeOfEmployment.Name = "NumCreateDegreeOfEmployment";
            this.NumCreateDegreeOfEmployment.Size = new System.Drawing.Size(49, 29);
            this.NumCreateDegreeOfEmployment.TabIndex = 23;
            this.NumCreateDegreeOfEmployment.ValueChanged += new System.EventHandler(this.NumCreateDegreeOfEmployment_ValueChanged);
            // 
            // PrgDegreeOfEmployment
            // 
            this.PrgDegreeOfEmployment.Depth = 0;
            this.PrgDegreeOfEmployment.Location = new System.Drawing.Point(287, 51);
            this.PrgDegreeOfEmployment.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrgDegreeOfEmployment.Name = "PrgDegreeOfEmployment";
            this.PrgDegreeOfEmployment.Size = new System.Drawing.Size(185, 5);
            this.PrgDegreeOfEmployment.TabIndex = 85;
            this.PrgDegreeOfEmployment.Value = 100;
            // 
            // PnlCreateInfoTrainee
            // 
            this.PnlCreateInfoTrainee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCreateInfoTrainee.Controls.Add(this.LblCreateYearOfApp);
            this.PnlCreateInfoTrainee.Controls.Add(this.NumCreateYearOfApp);
            this.PnlCreateInfoTrainee.Controls.Add(this.LblCreateCurrentAppYear);
            this.PnlCreateInfoTrainee.Controls.Add(this.NumCreateCurrentAppYear);
            this.PnlCreateInfoTrainee.Location = new System.Drawing.Point(7, 263);
            this.PnlCreateInfoTrainee.Name = "PnlCreateInfoTrainee";
            this.PnlCreateInfoTrainee.Size = new System.Drawing.Size(465, 77);
            this.PnlCreateInfoTrainee.TabIndex = 84;
            // 
            // LblCreateYearOfApp
            // 
            this.LblCreateYearOfApp.AutoSize = true;
            this.LblCreateYearOfApp.Depth = 0;
            this.LblCreateYearOfApp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateYearOfApp.Location = new System.Drawing.Point(246, 12);
            this.LblCreateYearOfApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateYearOfApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateYearOfApp.Name = "LblCreateYearOfApp";
            this.LblCreateYearOfApp.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateYearOfApp.Size = new System.Drawing.Size(175, 19);
            this.LblCreateYearOfApp.TabIndex = 27;
            this.LblCreateYearOfApp.Text = "Years of apprenticeship*";
            // 
            // NumCreateYearOfApp
            // 
            this.NumCreateYearOfApp.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCreateYearOfApp.Location = new System.Drawing.Point(249, 34);
            this.NumCreateYearOfApp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NumCreateYearOfApp.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumCreateYearOfApp.Name = "NumCreateYearOfApp";
            this.NumCreateYearOfApp.Size = new System.Drawing.Size(44, 29);
            this.NumCreateYearOfApp.TabIndex = 30;
            // 
            // LblCreateCurrentAppYear
            // 
            this.LblCreateCurrentAppYear.AutoSize = true;
            this.LblCreateCurrentAppYear.Depth = 0;
            this.LblCreateCurrentAppYear.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateCurrentAppYear.Location = new System.Drawing.Point(2, 12);
            this.LblCreateCurrentAppYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateCurrentAppYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateCurrentAppYear.Name = "LblCreateCurrentAppYear";
            this.LblCreateCurrentAppYear.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateCurrentAppYear.Size = new System.Drawing.Size(194, 19);
            this.LblCreateCurrentAppYear.TabIndex = 28;
            this.LblCreateCurrentAppYear.Text = "Current apprenticeship year";
            // 
            // NumCreateCurrentAppYear
            // 
            this.NumCreateCurrentAppYear.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCreateCurrentAppYear.Location = new System.Drawing.Point(5, 34);
            this.NumCreateCurrentAppYear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NumCreateCurrentAppYear.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumCreateCurrentAppYear.Name = "NumCreateCurrentAppYear";
            this.NumCreateCurrentAppYear.Size = new System.Drawing.Size(49, 29);
            this.NumCreateCurrentAppYear.TabIndex = 29;
            // 
            // LblCreateDateOfJoining
            // 
            this.LblCreateDateOfJoining.AutoSize = true;
            this.LblCreateDateOfJoining.Depth = 0;
            this.LblCreateDateOfJoining.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateDateOfJoining.Location = new System.Drawing.Point(8, 181);
            this.LblCreateDateOfJoining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateDateOfJoining.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateDateOfJoining.Name = "LblCreateDateOfJoining";
            this.LblCreateDateOfJoining.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateDateOfJoining.Size = new System.Drawing.Size(112, 19);
            this.LblCreateDateOfJoining.TabIndex = 21;
            this.LblCreateDateOfJoining.Text = "Date of joining*";
            // 
            // LblCreateDateOfLeaving
            // 
            this.LblCreateDateOfLeaving.AutoSize = true;
            this.LblCreateDateOfLeaving.Depth = 0;
            this.LblCreateDateOfLeaving.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCreateDateOfLeaving.Location = new System.Drawing.Point(148, 181);
            this.LblCreateDateOfLeaving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateDateOfLeaving.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCreateDateOfLeaving.Name = "LblCreateDateOfLeaving";
            this.LblCreateDateOfLeaving.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCreateDateOfLeaving.Size = new System.Drawing.Size(108, 19);
            this.LblCreateDateOfLeaving.TabIndex = 22;
            this.LblCreateDateOfLeaving.Text = "Date of leaving";
            // 
            // DatCreateDateOfLeaving
            // 
            this.DatCreateDateOfLeaving.CustomFormat = "HTML Format";
            this.DatCreateDateOfLeaving.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatCreateDateOfLeaving.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatCreateDateOfLeaving.Location = new System.Drawing.Point(148, 207);
            this.DatCreateDateOfLeaving.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DatCreateDateOfLeaving.Name = "DatCreateDateOfLeaving";
            this.DatCreateDateOfLeaving.Size = new System.Drawing.Size(109, 29);
            this.DatCreateDateOfLeaving.TabIndex = 28;
            this.DatCreateDateOfLeaving.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // DatCreateDateOfJoining
            // 
            this.DatCreateDateOfJoining.CustomFormat = "HTML Format";
            this.DatCreateDateOfJoining.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatCreateDateOfJoining.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatCreateDateOfJoining.Location = new System.Drawing.Point(7, 207);
            this.DatCreateDateOfJoining.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DatCreateDateOfJoining.Name = "DatCreateDateOfJoining";
            this.DatCreateDateOfJoining.Size = new System.Drawing.Size(117, 29);
            this.DatCreateDateOfJoining.TabIndex = 27;
            this.DatCreateDateOfJoining.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // TxtCreateEmployeeNumber
            // 
            this.TxtCreateEmployeeNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateEmployeeNumber.Depth = 0;
            this.TxtCreateEmployeeNumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateEmployeeNumber.Location = new System.Drawing.Point(146, 12);
            this.TxtCreateEmployeeNumber.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateEmployeeNumber.MaxLength = 50;
            this.TxtCreateEmployeeNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateEmployeeNumber.Multiline = false;
            this.TxtCreateEmployeeNumber.Name = "TxtCreateEmployeeNumber";
            this.TxtCreateEmployeeNumber.Size = new System.Drawing.Size(125, 50);
            this.TxtCreateEmployeeNumber.TabIndex = 22;
            this.TxtCreateEmployeeNumber.Text = "";
            // 
            // LblEmployeeNumber
            // 
            this.LblEmployeeNumber.AutoSize = true;
            this.LblEmployeeNumber.Depth = 0;
            this.LblEmployeeNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblEmployeeNumber.Location = new System.Drawing.Point(8, 25);
            this.LblEmployeeNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmployeeNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEmployeeNumber.Name = "LblEmployeeNumber";
            this.LblEmployeeNumber.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblEmployeeNumber.Size = new System.Drawing.Size(128, 19);
            this.LblEmployeeNumber.TabIndex = 14;
            this.LblEmployeeNumber.Text = "Employee number";
            // 
            // LblDepartement
            // 
            this.LblDepartement.AutoSize = true;
            this.LblDepartement.Depth = 0;
            this.LblDepartement.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblDepartement.Location = new System.Drawing.Point(8, 87);
            this.LblDepartement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDepartement.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDepartement.Name = "LblDepartement";
            this.LblDepartement.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblDepartement.Size = new System.Drawing.Size(92, 19);
            this.LblDepartement.TabIndex = 15;
            this.LblDepartement.Text = "Departement";
            // 
            // TxtCreateDepartement
            // 
            this.TxtCreateDepartement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateDepartement.Depth = 0;
            this.TxtCreateDepartement.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateDepartement.Location = new System.Drawing.Point(8, 113);
            this.TxtCreateDepartement.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateDepartement.MaxLength = 50;
            this.TxtCreateDepartement.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateDepartement.Multiline = false;
            this.TxtCreateDepartement.Name = "TxtCreateDepartement";
            this.TxtCreateDepartement.Size = new System.Drawing.Size(263, 50);
            this.TxtCreateDepartement.TabIndex = 24;
            this.TxtCreateDepartement.Text = "";
            // 
            // NumCadreLevel
            // 
            this.NumCadreLevel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCadreLevel.Location = new System.Drawing.Point(515, 118);
            this.NumCadreLevel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NumCadreLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumCadreLevel.Name = "NumCadreLevel";
            this.NumCadreLevel.Size = new System.Drawing.Size(49, 29);
            this.NumCadreLevel.TabIndex = 26;
            // 
            // LblDegreeOfEmployment
            // 
            this.LblDegreeOfEmployment.AutoSize = true;
            this.LblDegreeOfEmployment.Depth = 0;
            this.LblDegreeOfEmployment.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblDegreeOfEmployment.Location = new System.Drawing.Point(286, 25);
            this.LblDegreeOfEmployment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDegreeOfEmployment.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDegreeOfEmployment.Name = "LblDegreeOfEmployment";
            this.LblDegreeOfEmployment.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblDegreeOfEmployment.Size = new System.Drawing.Size(195, 19);
            this.LblDegreeOfEmployment.TabIndex = 23;
            this.LblDegreeOfEmployment.Text = "Degree of employment* (%)";
            // 
            // LblCadreLevel
            // 
            this.LblCadreLevel.AutoSize = true;
            this.LblCadreLevel.Depth = 0;
            this.LblCadreLevel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCadreLevel.Location = new System.Drawing.Point(514, 91);
            this.LblCadreLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCadreLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCadreLevel.Name = "LblCadreLevel";
            this.LblCadreLevel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCadreLevel.Size = new System.Drawing.Size(115, 19);
            this.LblCadreLevel.TabIndex = 25;
            this.LblCadreLevel.Text = "Cadre level (0-5)";
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Depth = 0;
            this.LblRole.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblRole.Location = new System.Drawing.Point(288, 87);
            this.LblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblRole.Name = "LblRole";
            this.LblRole.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblRole.Size = new System.Drawing.Size(104, 19);
            this.LblRole.TabIndex = 24;
            this.LblRole.Text = "Role (Job title)";
            // 
            // TxtCreateRole
            // 
            this.TxtCreateRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateRole.Depth = 0;
            this.TxtCreateRole.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCreateRole.Location = new System.Drawing.Point(287, 113);
            this.TxtCreateRole.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TxtCreateRole.MaxLength = 50;
            this.TxtCreateRole.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCreateRole.Multiline = false;
            this.TxtCreateRole.Name = "TxtCreateRole";
            this.TxtCreateRole.Size = new System.Drawing.Size(216, 50);
            this.TxtCreateRole.TabIndex = 25;
            this.TxtCreateRole.Text = "";
            // 
            // GrpCreateGender
            // 
            this.GrpCreateGender.Location = new System.Drawing.Point(131, 3);
            this.GrpCreateGender.Name = "GrpCreateGender";
            this.GrpCreateGender.Size = new System.Drawing.Size(277, 66);
            this.GrpCreateGender.TabIndex = 80;
            this.GrpCreateGender.TabStop = false;
            this.GrpCreateGender.Text = "Gender*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 715);
            this.Controls.Add(this.TCtrlMain);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TCtrlMain.ResumeLayout(false);
            this.TabSearch.ResumeLayout(false);
            this.TabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSearchResult)).EndInit();
            this.PnlSearchPreview.ResumeLayout(false);
            this.PnlSearchPreview.PerformLayout();
            this.PnlSearchPreviewCustomer.ResumeLayout(false);
            this.PnlSearchPreviewCustomer.PerformLayout();
            this.PnlSearchPreviewTrainee.ResumeLayout(false);
            this.PnlSearchPreviewTrainee.PerformLayout();
            this.PnlSearchPreviewEmployee.ResumeLayout(false);
            this.PnlSearchPreviewEmployee.PerformLayout();
            this.PnlSearchPreviewGeneral.ResumeLayout(false);
            this.PnlSearchPreviewGeneral.PerformLayout();
            this.TabCreateEdit.ResumeLayout(false);
            this.TabCreate.ResumeLayout(false);
            this.TabCreate.PerformLayout();
            this.PnlCreateInfoGeneral.ResumeLayout(false);
            this.PnlCreateInfoGeneral.PerformLayout();
            this.GrpCreateType.ResumeLayout(false);
            this.GrpCreateType.PerformLayout();
            this.PnlCreateInfoCustomer.ResumeLayout(false);
            this.PnlCreateInfoCustomer.PerformLayout();
            this.PnlCreateInfoEmployee.ResumeLayout(false);
            this.PnlCreateInfoEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCreateDegreeOfEmployment)).EndInit();
            this.PnlCreateInfoTrainee.ResumeLayout(false);
            this.PnlCreateInfoTrainee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCreateYearOfApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCreateCurrentAppYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).EndInit();
            this.ResumeLayout(false);

        }




        #endregion

        private MaterialSkin.Controls.MaterialTabControl TCtrlMain;
        private System.Windows.Forms.TabPage TabSearch;
        private System.Windows.Forms.TabPage TabCreateEdit;
        private MaterialSkin.Controls.MaterialLabel LblCreateBusinessAddress;
        private MaterialSkin.Controls.MaterialLabel LblCreateCurrentAppYear;
        private MaterialSkin.Controls.MaterialLabel LblCreateYearOfApp;
        private MaterialSkin.Controls.MaterialLabel LblCadreLevel;
        private MaterialSkin.Controls.MaterialLabel LblRole;
        private MaterialSkin.Controls.MaterialLabel LblDegreeOfEmployment;
        private MaterialSkin.Controls.MaterialLabel LblCreateDateOfLeaving;
        private MaterialSkin.Controls.MaterialLabel LblCreateDateOfJoining;
        private MaterialSkin.Controls.MaterialLabel LblCreateOasiNr;
        private MaterialSkin.Controls.MaterialLabel LblDepartement;
        private MaterialSkin.Controls.MaterialLabel LblEmployeeNumber;
        private MaterialSkin.Controls.MaterialCheckbox ChkCreateTrainee;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateDepartement;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateRole;
        private System.Windows.Forms.NumericUpDown NumCreateYearOfApp;
        private System.Windows.Forms.NumericUpDown NumCreateCurrentAppYear;
        private System.Windows.Forms.NumericUpDown NumCadreLevel;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateBusinessAddress;
        private System.Windows.Forms.DateTimePicker DatCreateDateOfLeaving;
        private System.Windows.Forms.DateTimePicker DatCreateDateOfJoining;
        private MaterialSkin.Controls.MaterialButton CmdCreateSavePerson;
        private MaterialSkin.Controls.MaterialTextBox TxtCreatePrivatePhone;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateBusnissPhone;
        private MaterialSkin.Controls.MaterialLabel LblCreateBusnissPhone;
        private MaterialSkin.Controls.MaterialLabel LblCreatePrivatePhone;
        private MaterialSkin.Controls.MaterialCard TabCreate;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateLastName;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateFirstName;
        private MaterialSkin.Controls.MaterialLabel LblCreateLastName;
        private MaterialSkin.Controls.MaterialLabel LblCreateFirstName;
        private MaterialSkin.Controls.MaterialLabel LblCreateSalutation;
        private MaterialSkin.Controls.MaterialRadioButton RadCreateEmployee;
        private MaterialSkin.Controls.MaterialRadioButton RadCreateCustomer;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateOasiNr;
        private MaterialSkin.Controls.MaterialRadioButton RadCreateOther;
        private MaterialSkin.Controls.MaterialRadioButton RadCreateFemale;
        private MaterialSkin.Controls.MaterialRadioButton RadCreateMale;
        private MaterialSkin.Controls.MaterialSwitch SwtCreateActive;
        private System.Windows.Forms.DateTimePicker DatCreateBirthday;
        private MaterialSkin.Controls.MaterialTextBox TxtCreatePlz;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateAddress;
        private MaterialSkin.Controls.MaterialTextBox TxtCreatePlaceOfResidence;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateTitle;
        private MaterialSkin.Controls.MaterialLabel LblCreatePLZ;
        private MaterialSkin.Controls.MaterialLabel LblCreateAddress;
        private MaterialSkin.Controls.MaterialLabel LblCreateNationality;
        private MaterialSkin.Controls.MaterialLabel LblCreatePlaceOfResidence;
        private MaterialSkin.Controls.MaterialLabel LblCreateTitle;
        private MaterialSkin.Controls.MaterialLabel LblCreateDateOfBirth;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateEmailAddress;
        private MaterialSkin.Controls.MaterialLabel LblCreateEmailAddress;
        private System.Windows.Forms.TextBox TxtSearch;
        private MaterialSkin.Controls.MaterialComboBox CmbCreateNationality;
        private MaterialSkin.Controls.MaterialComboBox CmbCreateSalutation;
        private System.Windows.Forms.Panel PnlCreateInfoGeneral;
        private System.Windows.Forms.Panel PnlCreateInfoEmployee;
        private System.Windows.Forms.Panel PnlCreateInfoTrainee;
        private System.Windows.Forms.GroupBox GrpCreateType;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateEmployeeNumber;
        private MaterialSkin.Controls.MaterialProgressBar PrgDegreeOfEmployment;
        private System.Windows.Forms.NumericUpDown NumCreateDegreeOfEmployment;
        private System.Windows.Forms.Label LblCreateTypeSelection;
        private MaterialSkin.Controls.MaterialButton CmdCreateCancel;
        private MaterialSkin.Controls.MaterialButton CmdCreatePersonSaveAndNew;
        private MaterialSkin.Controls.MaterialLabel LblCreateNotes;
        private System.Windows.Forms.Panel PnlCreateInfoCustomer;
        private MaterialSkin.Controls.MaterialLabel LblCreateCompanyName;
        private MaterialSkin.Controls.MaterialComboBox CmbCreateCustomerType;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateCompanyName;
        private MaterialSkin.Controls.MaterialLabel LblCreateCustomerType;
        private MaterialSkin.Controls.MaterialLabel LblCreateCompanyContact;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateCompanyContact;
        private System.Windows.Forms.DataGridView DataGridViewSearchResult;
        private MaterialSkin.Controls.MaterialButton CmdSearchExec;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton CmdSearchAdvanced;
        private MaterialSkin.Controls.MaterialButton CmdSearchPersonEdit;
        private MaterialSkin.Controls.MaterialButton CmdSearchCreate;
        private MaterialSkin.Controls.MaterialButton CmdSearchPersonDelete;
        private MaterialSkin.Controls.MaterialLabel LblSearchResultCounter;
        private System.Windows.Forms.Panel PnlSearchPreview;
        private MaterialSkin.Controls.MaterialLabel LblSearchFirstName;
        private MaterialSkin.Controls.MaterialLabel LblSearchLastName;
        private MaterialSkin.Controls.MaterialTextBox TxtSearchFirstName;
        private MaterialSkin.Controls.MaterialTextBox TxtSearchLastName;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateCustomerNumber;
        private MaterialSkin.Controls.MaterialLabel LblCreateCustomerNumber;
        private MaterialSkin.Controls.MaterialTextBox TxtSearchNumber;
        private MaterialSkin.Controls.MaterialLabel LblSearchNumber;
        private MaterialSkin.Controls.MaterialCheckbox ChkSearchTypeTrainee;
        private MaterialSkin.Controls.MaterialCheckbox ChkSearchTypeEmployee;
        private MaterialSkin.Controls.MaterialCheckbox ChkSearchTypeCustomer;
        private MaterialSkin.Controls.MaterialTextBox TxtSearchAddress;
        private MaterialSkin.Controls.MaterialTextBox TxtSearchPlaceOfResidence;
        private MaterialSkin.Controls.MaterialLabel LblSearchAddress;
        private MaterialSkin.Controls.MaterialLabel LblSearchPlaceOfResidence;
        private MaterialSkin.Controls.MaterialCheckbox ChkSearchInactive;
        private MaterialSkin.Controls.MaterialLabel LblSearchDateOfBirth;
        private MaterialSkin.Controls.MaterialTextBox TxtSearchDateOfBirth;
        private System.Windows.Forms.Label LblSearchHeadlineCustomer;
        private System.Windows.Forms.Label LblSearchHeadlineGeneral;
        private System.Windows.Forms.Label LblSearchPreviewAddress;
        private System.Windows.Forms.Label LblSearchPreviewLastName;
        private System.Windows.Forms.Label LblSearchPreviewFirstName;
        private System.Windows.Forms.Label LblSearchPreviewTitle;
        private System.Windows.Forms.Label LblSearchPreviewOasiNumber;
        private System.Windows.Forms.Label LblSearchPreviewNationality;
        private System.Windows.Forms.Label LblSearchPreviewPlaceOfResidence;
        private System.Windows.Forms.Label LblSearchPreviewPostalCode;
        private System.Windows.Forms.Label LblSearchPreviewBusinessAddress;
        private System.Windows.Forms.Label LblSearchPreviewEmailAddress;
        private System.Windows.Forms.Label LblSearchPreviewBusinessPhone;
        private System.Windows.Forms.Label LblSearchPreviewPrivatePhone;
        private System.Windows.Forms.Label LblSearchPreviewDateOfBirth;
        private System.Windows.Forms.Label LblSearchPreviewCustomerType;
        private System.Windows.Forms.Label LblSearchPreviewType;
        private System.Windows.Forms.Label LblSearchPreviewNumber;
        private System.Windows.Forms.Label LblSearchPreviewCompanyName;
        private System.Windows.Forms.Label LblSearchPreviewCompanyContact;
        private System.Windows.Forms.Panel PnlSearchPreviewCustomer;
        private System.Windows.Forms.Panel PnlSearchPreviewEmployee;
        private System.Windows.Forms.Label LblSearchPreviewDateOfLeaving;
        private System.Windows.Forms.Label LblSearchPreviewDateOfJoining;
        private System.Windows.Forms.Label LblSearchPreviewCadreLevel;
        private System.Windows.Forms.Label LblSearchPreviewEmployee;
        private System.Windows.Forms.Label LblSearchPreviewRole;
        private System.Windows.Forms.Label LblSearchPreviewDegreeOfEmployment;
        private System.Windows.Forms.Label LblSearchPreviewDepartement;
        private System.Windows.Forms.Panel PnlSearchPreviewTrainee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblSearchPreviewCurrentAppYear;
        private System.Windows.Forms.Label LblSearchPreviewYearsOfApp;
        private System.Windows.Forms.Panel PnlSearchPreviewGeneral;
        private System.Windows.Forms.Label LblSearchPreviewDateOfBirthOutput;
        private System.Windows.Forms.Label LblSearchPreviewOasiNumberOutput;
        private System.Windows.Forms.Label LblSearchPreviewNationalityOutput;
        private System.Windows.Forms.Label LblSearchPreviewPlaceOfResidenceOutput;
        private System.Windows.Forms.Label LblSearchPreviewPostalCodeOutput;
        private System.Windows.Forms.Label LblSearchPreviewAddressOutput;
        private System.Windows.Forms.Label LblSearchPreviewLastNameOutput;
        private System.Windows.Forms.Label LblSearchPreviewFirstNameOutput;
        private System.Windows.Forms.Label LblSearchPreviewTitleOutput;
        private System.Windows.Forms.Label LblSearchPreviewBusinessAddressOutput;
        private System.Windows.Forms.Label LblSearchPreviewBusinessPhoneOutput;
        private System.Windows.Forms.Label LblSearchPreviewPrivatePhoneOutput;
        private System.Windows.Forms.Label LblSearchPreviewEmailAddressOutput;
        private System.Windows.Forms.Label LblSearchPreviewYearsOfAppOutput;
        private System.Windows.Forms.Label LblSearchPreviewCurrentAppYearOutput;
        private System.Windows.Forms.Label LblSearchPreviewCompanyContactOutput;
        private System.Windows.Forms.Label LblSearchPreviewCompanyNameOutput;
        private System.Windows.Forms.Label LblSearchPreviewCustomerTypeOutput;
        private System.Windows.Forms.Label LblSearchPreviewDateOfLeavingOutput;
        private System.Windows.Forms.Label LblSearchPreviewDateOfJoiningOutput;
        private System.Windows.Forms.Label LblSearchPreviewCadreLevelOutput;
        private System.Windows.Forms.Label LblSearchPreviewRoleOutput;
        private System.Windows.Forms.Label LblSearchPreviewDepartementOutput;
        private System.Windows.Forms.Label LblSearchPreviewDegreeOfEmploymentOutput;
        private MaterialSkin.Controls.MaterialLabel LblSearchNotes;
        private System.Windows.Forms.Label LblNoResults;
        private System.Windows.Forms.Label LblSearchPreviewStatusOutput;
        private System.Windows.Forms.Label LblSearchPreviewStatus;
        private System.Windows.Forms.TextBox TxtCreateNote;
        private MaterialSkin.Controls.MaterialLabel LblSearchPerson;
        private System.Windows.Forms.TextBox TxtSearchNote;
        private MaterialSkin.Controls.MaterialButton CmdCreateNoteClear;
        private MaterialSkin.Controls.MaterialButton CmdSearchNoteClear;
        private MaterialSkin.Controls.MaterialButton CmdSearchNoteSave;
        private MaterialSkin.Controls.MaterialButton CmdSearchNoteEdit;
        private MaterialSkin.Controls.MaterialButton CmdCreateDeletePerson;
        private MaterialSkin.Controls.MaterialButton CmdSearchClear;
        private System.Windows.Forms.Label LblSearchPreviewNumberOutput;
        private System.Windows.Forms.Label LblSearchPreviewTypeOutput;
        private MaterialSkin.Controls.MaterialButton CmdSearchCancel;
        private System.Windows.Forms.Label LblSearchPreviewSalutationOutput;
        private System.Windows.Forms.Label LblSearchPreviewSalutation;
        private System.Windows.Forms.Label LblSearchPreviewGenderOutput;
        private System.Windows.Forms.Label LblSearchPreviewGender;
        private System.Windows.Forms.GroupBox GrpCreateGender;
    }
}
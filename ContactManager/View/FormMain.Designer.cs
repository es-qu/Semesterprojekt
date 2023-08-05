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
            this.TCtrlMain = new MaterialSkin.Controls.MaterialTabControl();
            this.TabSearch = new System.Windows.Forms.TabPage();
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
            this.PnlSearchPreview = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblSearchHeadlineCustomer = new System.Windows.Forms.Label();
            this.LblSearchHeadlineGeneral = new System.Windows.Forms.Label();
            this.CmdQuickPersonEdit = new MaterialSkin.Controls.MaterialButton();
            this.LblSearchResultCounter = new MaterialSkin.Controls.MaterialLabel();
            this.CmdQuickPersonCreate = new MaterialSkin.Controls.MaterialButton();
            this.CmdQuickPersonDelete = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CmdSearchAdvanced = new MaterialSkin.Controls.MaterialButton();
            this.CmdSearchExec2 = new MaterialSkin.Controls.MaterialButton();
            this.DataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.CmdExecSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TabCreateEdit = new System.Windows.Forms.TabPage();
            this.TabCreate = new MaterialSkin.Controls.MaterialCard();
            this.PnlCustomer = new System.Windows.Forms.Panel();
            this.TxtCustomerNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCustomerNumber = new MaterialSkin.Controls.MaterialLabel();
            this.LblCompanyName = new MaterialSkin.Controls.MaterialLabel();
            this.CmbCustomerType = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtCompanyName = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCustomerType = new MaterialSkin.Controls.MaterialLabel();
            this.LblCompanyContact = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCompanyContact = new MaterialSkin.Controls.MaterialTextBox();
            this.CmdNoteEdit = new MaterialSkin.Controls.MaterialButton();
            this.LblNotes = new MaterialSkin.Controls.MaterialLabel();
            this.CmdNoteAdd = new MaterialSkin.Controls.MaterialButton();
            this.CmdNoteDelete = new MaterialSkin.Controls.MaterialButton();
            this.LstNoteOut = new System.Windows.Forms.ListBox();
            this.CmdNotesAll = new MaterialSkin.Controls.MaterialButton();
            this.CmdCancel = new MaterialSkin.Controls.MaterialButton();
            this.CmdCreatePersonAndNew = new MaterialSkin.Controls.MaterialButton();
            this.LblTypeSelection = new System.Windows.Forms.Label();
            this.PnlPerson = new System.Windows.Forms.Panel();
            this.GrpType = new System.Windows.Forms.GroupBox();
            this.RadEmployee = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadCustomer = new MaterialSkin.Controls.MaterialRadioButton();
            this.ChkTrainee = new MaterialSkin.Controls.MaterialCheckbox();
            this.RadOther = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.SwtActive = new MaterialSkin.Controls.MaterialSwitch();
            this.LblOasiNr = new MaterialSkin.Controls.MaterialLabel();
            this.DatBirthday = new System.Windows.Forms.DateTimePicker();
            this.TxtPlz = new MaterialSkin.Controls.MaterialTextBox();
            this.CmbSalutation = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.LblSalutation = new MaterialSkin.Controls.MaterialLabel();
            this.TxtOasiNr = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtPlaceOfResidence = new MaterialSkin.Controls.MaterialTextBox();
            this.CmbNationality = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBusinessAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.LblFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.LblBusinessAddress = new MaterialSkin.Controls.MaterialLabel();
            this.LblPLZ = new MaterialSkin.Controls.MaterialLabel();
            this.LblLastName = new MaterialSkin.Controls.MaterialLabel();
            this.LblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.TxtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.LblNationality = new MaterialSkin.Controls.MaterialLabel();
            this.TxtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.LblPlaceOfResidence = new MaterialSkin.Controls.MaterialLabel();
            this.LblDateOfBirth = new MaterialSkin.Controls.MaterialLabel();
            this.LblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.LblEmailAddress = new MaterialSkin.Controls.MaterialLabel();
            this.TxtEmailAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.LblBusnissPhone = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBusnissPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.LblPrivatePhone = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPrivatePhone = new MaterialSkin.Controls.MaterialTextBox();
            this.CmdCreatePerson = new MaterialSkin.Controls.MaterialButton();
            this.PnlEmployee = new System.Windows.Forms.Panel();
            this.NumDegreeOfEmployment = new System.Windows.Forms.NumericUpDown();
            this.PrgDegreeOfEmployment = new MaterialSkin.Controls.MaterialProgressBar();
            this.PnlTrainee = new System.Windows.Forms.Panel();
            this.LblYearOfApp = new MaterialSkin.Controls.MaterialLabel();
            this.NumYearOfApp = new System.Windows.Forms.NumericUpDown();
            this.LblCurrentAppYear = new MaterialSkin.Controls.MaterialLabel();
            this.NumCurrentAppYear = new System.Windows.Forms.NumericUpDown();
            this.LblDateOfJoining = new MaterialSkin.Controls.MaterialLabel();
            this.LblDateOfLeaving = new MaterialSkin.Controls.MaterialLabel();
            this.DatDateOfLeaving = new System.Windows.Forms.DateTimePicker();
            this.DatDateOfJoining = new System.Windows.Forms.DateTimePicker();
            this.TxtEmployeeNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.LblEmployeeNumber = new MaterialSkin.Controls.MaterialLabel();
            this.LblDepartement = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDepartement = new MaterialSkin.Controls.MaterialTextBox();
            this.NumCadreLevel = new System.Windows.Forms.NumericUpDown();
            this.LblDegreeOfEmployment = new MaterialSkin.Controls.MaterialLabel();
            this.LblCadreLevel = new MaterialSkin.Controls.MaterialLabel();
            this.LblRole = new MaterialSkin.Controls.MaterialLabel();
            this.TxtRole = new MaterialSkin.Controls.MaterialTextBox();
            this.LblSearchPreviewNumber = new System.Windows.Forms.Label();
            this.LblSearchPreviewType = new System.Windows.Forms.Label();
            this.LblSearchPreviewCustomerType = new System.Windows.Forms.Label();
            this.LblSearchPreviewCompanyName = new System.Windows.Forms.Label();
            this.LblSearchPreviewCompanyContact = new System.Windows.Forms.Label();
            this.PnlSearchPreviewCustomer = new System.Windows.Forms.Panel();
            this.PnlSearchPreviewEmployee = new System.Windows.Forms.Panel();
            this.LblSearchPreviewEmployee = new System.Windows.Forms.Label();
            this.LblSearchPreviewRole = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LblSearchPreviewDepartement = new System.Windows.Forms.Label();
            this.LblSearchPreviewCadreLevel = new System.Windows.Forms.Label();
            this.LblSearchPreviewDateOfJoining = new System.Windows.Forms.Label();
            this.LblSearchPreviewDateOfLeaving = new System.Windows.Forms.Label();
            this.PnlSearchPreviewTrainee = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.LblSearchPreviewCurrentAppYear = new System.Windows.Forms.Label();
            this.LblSearchPreviewYearsOfApp = new System.Windows.Forms.Label();
            this.PnlSearchPreviewGeneral = new System.Windows.Forms.Panel();
            this.LblSearchPreviewStatus = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblSearchNotes = new MaterialSkin.Controls.MaterialLabel();
            this.TCtrlMain.SuspendLayout();
            this.TabSearch.SuspendLayout();
            this.PnlSearchPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSearchResult)).BeginInit();
            this.TabCreateEdit.SuspendLayout();
            this.TabCreate.SuspendLayout();
            this.PnlCustomer.SuspendLayout();
            this.PnlPerson.SuspendLayout();
            this.GrpType.SuspendLayout();
            this.PnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDegreeOfEmployment)).BeginInit();
            this.PnlTrainee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYearOfApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentAppYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).BeginInit();
            this.PnlSearchPreviewCustomer.SuspendLayout();
            this.PnlSearchPreviewEmployee.SuspendLayout();
            this.PnlSearchPreviewTrainee.SuspendLayout();
            this.PnlSearchPreviewGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TCtrlMain
            // 
            this.TCtrlMain.Controls.Add(this.TabSearch);
            this.TCtrlMain.Controls.Add(this.TabCreateEdit);
            this.TCtrlMain.Depth = 0;
            this.TCtrlMain.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCtrlMain.Location = new System.Drawing.Point(4, 71);
            this.TCtrlMain.Margin = new System.Windows.Forms.Padding(2);
            this.TCtrlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCtrlMain.Multiline = true;
            this.TCtrlMain.Name = "TCtrlMain";
            this.TCtrlMain.SelectedIndex = 0;
            this.TCtrlMain.Size = new System.Drawing.Size(1340, 639);
            this.TCtrlMain.TabIndex = 0;
            // 
            // TabSearch
            // 
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
            this.TabSearch.Controls.Add(this.PnlSearchPreview);
            this.TabSearch.Controls.Add(this.LblSearchResultCounter);
            this.TabSearch.Controls.Add(this.CmdQuickPersonCreate);
            this.TabSearch.Controls.Add(this.CmdQuickPersonDelete);
            this.TabSearch.Controls.Add(this.materialLabel1);
            this.TabSearch.Controls.Add(this.CmdSearchAdvanced);
            this.TabSearch.Controls.Add(this.CmdSearchExec2);
            this.TabSearch.Controls.Add(this.DataGridViewSearchResult);
            this.TabSearch.Controls.Add(this.txtOutput);
            this.TabSearch.Controls.Add(this.CmdExecSearch);
            this.TabSearch.Controls.Add(this.TxtSearch);
            this.TabSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabSearch.Location = new System.Drawing.Point(4, 34);
            this.TabSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TabSearch.Name = "TabSearch";
            this.TabSearch.Padding = new System.Windows.Forms.Padding(2);
            this.TabSearch.Size = new System.Drawing.Size(1332, 601);
            this.TabSearch.TabIndex = 0;
            this.TabSearch.Text = "Search";
            this.TabSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearchDateOfBirth
            // 
            this.TxtSearchDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchDateOfBirth.Depth = 0;
            this.TxtSearchDateOfBirth.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSearchDateOfBirth.Location = new System.Drawing.Point(510, 254);
            this.TxtSearchDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearchDateOfBirth.MaxLength = 50;
            this.TxtSearchDateOfBirth.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchDateOfBirth.Multiline = false;
            this.TxtSearchDateOfBirth.Name = "TxtSearchDateOfBirth";
            this.TxtSearchDateOfBirth.Size = new System.Drawing.Size(164, 50);
            this.TxtSearchDateOfBirth.TabIndex = 127;
            this.TxtSearchDateOfBirth.Text = "";
            // 
            // LblSearchDateOfBirth
            // 
            this.LblSearchDateOfBirth.AutoSize = true;
            this.LblSearchDateOfBirth.Depth = 0;
            this.LblSearchDateOfBirth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchDateOfBirth.Location = new System.Drawing.Point(510, 227);
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
            this.TxtSearchAddress.Location = new System.Drawing.Point(18, 254);
            this.TxtSearchAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearchAddress.MaxLength = 50;
            this.TxtSearchAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchAddress.Multiline = false;
            this.TxtSearchAddress.Name = "TxtSearchAddress";
            this.TxtSearchAddress.Size = new System.Drawing.Size(238, 50);
            this.TxtSearchAddress.TabIndex = 121;
            this.TxtSearchAddress.Text = "";
            // 
            // TxtSearchPlaceOfResidence
            // 
            this.TxtSearchPlaceOfResidence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchPlaceOfResidence.Depth = 0;
            this.TxtSearchPlaceOfResidence.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSearchPlaceOfResidence.Location = new System.Drawing.Point(275, 254);
            this.TxtSearchPlaceOfResidence.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearchPlaceOfResidence.MaxLength = 50;
            this.TxtSearchPlaceOfResidence.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchPlaceOfResidence.Multiline = false;
            this.TxtSearchPlaceOfResidence.Name = "TxtSearchPlaceOfResidence";
            this.TxtSearchPlaceOfResidence.Size = new System.Drawing.Size(210, 50);
            this.TxtSearchPlaceOfResidence.TabIndex = 123;
            this.TxtSearchPlaceOfResidence.Text = "";
            // 
            // LblSearchAddress
            // 
            this.LblSearchAddress.AutoSize = true;
            this.LblSearchAddress.Depth = 0;
            this.LblSearchAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchAddress.Location = new System.Drawing.Point(18, 231);
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
            this.LblSearchPlaceOfResidence.Location = new System.Drawing.Point(274, 227);
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
            this.ChkSearchInactive.Location = new System.Drawing.Point(513, 16);
            this.ChkSearchInactive.Margin = new System.Windows.Forms.Padding(0);
            this.ChkSearchInactive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkSearchInactive.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkSearchInactive.Name = "ChkSearchInactive";
            this.ChkSearchInactive.Ripple = true;
            this.ChkSearchInactive.Size = new System.Drawing.Size(145, 37);
            this.ChkSearchInactive.TabIndex = 120;
            this.ChkSearchInactive.Text = "Include inactive";
            this.ChkSearchInactive.UseVisualStyleBackColor = true;
            // 
            // ChkSearchTypeTrainee
            // 
            this.ChkSearchTypeTrainee.AutoSize = true;
            this.ChkSearchTypeTrainee.Checked = true;
            this.ChkSearchTypeTrainee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSearchTypeTrainee.Depth = 0;
            this.ChkSearchTypeTrainee.Location = new System.Drawing.Point(252, 62);
            this.ChkSearchTypeTrainee.Margin = new System.Windows.Forms.Padding(0);
            this.ChkSearchTypeTrainee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkSearchTypeTrainee.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkSearchTypeTrainee.Name = "ChkSearchTypeTrainee";
            this.ChkSearchTypeTrainee.Ripple = true;
            this.ChkSearchTypeTrainee.Size = new System.Drawing.Size(88, 37);
            this.ChkSearchTypeTrainee.TabIndex = 119;
            this.ChkSearchTypeTrainee.Text = "Trainee";
            this.ChkSearchTypeTrainee.UseVisualStyleBackColor = true;
            // 
            // ChkSearchTypeEmployee
            // 
            this.ChkSearchTypeEmployee.AutoSize = true;
            this.ChkSearchTypeEmployee.Checked = true;
            this.ChkSearchTypeEmployee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSearchTypeEmployee.Depth = 0;
            this.ChkSearchTypeEmployee.Location = new System.Drawing.Point(134, 62);
            this.ChkSearchTypeEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.ChkSearchTypeEmployee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkSearchTypeEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkSearchTypeEmployee.Name = "ChkSearchTypeEmployee";
            this.ChkSearchTypeEmployee.Ripple = true;
            this.ChkSearchTypeEmployee.Size = new System.Drawing.Size(104, 37);
            this.ChkSearchTypeEmployee.TabIndex = 118;
            this.ChkSearchTypeEmployee.Text = "Employee";
            this.ChkSearchTypeEmployee.UseVisualStyleBackColor = true;
            // 
            // ChkSearchTypeCustomer
            // 
            this.ChkSearchTypeCustomer.AutoSize = true;
            this.ChkSearchTypeCustomer.Checked = true;
            this.ChkSearchTypeCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSearchTypeCustomer.Depth = 0;
            this.ChkSearchTypeCustomer.Location = new System.Drawing.Point(18, 62);
            this.ChkSearchTypeCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.ChkSearchTypeCustomer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkSearchTypeCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkSearchTypeCustomer.Name = "ChkSearchTypeCustomer";
            this.ChkSearchTypeCustomer.Ripple = true;
            this.ChkSearchTypeCustomer.Size = new System.Drawing.Size(103, 37);
            this.ChkSearchTypeCustomer.TabIndex = 117;
            this.ChkSearchTypeCustomer.Text = "Customer";
            this.ChkSearchTypeCustomer.UseVisualStyleBackColor = true;
            // 
            // TxtSearchNumber
            // 
            this.TxtSearchNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchNumber.Depth = 0;
            this.TxtSearchNumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSearchNumber.Location = new System.Drawing.Point(483, 148);
            this.TxtSearchNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearchNumber.MaxLength = 50;
            this.TxtSearchNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchNumber.Multiline = false;
            this.TxtSearchNumber.Name = "TxtSearchNumber";
            this.TxtSearchNumber.Size = new System.Drawing.Size(123, 50);
            this.TxtSearchNumber.TabIndex = 116;
            this.TxtSearchNumber.Text = "";
            // 
            // LblSearchNumber
            // 
            this.LblSearchNumber.AutoSize = true;
            this.LblSearchNumber.Depth = 0;
            this.LblSearchNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchNumber.Location = new System.Drawing.Point(483, 122);
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
            this.LblSearchFirstName.Location = new System.Drawing.Point(19, 122);
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
            this.LblSearchLastName.Location = new System.Drawing.Point(252, 122);
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
            this.TxtSearchFirstName.Location = new System.Drawing.Point(18, 148);
            this.TxtSearchFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearchFirstName.MaxLength = 50;
            this.TxtSearchFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchFirstName.Multiline = false;
            this.TxtSearchFirstName.Name = "TxtSearchFirstName";
            this.TxtSearchFirstName.Size = new System.Drawing.Size(210, 50);
            this.TxtSearchFirstName.TabIndex = 111;
            this.TxtSearchFirstName.Text = "";
            // 
            // TxtSearchLastName
            // 
            this.TxtSearchLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchLastName.Depth = 0;
            this.TxtSearchLastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSearchLastName.Location = new System.Drawing.Point(251, 148);
            this.TxtSearchLastName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearchLastName.MaxLength = 50;
            this.TxtSearchLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSearchLastName.Multiline = false;
            this.TxtSearchLastName.Name = "TxtSearchLastName";
            this.TxtSearchLastName.Size = new System.Drawing.Size(210, 50);
            this.TxtSearchLastName.TabIndex = 112;
            this.TxtSearchLastName.Text = "";
            // 
            // PnlSearchPreview
            // 
            this.PnlSearchPreview.Controls.Add(this.LblSearchNotes);
            this.PnlSearchPreview.Controls.Add(this.LblSearchPreviewStatus);
            this.PnlSearchPreview.Controls.Add(this.dataGridView1);
            this.PnlSearchPreview.Controls.Add(this.PnlSearchPreviewGeneral);
            this.PnlSearchPreview.Controls.Add(this.PnlSearchPreviewTrainee);
            this.PnlSearchPreview.Controls.Add(this.LblSearchPreviewType);
            this.PnlSearchPreview.Controls.Add(this.LblSearchPreviewNumber);
            this.PnlSearchPreview.Controls.Add(this.CmdQuickPersonEdit);
            this.PnlSearchPreview.Controls.Add(this.PnlSearchPreviewCustomer);
            this.PnlSearchPreview.Controls.Add(this.PnlSearchPreviewEmployee);
            this.PnlSearchPreview.Location = new System.Drawing.Point(680, 5);
            this.PnlSearchPreview.Name = "PnlSearchPreview";
            this.PnlSearchPreview.Size = new System.Drawing.Size(634, 591);
            this.PnlSearchPreview.TabIndex = 107;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 14);
            this.label13.TabIndex = 118;
            this.label13.Text = "Business address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 14);
            this.label12.TabIndex = 117;
            this.label12.Text = "Email address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 14);
            this.label11.TabIndex = 116;
            this.label11.Text = "Business phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 14);
            this.label10.TabIndex = 115;
            this.label10.Text = "Private phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 14);
            this.label9.TabIndex = 114;
            this.label9.Text = "Date of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 113;
            this.label8.Text = "OASI number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 112;
            this.label7.Text = "Nationality";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 111;
            this.label6.Text = "Place of residence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 110;
            this.label5.Text = "Postal code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 109;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 108;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 107;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 14);
            this.label1.TabIndex = 106;
            this.label1.Text = "Title";
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
            // CmdQuickPersonEdit
            // 
            this.CmdQuickPersonEdit.AutoSize = false;
            this.CmdQuickPersonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdQuickPersonEdit.Depth = 0;
            this.CmdQuickPersonEdit.DrawShadows = true;
            this.CmdQuickPersonEdit.HighEmphasis = true;
            this.CmdQuickPersonEdit.Icon = null;
            this.CmdQuickPersonEdit.Location = new System.Drawing.Point(21, 269);
            this.CmdQuickPersonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdQuickPersonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdQuickPersonEdit.Name = "CmdQuickPersonEdit";
            this.CmdQuickPersonEdit.Size = new System.Drawing.Size(58, 30);
            this.CmdQuickPersonEdit.TabIndex = 105;
            this.CmdQuickPersonEdit.Text = "Edit";
            this.CmdQuickPersonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdQuickPersonEdit.UseAccentColor = false;
            this.CmdQuickPersonEdit.UseVisualStyleBackColor = true;
            // 
            // LblSearchResultCounter
            // 
            this.LblSearchResultCounter.AutoSize = true;
            this.LblSearchResultCounter.Depth = 0;
            this.LblSearchResultCounter.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchResultCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSearchResultCounter.Location = new System.Drawing.Point(19, 579);
            this.LblSearchResultCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchResultCounter.Name = "LblSearchResultCounter";
            this.LblSearchResultCounter.Size = new System.Drawing.Size(70, 19);
            this.LblSearchResultCounter.TabIndex = 106;
            this.LblSearchResultCounter.Text = "Results: 0";
            // 
            // CmdQuickPersonCreate
            // 
            this.CmdQuickPersonCreate.AutoSize = false;
            this.CmdQuickPersonCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdQuickPersonCreate.Depth = 0;
            this.CmdQuickPersonCreate.DrawShadows = true;
            this.CmdQuickPersonCreate.HighEmphasis = true;
            this.CmdQuickPersonCreate.Icon = null;
            this.CmdQuickPersonCreate.Location = new System.Drawing.Point(22, 340);
            this.CmdQuickPersonCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdQuickPersonCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdQuickPersonCreate.Name = "CmdQuickPersonCreate";
            this.CmdQuickPersonCreate.Size = new System.Drawing.Size(30, 30);
            this.CmdQuickPersonCreate.TabIndex = 103;
            this.CmdQuickPersonCreate.Text = "+";
            this.CmdQuickPersonCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdQuickPersonCreate.UseAccentColor = false;
            this.CmdQuickPersonCreate.UseVisualStyleBackColor = true;
            // 
            // CmdQuickPersonDelete
            // 
            this.CmdQuickPersonDelete.AutoSize = false;
            this.CmdQuickPersonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdQuickPersonDelete.Depth = 0;
            this.CmdQuickPersonDelete.DrawShadows = true;
            this.CmdQuickPersonDelete.HighEmphasis = true;
            this.CmdQuickPersonDelete.Icon = null;
            this.CmdQuickPersonDelete.Location = new System.Drawing.Point(56, 340);
            this.CmdQuickPersonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdQuickPersonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdQuickPersonDelete.Name = "CmdQuickPersonDelete";
            this.CmdQuickPersonDelete.Size = new System.Drawing.Size(30, 30);
            this.CmdQuickPersonDelete.TabIndex = 104;
            this.CmdQuickPersonDelete.Text = "-";
            this.CmdQuickPersonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdQuickPersonDelete.UseAccentColor = false;
            this.CmdQuickPersonDelete.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 24);
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
            this.CmdSearchAdvanced.Location = new System.Drawing.Point(410, 69);
            this.CmdSearchAdvanced.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchAdvanced.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchAdvanced.Name = "CmdSearchAdvanced";
            this.CmdSearchAdvanced.Size = new System.Drawing.Size(84, 30);
            this.CmdSearchAdvanced.TabIndex = 101;
            this.CmdSearchAdvanced.Text = "Advanced";
            this.CmdSearchAdvanced.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchAdvanced.UseAccentColor = false;
            this.CmdSearchAdvanced.UseVisualStyleBackColor = true;
            // 
            // CmdSearchExec2
            // 
            this.CmdSearchExec2.AutoSize = false;
            this.CmdSearchExec2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSearchExec2.Depth = 0;
            this.CmdSearchExec2.DrawShadows = true;
            this.CmdSearchExec2.HighEmphasis = true;
            this.CmdSearchExec2.Icon = null;
            this.CmdSearchExec2.Location = new System.Drawing.Point(410, 12);
            this.CmdSearchExec2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdSearchExec2.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSearchExec2.Name = "CmdSearchExec2";
            this.CmdSearchExec2.Size = new System.Drawing.Size(87, 42);
            this.CmdSearchExec2.TabIndex = 100;
            this.CmdSearchExec2.Text = "Search";
            this.CmdSearchExec2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdSearchExec2.UseAccentColor = false;
            this.CmdSearchExec2.UseVisualStyleBackColor = true;
            // 
            // DataGridViewSearchResult
            // 
            this.DataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSearchResult.Location = new System.Drawing.Point(22, 374);
            this.DataGridViewSearchResult.Name = "DataGridViewSearchResult";
            this.DataGridViewSearchResult.Size = new System.Drawing.Size(652, 198);
            this.DataGridViewSearchResult.TabIndex = 5;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(150, 309);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(508, 18);
            this.txtOutput.TabIndex = 4;
            // 
            // CmdExecSearch
            // 
            this.CmdExecSearch.Location = new System.Drawing.Point(513, 76);
            this.CmdExecSearch.Name = "CmdExecSearch";
            this.CmdExecSearch.Size = new System.Drawing.Size(75, 23);
            this.CmdExecSearch.TabIndex = 3;
            this.CmdExecSearch.Text = "Search";
            this.CmdExecSearch.UseVisualStyleBackColor = true;
            this.CmdExecSearch.Click += new System.EventHandler(this.CmdExecSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(150, 24);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(244, 20);
            this.TxtSearch.TabIndex = 2;
            // 
            // TabCreateEdit
            // 
            this.TabCreateEdit.Controls.Add(this.TabCreate);
            this.TabCreateEdit.Location = new System.Drawing.Point(4, 34);
            this.TabCreateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TabCreateEdit.Name = "TabCreateEdit";
            this.TabCreateEdit.Padding = new System.Windows.Forms.Padding(2);
            this.TabCreateEdit.Size = new System.Drawing.Size(1332, 601);
            this.TabCreateEdit.TabIndex = 1;
            this.TabCreateEdit.Text = "Create";
            this.TabCreateEdit.UseVisualStyleBackColor = true;
            // 
            // TabCreate
            // 
            this.TabCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabCreate.Controls.Add(this.PnlCustomer);
            this.TabCreate.Controls.Add(this.CmdNoteEdit);
            this.TabCreate.Controls.Add(this.LblNotes);
            this.TabCreate.Controls.Add(this.CmdNoteAdd);
            this.TabCreate.Controls.Add(this.CmdNoteDelete);
            this.TabCreate.Controls.Add(this.LstNoteOut);
            this.TabCreate.Controls.Add(this.CmdNotesAll);
            this.TabCreate.Controls.Add(this.CmdCancel);
            this.TabCreate.Controls.Add(this.CmdCreatePersonAndNew);
            this.TabCreate.Controls.Add(this.LblTypeSelection);
            this.TabCreate.Controls.Add(this.PnlPerson);
            this.TabCreate.Controls.Add(this.CmdCreatePerson);
            this.TabCreate.Controls.Add(this.PnlEmployee);
            this.TabCreate.Depth = 0;
            this.TabCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabCreate.Location = new System.Drawing.Point(0, 0);
            this.TabCreate.Margin = new System.Windows.Forms.Padding(9);
            this.TabCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabCreate.Name = "TabCreate";
            this.TabCreate.Padding = new System.Windows.Forms.Padding(9);
            this.TabCreate.Size = new System.Drawing.Size(1330, 620);
            this.TabCreate.TabIndex = 59;
            // 
            // PnlCustomer
            // 
            this.PnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCustomer.Controls.Add(this.TxtCustomerNumber);
            this.PnlCustomer.Controls.Add(this.LblCustomerNumber);
            this.PnlCustomer.Controls.Add(this.LblCompanyName);
            this.PnlCustomer.Controls.Add(this.CmbCustomerType);
            this.PnlCustomer.Controls.Add(this.TxtCompanyName);
            this.PnlCustomer.Controls.Add(this.LblCustomerType);
            this.PnlCustomer.Controls.Add(this.LblCompanyContact);
            this.PnlCustomer.Controls.Add(this.TxtCompanyContact);
            this.PnlCustomer.Location = new System.Drawing.Point(637, 5);
            this.PnlCustomer.Name = "PnlCustomer";
            this.PnlCustomer.Size = new System.Drawing.Size(692, 178);
            this.PnlCustomer.TabIndex = 85;
            // 
            // TxtCustomerNumber
            // 
            this.TxtCustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCustomerNumber.Depth = 0;
            this.TxtCustomerNumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCustomerNumber.Location = new System.Drawing.Point(148, 13);
            this.TxtCustomerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerNumber.MaxLength = 50;
            this.TxtCustomerNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCustomerNumber.Multiline = false;
            this.TxtCustomerNumber.Name = "TxtCustomerNumber";
            this.TxtCustomerNumber.Size = new System.Drawing.Size(123, 50);
            this.TxtCustomerNumber.TabIndex = 35;
            this.TxtCustomerNumber.Text = "";
            // 
            // LblCustomerNumber
            // 
            this.LblCustomerNumber.AutoSize = true;
            this.LblCustomerNumber.Depth = 0;
            this.LblCustomerNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCustomerNumber.Location = new System.Drawing.Point(10, 26);
            this.LblCustomerNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCustomerNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCustomerNumber.Name = "LblCustomerNumber";
            this.LblCustomerNumber.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCustomerNumber.Size = new System.Drawing.Size(127, 19);
            this.LblCustomerNumber.TabIndex = 34;
            this.LblCustomerNumber.Text = "Customer number";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Depth = 0;
            this.LblCompanyName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCompanyName.Location = new System.Drawing.Point(10, 92);
            this.LblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCompanyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCompanyName.Size = new System.Drawing.Size(120, 19);
            this.LblCompanyName.TabIndex = 30;
            this.LblCompanyName.Text = "Company name*";
            // 
            // CmbCustomerType
            // 
            this.CmbCustomerType.AutoResize = false;
            this.CmbCustomerType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbCustomerType.Depth = 0;
            this.CmbCustomerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbCustomerType.DropDownHeight = 174;
            this.CmbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCustomerType.DropDownWidth = 121;
            this.CmbCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbCustomerType.FormattingEnabled = true;
            this.CmbCustomerType.IntegralHeight = false;
            this.CmbCustomerType.ItemHeight = 43;
            this.CmbCustomerType.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.CmbCustomerType.Location = new System.Drawing.Point(454, 12);
            this.CmbCustomerType.MaxDropDownItems = 4;
            this.CmbCustomerType.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbCustomerType.Name = "CmbCustomerType";
            this.CmbCustomerType.Size = new System.Drawing.Size(76, 49);
            this.CmbCustomerType.StartIndex = 0;
            this.CmbCustomerType.TabIndex = 33;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCompanyName.Depth = 0;
            this.TxtCompanyName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCompanyName.Location = new System.Drawing.Point(10, 118);
            this.TxtCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCompanyName.MaxLength = 50;
            this.TxtCompanyName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCompanyName.Multiline = false;
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(262, 50);
            this.TxtCompanyName.TabIndex = 31;
            this.TxtCompanyName.Text = "";
            // 
            // LblCustomerType
            // 
            this.LblCustomerType.AutoSize = true;
            this.LblCustomerType.Depth = 0;
            this.LblCustomerType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCustomerType.Location = new System.Drawing.Point(292, 25);
            this.LblCustomerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCustomerType.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCustomerType.Name = "LblCustomerType";
            this.LblCustomerType.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCustomerType.Size = new System.Drawing.Size(148, 19);
            this.LblCustomerType.TabIndex = 32;
            this.LblCustomerType.Text = "Customer type* (A-E)";
            // 
            // LblCompanyContact
            // 
            this.LblCompanyContact.AutoSize = true;
            this.LblCompanyContact.Depth = 0;
            this.LblCompanyContact.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCompanyContact.Location = new System.Drawing.Point(292, 91);
            this.LblCompanyContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCompanyContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCompanyContact.Name = "LblCompanyContact";
            this.LblCompanyContact.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCompanyContact.Size = new System.Drawing.Size(133, 19);
            this.LblCompanyContact.TabIndex = 33;
            this.LblCompanyContact.Text = "Company contact*";
            // 
            // TxtCompanyContact
            // 
            this.TxtCompanyContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCompanyContact.Depth = 0;
            this.TxtCompanyContact.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCompanyContact.Location = new System.Drawing.Point(291, 118);
            this.TxtCompanyContact.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCompanyContact.MaxLength = 50;
            this.TxtCompanyContact.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCompanyContact.Multiline = false;
            this.TxtCompanyContact.Name = "TxtCompanyContact";
            this.TxtCompanyContact.Size = new System.Drawing.Size(239, 50);
            this.TxtCompanyContact.TabIndex = 32;
            this.TxtCompanyContact.Text = "";
            // 
            // CmdNoteEdit
            // 
            this.CmdNoteEdit.AutoSize = false;
            this.CmdNoteEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdNoteEdit.Depth = 0;
            this.CmdNoteEdit.DrawShadows = true;
            this.CmdNoteEdit.HighEmphasis = true;
            this.CmdNoteEdit.Icon = null;
            this.CmdNoteEdit.Location = new System.Drawing.Point(704, 546);
            this.CmdNoteEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdNoteEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdNoteEdit.Name = "CmdNoteEdit";
            this.CmdNoteEdit.Size = new System.Drawing.Size(30, 30);
            this.CmdNoteEdit.TabIndex = 97;
            this.CmdNoteEdit.Text = "✎";
            this.CmdNoteEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdNoteEdit.UseAccentColor = false;
            this.CmdNoteEdit.UseVisualStyleBackColor = true;
            // 
            // LblNotes
            // 
            this.LblNotes.AutoSize = true;
            this.LblNotes.Depth = 0;
            this.LblNotes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblNotes.Location = new System.Drawing.Point(639, 360);
            this.LblNotes.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNotes.Name = "LblNotes";
            this.LblNotes.Size = new System.Drawing.Size(42, 19);
            this.LblNotes.TabIndex = 93;
            this.LblNotes.Text = "Notes";
            // 
            // CmdNoteAdd
            // 
            this.CmdNoteAdd.AutoSize = false;
            this.CmdNoteAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdNoteAdd.Depth = 0;
            this.CmdNoteAdd.DrawShadows = true;
            this.CmdNoteAdd.HighEmphasis = true;
            this.CmdNoteAdd.Icon = null;
            this.CmdNoteAdd.Location = new System.Drawing.Point(636, 546);
            this.CmdNoteAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdNoteAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdNoteAdd.Name = "CmdNoteAdd";
            this.CmdNoteAdd.Size = new System.Drawing.Size(30, 30);
            this.CmdNoteAdd.TabIndex = 95;
            this.CmdNoteAdd.Text = "+";
            this.CmdNoteAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdNoteAdd.UseAccentColor = false;
            this.CmdNoteAdd.UseVisualStyleBackColor = true;
            // 
            // CmdNoteDelete
            // 
            this.CmdNoteDelete.AutoSize = false;
            this.CmdNoteDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdNoteDelete.Depth = 0;
            this.CmdNoteDelete.DrawShadows = true;
            this.CmdNoteDelete.HighEmphasis = true;
            this.CmdNoteDelete.Icon = null;
            this.CmdNoteDelete.Location = new System.Drawing.Point(670, 546);
            this.CmdNoteDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdNoteDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdNoteDelete.Name = "CmdNoteDelete";
            this.CmdNoteDelete.Size = new System.Drawing.Size(30, 30);
            this.CmdNoteDelete.TabIndex = 96;
            this.CmdNoteDelete.Text = "-";
            this.CmdNoteDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdNoteDelete.UseAccentColor = false;
            this.CmdNoteDelete.UseVisualStyleBackColor = true;
            // 
            // LstNoteOut
            // 
            this.LstNoteOut.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstNoteOut.FormattingEnabled = true;
            this.LstNoteOut.ItemHeight = 20;
            this.LstNoteOut.Location = new System.Drawing.Point(636, 380);
            this.LstNoteOut.Name = "LstNoteOut";
            this.LstNoteOut.Size = new System.Drawing.Size(691, 164);
            this.LstNoteOut.TabIndex = 31;
            // 
            // CmdNotesAll
            // 
            this.CmdNotesAll.AutoSize = false;
            this.CmdNotesAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdNotesAll.Depth = 0;
            this.CmdNotesAll.DrawShadows = true;
            this.CmdNotesAll.HighEmphasis = true;
            this.CmdNotesAll.Icon = null;
            this.CmdNotesAll.Location = new System.Drawing.Point(965, 471);
            this.CmdNotesAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdNotesAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdNotesAll.Name = "CmdNotesAll";
            this.CmdNotesAll.Size = new System.Drawing.Size(29, 26);
            this.CmdNotesAll.TabIndex = 89;
            this.CmdNotesAll.Text = "✎";
            this.CmdNotesAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdNotesAll.UseAccentColor = false;
            this.CmdNotesAll.UseVisualStyleBackColor = true;
            // 
            // CmdCancel
            // 
            this.CmdCancel.AutoSize = false;
            this.CmdCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdCancel.Depth = 0;
            this.CmdCancel.DrawShadows = true;
            this.CmdCancel.HighEmphasis = true;
            this.CmdCancel.Icon = null;
            this.CmdCancel.Location = new System.Drawing.Point(1238, 551);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(88, 44);
            this.CmdCancel.TabIndex = 100;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdCancel.UseAccentColor = false;
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdCreatePersonAndNew
            // 
            this.CmdCreatePersonAndNew.AutoSize = false;
            this.CmdCreatePersonAndNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdCreatePersonAndNew.Depth = 0;
            this.CmdCreatePersonAndNew.DrawShadows = true;
            this.CmdCreatePersonAndNew.HighEmphasis = true;
            this.CmdCreatePersonAndNew.Icon = null;
            this.CmdCreatePersonAndNew.Location = new System.Drawing.Point(1117, 551);
            this.CmdCreatePersonAndNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdCreatePersonAndNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCreatePersonAndNew.Name = "CmdCreatePersonAndNew";
            this.CmdCreatePersonAndNew.Size = new System.Drawing.Size(115, 44);
            this.CmdCreatePersonAndNew.TabIndex = 99;
            this.CmdCreatePersonAndNew.Text = "Save & New";
            this.CmdCreatePersonAndNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdCreatePersonAndNew.UseAccentColor = false;
            this.CmdCreatePersonAndNew.UseVisualStyleBackColor = true;
            // 
            // LblTypeSelection
            // 
            this.LblTypeSelection.AutoSize = true;
            this.LblTypeSelection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblTypeSelection.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTypeSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblTypeSelection.Location = new System.Drawing.Point(850, 200);
            this.LblTypeSelection.Name = "LblTypeSelection";
            this.LblTypeSelection.Size = new System.Drawing.Size(331, 37);
            this.LblTypeSelection.TabIndex = 86;
            this.LblTypeSelection.Text = "Please select a contact type.";
            // 
            // PnlPerson
            // 
            this.PnlPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPerson.Controls.Add(this.GrpType);
            this.PnlPerson.Controls.Add(this.RadOther);
            this.PnlPerson.Controls.Add(this.RadFemale);
            this.PnlPerson.Controls.Add(this.RadMale);
            this.PnlPerson.Controls.Add(this.SwtActive);
            this.PnlPerson.Controls.Add(this.LblOasiNr);
            this.PnlPerson.Controls.Add(this.DatBirthday);
            this.PnlPerson.Controls.Add(this.TxtPlz);
            this.PnlPerson.Controls.Add(this.CmbSalutation);
            this.PnlPerson.Controls.Add(this.TxtAddress);
            this.PnlPerson.Controls.Add(this.LblSalutation);
            this.PnlPerson.Controls.Add(this.TxtOasiNr);
            this.PnlPerson.Controls.Add(this.TxtPlaceOfResidence);
            this.PnlPerson.Controls.Add(this.CmbNationality);
            this.PnlPerson.Controls.Add(this.TxtTitle);
            this.PnlPerson.Controls.Add(this.TxtBusinessAddress);
            this.PnlPerson.Controls.Add(this.LblFirstName);
            this.PnlPerson.Controls.Add(this.LblBusinessAddress);
            this.PnlPerson.Controls.Add(this.LblPLZ);
            this.PnlPerson.Controls.Add(this.LblLastName);
            this.PnlPerson.Controls.Add(this.LblAddress);
            this.PnlPerson.Controls.Add(this.TxtFirstName);
            this.PnlPerson.Controls.Add(this.LblNationality);
            this.PnlPerson.Controls.Add(this.TxtLastName);
            this.PnlPerson.Controls.Add(this.LblPlaceOfResidence);
            this.PnlPerson.Controls.Add(this.LblDateOfBirth);
            this.PnlPerson.Controls.Add(this.LblTitle);
            this.PnlPerson.Controls.Add(this.LblEmailAddress);
            this.PnlPerson.Controls.Add(this.TxtEmailAddress);
            this.PnlPerson.Controls.Add(this.LblBusnissPhone);
            this.PnlPerson.Controls.Add(this.TxtBusnissPhone);
            this.PnlPerson.Controls.Add(this.LblPrivatePhone);
            this.PnlPerson.Controls.Add(this.TxtPrivatePhone);
            this.PnlPerson.Location = new System.Drawing.Point(5, 5);
            this.PnlPerson.Name = "PnlPerson";
            this.PnlPerson.Size = new System.Drawing.Size(616, 591);
            this.PnlPerson.TabIndex = 82;
            // 
            // GrpType
            // 
            this.GrpType.Controls.Add(this.RadEmployee);
            this.GrpType.Controls.Add(this.RadCustomer);
            this.GrpType.Controls.Add(this.ChkTrainee);
            this.GrpType.Location = new System.Drawing.Point(430, 372);
            this.GrpType.Name = "GrpType";
            this.GrpType.Size = new System.Drawing.Size(172, 182);
            this.GrpType.TabIndex = 79;
            this.GrpType.TabStop = false;
            this.GrpType.Text = "Type*";
            // 
            // RadEmployee
            // 
            this.RadEmployee.AutoSize = true;
            this.RadEmployee.Depth = 0;
            this.RadEmployee.Location = new System.Drawing.Point(25, 88);
            this.RadEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.RadEmployee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadEmployee.Name = "RadEmployee";
            this.RadEmployee.Ripple = true;
            this.RadEmployee.Size = new System.Drawing.Size(104, 37);
            this.RadEmployee.TabIndex = 20;
            this.RadEmployee.TabStop = true;
            this.RadEmployee.Text = "Employee";
            this.RadEmployee.UseVisualStyleBackColor = true;
            this.RadEmployee.CheckedChanged += new System.EventHandler(this.RadEmployee_CheckedChanged);
            // 
            // RadCustomer
            // 
            this.RadCustomer.AutoSize = true;
            this.RadCustomer.Depth = 0;
            this.RadCustomer.Location = new System.Drawing.Point(25, 41);
            this.RadCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.RadCustomer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadCustomer.Name = "RadCustomer";
            this.RadCustomer.Ripple = true;
            this.RadCustomer.Size = new System.Drawing.Size(103, 37);
            this.RadCustomer.TabIndex = 19;
            this.RadCustomer.TabStop = true;
            this.RadCustomer.Text = "Customer";
            this.RadCustomer.UseVisualStyleBackColor = true;
            this.RadCustomer.CheckedChanged += new System.EventHandler(this.RadCustomer_CheckedChanged);
            // 
            // ChkTrainee
            // 
            this.ChkTrainee.AutoSize = true;
            this.ChkTrainee.Depth = 0;
            this.ChkTrainee.Location = new System.Drawing.Point(53, 126);
            this.ChkTrainee.Margin = new System.Windows.Forms.Padding(0);
            this.ChkTrainee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkTrainee.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkTrainee.Name = "ChkTrainee";
            this.ChkTrainee.Ripple = true;
            this.ChkTrainee.Size = new System.Drawing.Size(88, 37);
            this.ChkTrainee.TabIndex = 21;
            this.ChkTrainee.Text = "Trainee";
            this.ChkTrainee.UseVisualStyleBackColor = true;
            this.ChkTrainee.CheckedChanged += new System.EventHandler(this.ChkTrainee_CheckedChanged);
            // 
            // RadOther
            // 
            this.RadOther.AutoSize = true;
            this.RadOther.Depth = 0;
            this.RadOther.Location = new System.Drawing.Point(309, 22);
            this.RadOther.Margin = new System.Windows.Forms.Padding(0);
            this.RadOther.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadOther.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadOther.Name = "RadOther";
            this.RadOther.Ripple = true;
            this.RadOther.Size = new System.Drawing.Size(73, 37);
            this.RadOther.TabIndex = 4;
            this.RadOther.TabStop = true;
            this.RadOther.Text = "Other";
            this.RadOther.UseVisualStyleBackColor = true;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Depth = 0;
            this.RadFemale.Location = new System.Drawing.Point(145, 22);
            this.RadFemale.Margin = new System.Windows.Forms.Padding(0);
            this.RadFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Ripple = true;
            this.RadFemale.Size = new System.Drawing.Size(87, 37);
            this.RadFemale.TabIndex = 2;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Depth = 0;
            this.RadMale.Location = new System.Drawing.Point(236, 22);
            this.RadMale.Margin = new System.Windows.Forms.Padding(0);
            this.RadMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadMale.Name = "RadMale";
            this.RadMale.Ripple = true;
            this.RadMale.Size = new System.Drawing.Size(70, 37);
            this.RadMale.TabIndex = 3;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // SwtActive
            // 
            this.SwtActive.AutoSize = true;
            this.SwtActive.Checked = true;
            this.SwtActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SwtActive.Depth = 0;
            this.SwtActive.Location = new System.Drawing.Point(11, 23);
            this.SwtActive.Margin = new System.Windows.Forms.Padding(0);
            this.SwtActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwtActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwtActive.Name = "SwtActive";
            this.SwtActive.Ripple = true;
            this.SwtActive.Size = new System.Drawing.Size(101, 37);
            this.SwtActive.TabIndex = 1;
            this.SwtActive.Text = "Active";
            this.SwtActive.UseVisualStyleBackColor = true;
            // 
            // LblOasiNr
            // 
            this.LblOasiNr.AutoSize = true;
            this.LblOasiNr.Depth = 0;
            this.LblOasiNr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblOasiNr.Location = new System.Drawing.Point(250, 273);
            this.LblOasiNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOasiNr.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblOasiNr.Name = "LblOasiNr";
            this.LblOasiNr.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblOasiNr.Size = new System.Drawing.Size(94, 19);
            this.LblOasiNr.TabIndex = 16;
            this.LblOasiNr.Text = "OASI number";
            // 
            // DatBirthday
            // 
            this.DatBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatBirthday.CustomFormat = "HTML Format";
            this.DatBirthday.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatBirthday.Location = new System.Drawing.Point(480, 300);
            this.DatBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.DatBirthday.Name = "DatBirthday";
            this.DatBirthday.Size = new System.Drawing.Size(114, 29);
            this.DatBirthday.TabIndex = 14;
            this.DatBirthday.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // TxtPlz
            // 
            this.TxtPlz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPlz.Depth = 0;
            this.TxtPlz.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtPlz.Location = new System.Drawing.Point(276, 207);
            this.TxtPlz.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPlz.MaxLength = 50;
            this.TxtPlz.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPlz.Multiline = false;
            this.TxtPlz.Name = "TxtPlz";
            this.TxtPlz.Size = new System.Drawing.Size(96, 50);
            this.TxtPlz.TabIndex = 10;
            this.TxtPlz.Text = "";
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.AutoResize = false;
            this.CmbSalutation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbSalutation.Depth = 0;
            this.CmbSalutation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbSalutation.DropDownHeight = 174;
            this.CmbSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSalutation.DropDownWidth = 121;
            this.CmbSalutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbSalutation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.IntegralHeight = false;
            this.CmbSalutation.ItemHeight = 43;
            this.CmbSalutation.Items.AddRange(new object[] {
            "Ms",
            "Mr",
            "Mx"});
            this.CmbSalutation.Location = new System.Drawing.Point(526, 20);
            this.CmbSalutation.MaxDropDownItems = 4;
            this.CmbSalutation.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(76, 49);
            this.CmbSalutation.StartIndex = 0;
            this.CmbSalutation.TabIndex = 5;
            // 
            // TxtAddress
            // 
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAddress.Depth = 0;
            this.TxtAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtAddress.Location = new System.Drawing.Point(17, 207);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAddress.MaxLength = 50;
            this.TxtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtAddress.Multiline = false;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(238, 50);
            this.TxtAddress.TabIndex = 9;
            this.TxtAddress.Text = "";
            // 
            // LblSalutation
            // 
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.Depth = 0;
            this.LblSalutation.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSalutation.Location = new System.Drawing.Point(427, 32);
            this.LblSalutation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSalutation.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblSalutation.Size = new System.Drawing.Size(74, 19);
            this.LblSalutation.TabIndex = 42;
            this.LblSalutation.Text = "Salutation";
            // 
            // TxtOasiNr
            // 
            this.TxtOasiNr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOasiNr.Depth = 0;
            this.TxtOasiNr.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtOasiNr.Location = new System.Drawing.Point(249, 299);
            this.TxtOasiNr.Margin = new System.Windows.Forms.Padding(2);
            this.TxtOasiNr.MaxLength = 50;
            this.TxtOasiNr.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtOasiNr.Multiline = false;
            this.TxtOasiNr.Name = "TxtOasiNr";
            this.TxtOasiNr.Size = new System.Drawing.Size(212, 50);
            this.TxtOasiNr.TabIndex = 13;
            this.TxtOasiNr.Text = "";
            // 
            // TxtPlaceOfResidence
            // 
            this.TxtPlaceOfResidence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPlaceOfResidence.Depth = 0;
            this.TxtPlaceOfResidence.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtPlaceOfResidence.Location = new System.Drawing.Point(393, 207);
            this.TxtPlaceOfResidence.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPlaceOfResidence.MaxLength = 50;
            this.TxtPlaceOfResidence.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPlaceOfResidence.Multiline = false;
            this.TxtPlaceOfResidence.Name = "TxtPlaceOfResidence";
            this.TxtPlaceOfResidence.Size = new System.Drawing.Size(210, 50);
            this.TxtPlaceOfResidence.TabIndex = 11;
            this.TxtPlaceOfResidence.Text = "";
            // 
            // CmbNationality
            // 
            this.CmbNationality.AutoResize = false;
            this.CmbNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbNationality.Depth = 0;
            this.CmbNationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbNationality.DropDownHeight = 174;
            this.CmbNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNationality.DropDownWidth = 121;
            this.CmbNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbNationality.FormattingEnabled = true;
            this.CmbNationality.IntegralHeight = false;
            this.CmbNationality.ItemHeight = 43;
            this.CmbNationality.Location = new System.Drawing.Point(15, 300);
            this.CmbNationality.MaxDropDownItems = 4;
            this.CmbNationality.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbNationality.Name = "CmbNationality";
            this.CmbNationality.Size = new System.Drawing.Size(217, 49);
            this.CmbNationality.StartIndex = 0;
            this.CmbNationality.TabIndex = 12;
            // 
            // TxtTitle
            // 
            this.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTitle.Depth = 0;
            this.TxtTitle.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtTitle.Location = new System.Drawing.Point(18, 117);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTitle.MaxLength = 50;
            this.TxtTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtTitle.Multiline = false;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(116, 50);
            this.TxtTitle.TabIndex = 6;
            this.TxtTitle.Text = "";
            // 
            // TxtBusinessAddress
            // 
            this.TxtBusinessAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBusinessAddress.Depth = 0;
            this.TxtBusinessAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtBusinessAddress.Location = new System.Drawing.Point(222, 504);
            this.TxtBusinessAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBusinessAddress.MaxLength = 50;
            this.TxtBusinessAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBusinessAddress.Multiline = false;
            this.TxtBusinessAddress.Name = "TxtBusinessAddress";
            this.TxtBusinessAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TxtBusinessAddress.Size = new System.Drawing.Size(175, 50);
            this.TxtBusinessAddress.TabIndex = 18;
            this.TxtBusinessAddress.Text = "";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Depth = 0;
            this.LblFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblFirstName.Location = new System.Drawing.Point(160, 91);
            this.LblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblFirstName.Size = new System.Drawing.Size(83, 19);
            this.LblFirstName.TabIndex = 43;
            this.LblFirstName.Text = "First name*";
            // 
            // LblBusinessAddress
            // 
            this.LblBusinessAddress.AutoSize = true;
            this.LblBusinessAddress.Depth = 0;
            this.LblBusinessAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblBusinessAddress.Location = new System.Drawing.Point(228, 477);
            this.LblBusinessAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBusinessAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBusinessAddress.Name = "LblBusinessAddress";
            this.LblBusinessAddress.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblBusinessAddress.Size = new System.Drawing.Size(125, 19);
            this.LblBusinessAddress.TabIndex = 31;
            this.LblBusinessAddress.Text = "Business address";
            // 
            // LblPLZ
            // 
            this.LblPLZ.AutoSize = true;
            this.LblPLZ.Depth = 0;
            this.LblPLZ.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblPLZ.Location = new System.Drawing.Point(277, 180);
            this.LblPLZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPLZ.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPLZ.Name = "LblPLZ";
            this.LblPLZ.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblPLZ.Size = new System.Drawing.Size(91, 19);
            this.LblPLZ.TabIndex = 68;
            this.LblPLZ.Text = "Postal code*";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Depth = 0;
            this.LblLastName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblLastName.Location = new System.Drawing.Point(393, 91);
            this.LblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblLastName.Size = new System.Drawing.Size(83, 19);
            this.LblLastName.TabIndex = 44;
            this.LblLastName.Text = "Last name*";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Depth = 0;
            this.LblAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblAddress.Location = new System.Drawing.Point(17, 184);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblAddress.Size = new System.Drawing.Size(65, 19);
            this.LblAddress.TabIndex = 67;
            this.LblAddress.Text = "Address*";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFirstName.Depth = 0;
            this.TxtFirstName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtFirstName.Location = new System.Drawing.Point(159, 117);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFirstName.MaxLength = 50;
            this.TxtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtFirstName.Multiline = false;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(210, 50);
            this.TxtFirstName.TabIndex = 7;
            this.TxtFirstName.Text = "";
            // 
            // LblNationality
            // 
            this.LblNationality.AutoSize = true;
            this.LblNationality.Depth = 0;
            this.LblNationality.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblNationality.Location = new System.Drawing.Point(15, 275);
            this.LblNationality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNationality.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNationality.Name = "LblNationality";
            this.LblNationality.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblNationality.Size = new System.Drawing.Size(78, 19);
            this.LblNationality.TabIndex = 66;
            this.LblNationality.Text = "Nationality";
            // 
            // TxtLastName
            // 
            this.TxtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLastName.Depth = 0;
            this.TxtLastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtLastName.Location = new System.Drawing.Point(392, 117);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLastName.MaxLength = 50;
            this.TxtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtLastName.Multiline = false;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(210, 50);
            this.TxtLastName.TabIndex = 8;
            this.TxtLastName.Text = "";
            // 
            // LblPlaceOfResidence
            // 
            this.LblPlaceOfResidence.AutoSize = true;
            this.LblPlaceOfResidence.Depth = 0;
            this.LblPlaceOfResidence.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblPlaceOfResidence.Location = new System.Drawing.Point(392, 180);
            this.LblPlaceOfResidence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPlaceOfResidence.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPlaceOfResidence.Name = "LblPlaceOfResidence";
            this.LblPlaceOfResidence.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblPlaceOfResidence.Size = new System.Drawing.Size(130, 19);
            this.LblPlaceOfResidence.TabIndex = 65;
            this.LblPlaceOfResidence.Text = "Place of residence";
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Depth = 0;
            this.LblDateOfBirth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblDateOfBirth.Location = new System.Drawing.Point(479, 275);
            this.LblDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDateOfBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblDateOfBirth.Size = new System.Drawing.Size(96, 19);
            this.LblDateOfBirth.TabIndex = 62;
            this.LblDateOfBirth.Text = "Date of birth*";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Depth = 0;
            this.LblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblTitle.Location = new System.Drawing.Point(17, 90);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblTitle.Size = new System.Drawing.Size(32, 19);
            this.LblTitle.TabIndex = 63;
            this.LblTitle.Text = "Title";
            // 
            // LblEmailAddress
            // 
            this.LblEmailAddress.AutoSize = true;
            this.LblEmailAddress.Depth = 0;
            this.LblEmailAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblEmailAddress.Location = new System.Drawing.Point(223, 379);
            this.LblEmailAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmailAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEmailAddress.Name = "LblEmailAddress";
            this.LblEmailAddress.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblEmailAddress.Size = new System.Drawing.Size(108, 19);
            this.LblEmailAddress.TabIndex = 75;
            this.LblEmailAddress.Text = "Email address*";
            // 
            // TxtEmailAddress
            // 
            this.TxtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmailAddress.Depth = 0;
            this.TxtEmailAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtEmailAddress.Location = new System.Drawing.Point(223, 407);
            this.TxtEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmailAddress.MaxLength = 50;
            this.TxtEmailAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmailAddress.Multiline = false;
            this.TxtEmailAddress.Name = "TxtEmailAddress";
            this.TxtEmailAddress.Size = new System.Drawing.Size(175, 50);
            this.TxtEmailAddress.TabIndex = 16;
            this.TxtEmailAddress.Text = "";
            // 
            // LblBusnissPhone
            // 
            this.LblBusnissPhone.AutoSize = true;
            this.LblBusnissPhone.Depth = 0;
            this.LblBusnissPhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblBusnissPhone.Location = new System.Drawing.Point(21, 475);
            this.LblBusnissPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBusnissPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBusnissPhone.Name = "LblBusnissPhone";
            this.LblBusnissPhone.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblBusnissPhone.Size = new System.Drawing.Size(113, 19);
            this.LblBusnissPhone.TabIndex = 47;
            this.LblBusnissPhone.Text = "Business phone";
            // 
            // TxtBusnissPhone
            // 
            this.TxtBusnissPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBusnissPhone.Depth = 0;
            this.TxtBusnissPhone.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtBusnissPhone.Location = new System.Drawing.Point(20, 504);
            this.TxtBusnissPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBusnissPhone.MaxLength = 50;
            this.TxtBusnissPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBusnissPhone.Multiline = false;
            this.TxtBusnissPhone.Name = "TxtBusnissPhone";
            this.TxtBusnissPhone.Size = new System.Drawing.Size(175, 50);
            this.TxtBusnissPhone.TabIndex = 17;
            this.TxtBusnissPhone.Text = "";
            // 
            // LblPrivatePhone
            // 
            this.LblPrivatePhone.AutoSize = true;
            this.LblPrivatePhone.Depth = 0;
            this.LblPrivatePhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblPrivatePhone.Location = new System.Drawing.Point(17, 379);
            this.LblPrivatePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrivatePhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPrivatePhone.Name = "LblPrivatePhone";
            this.LblPrivatePhone.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblPrivatePhone.Size = new System.Drawing.Size(98, 19);
            this.LblPrivatePhone.TabIndex = 48;
            this.LblPrivatePhone.Text = "Private phone";
            // 
            // TxtPrivatePhone
            // 
            this.TxtPrivatePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrivatePhone.Depth = 0;
            this.TxtPrivatePhone.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtPrivatePhone.Location = new System.Drawing.Point(18, 407);
            this.TxtPrivatePhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrivatePhone.MaxLength = 50;
            this.TxtPrivatePhone.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPrivatePhone.Multiline = false;
            this.TxtPrivatePhone.Name = "TxtPrivatePhone";
            this.TxtPrivatePhone.Size = new System.Drawing.Size(175, 50);
            this.TxtPrivatePhone.TabIndex = 15;
            this.TxtPrivatePhone.Text = "";
            // 
            // CmdCreatePerson
            // 
            this.CmdCreatePerson.AutoSize = false;
            this.CmdCreatePerson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdCreatePerson.Depth = 0;
            this.CmdCreatePerson.DrawShadows = true;
            this.CmdCreatePerson.HighEmphasis = true;
            this.CmdCreatePerson.Icon = null;
            this.CmdCreatePerson.Location = new System.Drawing.Point(965, 551);
            this.CmdCreatePerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdCreatePerson.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCreatePerson.Name = "CmdCreatePerson";
            this.CmdCreatePerson.Size = new System.Drawing.Size(146, 44);
            this.CmdCreatePerson.TabIndex = 98;
            this.CmdCreatePerson.Text = "Save";
            this.CmdCreatePerson.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdCreatePerson.UseAccentColor = false;
            this.CmdCreatePerson.UseVisualStyleBackColor = true;
            this.CmdCreatePerson.Click += new System.EventHandler(this.CmdCreatePerson_Click);
            // 
            // PnlEmployee
            // 
            this.PnlEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlEmployee.Controls.Add(this.NumDegreeOfEmployment);
            this.PnlEmployee.Controls.Add(this.PrgDegreeOfEmployment);
            this.PnlEmployee.Controls.Add(this.PnlTrainee);
            this.PnlEmployee.Controls.Add(this.LblDateOfJoining);
            this.PnlEmployee.Controls.Add(this.LblDateOfLeaving);
            this.PnlEmployee.Controls.Add(this.DatDateOfLeaving);
            this.PnlEmployee.Controls.Add(this.DatDateOfJoining);
            this.PnlEmployee.Controls.Add(this.TxtEmployeeNumber);
            this.PnlEmployee.Controls.Add(this.LblEmployeeNumber);
            this.PnlEmployee.Controls.Add(this.LblDepartement);
            this.PnlEmployee.Controls.Add(this.TxtDepartement);
            this.PnlEmployee.Controls.Add(this.NumCadreLevel);
            this.PnlEmployee.Controls.Add(this.LblDegreeOfEmployment);
            this.PnlEmployee.Controls.Add(this.LblCadreLevel);
            this.PnlEmployee.Controls.Add(this.LblRole);
            this.PnlEmployee.Controls.Add(this.TxtRole);
            this.PnlEmployee.Location = new System.Drawing.Point(637, 5);
            this.PnlEmployee.Name = "PnlEmployee";
            this.PnlEmployee.Size = new System.Drawing.Size(690, 350);
            this.PnlEmployee.TabIndex = 83;
            // 
            // NumDegreeOfEmployment
            // 
            this.NumDegreeOfEmployment.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDegreeOfEmployment.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumDegreeOfEmployment.Location = new System.Drawing.Point(484, 27);
            this.NumDegreeOfEmployment.Margin = new System.Windows.Forms.Padding(2);
            this.NumDegreeOfEmployment.Name = "NumDegreeOfEmployment";
            this.NumDegreeOfEmployment.Size = new System.Drawing.Size(49, 29);
            this.NumDegreeOfEmployment.TabIndex = 23;
            this.NumDegreeOfEmployment.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumDegreeOfEmployment.ValueChanged += new System.EventHandler(this.NumDegreeOfEmployment_ValueChanged);
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
            // PnlTrainee
            // 
            this.PnlTrainee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTrainee.Controls.Add(this.LblYearOfApp);
            this.PnlTrainee.Controls.Add(this.NumYearOfApp);
            this.PnlTrainee.Controls.Add(this.LblCurrentAppYear);
            this.PnlTrainee.Controls.Add(this.NumCurrentAppYear);
            this.PnlTrainee.Location = new System.Drawing.Point(7, 263);
            this.PnlTrainee.Name = "PnlTrainee";
            this.PnlTrainee.Size = new System.Drawing.Size(465, 77);
            this.PnlTrainee.TabIndex = 84;
            // 
            // LblYearOfApp
            // 
            this.LblYearOfApp.AutoSize = true;
            this.LblYearOfApp.Depth = 0;
            this.LblYearOfApp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblYearOfApp.Location = new System.Drawing.Point(246, 11);
            this.LblYearOfApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblYearOfApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblYearOfApp.Name = "LblYearOfApp";
            this.LblYearOfApp.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblYearOfApp.Size = new System.Drawing.Size(175, 19);
            this.LblYearOfApp.TabIndex = 27;
            this.LblYearOfApp.Text = "Years of apprenticeship*";
            // 
            // NumYearOfApp
            // 
            this.NumYearOfApp.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumYearOfApp.Location = new System.Drawing.Point(249, 34);
            this.NumYearOfApp.Margin = new System.Windows.Forms.Padding(2);
            this.NumYearOfApp.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumYearOfApp.Name = "NumYearOfApp";
            this.NumYearOfApp.Size = new System.Drawing.Size(44, 29);
            this.NumYearOfApp.TabIndex = 30;
            // 
            // LblCurrentAppYear
            // 
            this.LblCurrentAppYear.AutoSize = true;
            this.LblCurrentAppYear.Depth = 0;
            this.LblCurrentAppYear.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCurrentAppYear.Location = new System.Drawing.Point(2, 11);
            this.LblCurrentAppYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCurrentAppYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCurrentAppYear.Name = "LblCurrentAppYear";
            this.LblCurrentAppYear.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCurrentAppYear.Size = new System.Drawing.Size(194, 19);
            this.LblCurrentAppYear.TabIndex = 28;
            this.LblCurrentAppYear.Text = "Current apprenticeship year";
            // 
            // NumCurrentAppYear
            // 
            this.NumCurrentAppYear.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCurrentAppYear.Location = new System.Drawing.Point(5, 34);
            this.NumCurrentAppYear.Margin = new System.Windows.Forms.Padding(2);
            this.NumCurrentAppYear.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumCurrentAppYear.Name = "NumCurrentAppYear";
            this.NumCurrentAppYear.Size = new System.Drawing.Size(49, 29);
            this.NumCurrentAppYear.TabIndex = 29;
            // 
            // LblDateOfJoining
            // 
            this.LblDateOfJoining.AutoSize = true;
            this.LblDateOfJoining.Depth = 0;
            this.LblDateOfJoining.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblDateOfJoining.Location = new System.Drawing.Point(8, 180);
            this.LblDateOfJoining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDateOfJoining.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDateOfJoining.Name = "LblDateOfJoining";
            this.LblDateOfJoining.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblDateOfJoining.Size = new System.Drawing.Size(112, 19);
            this.LblDateOfJoining.TabIndex = 21;
            this.LblDateOfJoining.Text = "Date of joining*";
            // 
            // LblDateOfLeaving
            // 
            this.LblDateOfLeaving.AutoSize = true;
            this.LblDateOfLeaving.Depth = 0;
            this.LblDateOfLeaving.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblDateOfLeaving.Location = new System.Drawing.Point(148, 180);
            this.LblDateOfLeaving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDateOfLeaving.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDateOfLeaving.Name = "LblDateOfLeaving";
            this.LblDateOfLeaving.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblDateOfLeaving.Size = new System.Drawing.Size(108, 19);
            this.LblDateOfLeaving.TabIndex = 22;
            this.LblDateOfLeaving.Text = "Date of leaving";
            // 
            // DatDateOfLeaving
            // 
            this.DatDateOfLeaving.CustomFormat = "HTML Format";
            this.DatDateOfLeaving.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatDateOfLeaving.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatDateOfLeaving.Location = new System.Drawing.Point(148, 206);
            this.DatDateOfLeaving.Margin = new System.Windows.Forms.Padding(2);
            this.DatDateOfLeaving.Name = "DatDateOfLeaving";
            this.DatDateOfLeaving.Size = new System.Drawing.Size(109, 29);
            this.DatDateOfLeaving.TabIndex = 28;
            this.DatDateOfLeaving.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // DatDateOfJoining
            // 
            this.DatDateOfJoining.CustomFormat = "HTML Format";
            this.DatDateOfJoining.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatDateOfJoining.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatDateOfJoining.Location = new System.Drawing.Point(7, 206);
            this.DatDateOfJoining.Margin = new System.Windows.Forms.Padding(2);
            this.DatDateOfJoining.Name = "DatDateOfJoining";
            this.DatDateOfJoining.Size = new System.Drawing.Size(117, 29);
            this.DatDateOfJoining.TabIndex = 27;
            this.DatDateOfJoining.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // TxtEmployeeNumber
            // 
            this.TxtEmployeeNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmployeeNumber.Depth = 0;
            this.TxtEmployeeNumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtEmployeeNumber.Location = new System.Drawing.Point(146, 12);
            this.TxtEmployeeNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmployeeNumber.MaxLength = 50;
            this.TxtEmployeeNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmployeeNumber.Multiline = false;
            this.TxtEmployeeNumber.Name = "TxtEmployeeNumber";
            this.TxtEmployeeNumber.Size = new System.Drawing.Size(123, 50);
            this.TxtEmployeeNumber.TabIndex = 22;
            this.TxtEmployeeNumber.Text = "";
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
            // TxtDepartement
            // 
            this.TxtDepartement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDepartement.Depth = 0;
            this.TxtDepartement.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtDepartement.Location = new System.Drawing.Point(8, 113);
            this.TxtDepartement.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDepartement.MaxLength = 50;
            this.TxtDepartement.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDepartement.Multiline = false;
            this.TxtDepartement.Name = "TxtDepartement";
            this.TxtDepartement.Size = new System.Drawing.Size(261, 50);
            this.TxtDepartement.TabIndex = 24;
            this.TxtDepartement.Text = "";
            // 
            // NumCadreLevel
            // 
            this.NumCadreLevel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCadreLevel.Location = new System.Drawing.Point(556, 114);
            this.NumCadreLevel.Margin = new System.Windows.Forms.Padding(2);
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
            this.LblCadreLevel.Location = new System.Drawing.Point(555, 87);
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
            // TxtRole
            // 
            this.TxtRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRole.Depth = 0;
            this.TxtRole.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtRole.Location = new System.Drawing.Point(287, 113);
            this.TxtRole.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRole.MaxLength = 50;
            this.TxtRole.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtRole.Multiline = false;
            this.TxtRole.Name = "TxtRole";
            this.TxtRole.Size = new System.Drawing.Size(246, 50);
            this.TxtRole.TabIndex = 25;
            this.TxtRole.Text = "";
            // 
            // LblSearchPreviewNumber
            // 
            this.LblSearchPreviewNumber.AutoSize = true;
            this.LblSearchPreviewNumber.Location = new System.Drawing.Point(17, 11);
            this.LblSearchPreviewNumber.Name = "LblSearchPreviewNumber";
            this.LblSearchPreviewNumber.Size = new System.Drawing.Size(23, 14);
            this.LblSearchPreviewNumber.TabIndex = 119;
            this.LblSearchPreviewNumber.Text = "Nr.:";
            // 
            // LblSearchPreviewType
            // 
            this.LblSearchPreviewType.AutoSize = true;
            this.LblSearchPreviewType.Location = new System.Drawing.Point(140, 11);
            this.LblSearchPreviewType.Name = "LblSearchPreviewType";
            this.LblSearchPreviewType.Size = new System.Drawing.Size(33, 14);
            this.LblSearchPreviewType.TabIndex = 120;
            this.LblSearchPreviewType.Text = "Type:";
            // 
            // LblSearchPreviewCustomerType
            // 
            this.LblSearchPreviewCustomerType.AutoSize = true;
            this.LblSearchPreviewCustomerType.Location = new System.Drawing.Point(12, 34);
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
            // LblSearchPreviewCompanyContact
            // 
            this.LblSearchPreviewCompanyContact.AutoSize = true;
            this.LblSearchPreviewCompanyContact.Location = new System.Drawing.Point(12, 62);
            this.LblSearchPreviewCompanyContact.Name = "LblSearchPreviewCompanyContact";
            this.LblSearchPreviewCompanyContact.Size = new System.Drawing.Size(91, 14);
            this.LblSearchPreviewCompanyContact.TabIndex = 123;
            this.LblSearchPreviewCompanyContact.Text = "Company contact";
            // 
            // PnlSearchPreviewCustomer
            // 
            this.PnlSearchPreviewCustomer.Controls.Add(this.label33);
            this.PnlSearchPreviewCustomer.Controls.Add(this.label32);
            this.PnlSearchPreviewCustomer.Controls.Add(this.label31);
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchHeadlineCustomer);
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchPreviewCompanyContact);
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchPreviewCustomerType);
            this.PnlSearchPreviewCustomer.Controls.Add(this.LblSearchPreviewCompanyName);
            this.PnlSearchPreviewCustomer.Location = new System.Drawing.Point(330, 35);
            this.PnlSearchPreviewCustomer.Name = "PnlSearchPreviewCustomer";
            this.PnlSearchPreviewCustomer.Size = new System.Drawing.Size(301, 89);
            this.PnlSearchPreviewCustomer.TabIndex = 124;
            this.PnlSearchPreviewCustomer.Visible = false;
            // 
            // PnlSearchPreviewEmployee
            // 
            this.PnlSearchPreviewEmployee.Controls.Add(this.label39);
            this.PnlSearchPreviewEmployee.Controls.Add(this.label38);
            this.PnlSearchPreviewEmployee.Controls.Add(this.label37);
            this.PnlSearchPreviewEmployee.Controls.Add(this.label36);
            this.PnlSearchPreviewEmployee.Controls.Add(this.label35);
            this.PnlSearchPreviewEmployee.Controls.Add(this.label34);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDateOfLeaving);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDateOfJoining);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewCadreLevel);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewEmployee);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewRole);
            this.PnlSearchPreviewEmployee.Controls.Add(this.label16);
            this.PnlSearchPreviewEmployee.Controls.Add(this.LblSearchPreviewDepartement);
            this.PnlSearchPreviewEmployee.Location = new System.Drawing.Point(330, 35);
            this.PnlSearchPreviewEmployee.Name = "PnlSearchPreviewEmployee";
            this.PnlSearchPreviewEmployee.Size = new System.Drawing.Size(301, 141);
            this.PnlSearchPreviewEmployee.TabIndex = 125;
            this.PnlSearchPreviewEmployee.Visible = false;
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
            this.LblSearchPreviewRole.Location = new System.Drawing.Point(12, 62);
            this.LblSearchPreviewRole.Name = "LblSearchPreviewRole";
            this.LblSearchPreviewRole.Size = new System.Drawing.Size(75, 14);
            this.LblSearchPreviewRole.TabIndex = 123;
            this.LblSearchPreviewRole.Text = "Role (Job title)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 14);
            this.label16.TabIndex = 121;
            this.label16.Text = "Degree of employment (%)";
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
            // LblSearchPreviewCadreLevel
            // 
            this.LblSearchPreviewCadreLevel.AutoSize = true;
            this.LblSearchPreviewCadreLevel.Location = new System.Drawing.Point(12, 75);
            this.LblSearchPreviewCadreLevel.Name = "LblSearchPreviewCadreLevel";
            this.LblSearchPreviewCadreLevel.Size = new System.Drawing.Size(88, 14);
            this.LblSearchPreviewCadreLevel.TabIndex = 124;
            this.LblSearchPreviewCadreLevel.Text = "Cadre level (0-5)";
            // 
            // LblSearchPreviewDateOfJoining
            // 
            this.LblSearchPreviewDateOfJoining.AutoSize = true;
            this.LblSearchPreviewDateOfJoining.Location = new System.Drawing.Point(12, 102);
            this.LblSearchPreviewDateOfJoining.Name = "LblSearchPreviewDateOfJoining";
            this.LblSearchPreviewDateOfJoining.Size = new System.Drawing.Size(75, 14);
            this.LblSearchPreviewDateOfJoining.TabIndex = 125;
            this.LblSearchPreviewDateOfJoining.Text = "Date of joining";
            // 
            // LblSearchPreviewDateOfLeaving
            // 
            this.LblSearchPreviewDateOfLeaving.AutoSize = true;
            this.LblSearchPreviewDateOfLeaving.Location = new System.Drawing.Point(12, 116);
            this.LblSearchPreviewDateOfLeaving.Name = "LblSearchPreviewDateOfLeaving";
            this.LblSearchPreviewDateOfLeaving.Size = new System.Drawing.Size(79, 14);
            this.LblSearchPreviewDateOfLeaving.TabIndex = 126;
            this.LblSearchPreviewDateOfLeaving.Text = "Date of leaving";
            // 
            // PnlSearchPreviewTrainee
            // 
            this.PnlSearchPreviewTrainee.Controls.Add(this.label30);
            this.PnlSearchPreviewTrainee.Controls.Add(this.label29);
            this.PnlSearchPreviewTrainee.Controls.Add(this.label14);
            this.PnlSearchPreviewTrainee.Controls.Add(this.LblSearchPreviewCurrentAppYear);
            this.PnlSearchPreviewTrainee.Controls.Add(this.LblSearchPreviewYearsOfApp);
            this.PnlSearchPreviewTrainee.Location = new System.Drawing.Point(330, 35);
            this.PnlSearchPreviewTrainee.Name = "PnlSearchPreviewTrainee";
            this.PnlSearchPreviewTrainee.Size = new System.Drawing.Size(301, 69);
            this.PnlSearchPreviewTrainee.TabIndex = 125;
            this.PnlSearchPreviewTrainee.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 14);
            this.label14.TabIndex = 1;
            this.label14.Text = "Trainee information";
            // 
            // LblSearchPreviewCurrentAppYear
            // 
            this.LblSearchPreviewCurrentAppYear.AutoSize = true;
            this.LblSearchPreviewCurrentAppYear.Location = new System.Drawing.Point(12, 34);
            this.LblSearchPreviewCurrentAppYear.Name = "LblSearchPreviewCurrentAppYear";
            this.LblSearchPreviewCurrentAppYear.Size = new System.Drawing.Size(142, 14);
            this.LblSearchPreviewCurrentAppYear.TabIndex = 121;
            this.LblSearchPreviewCurrentAppYear.Text = "Current apprenticeship year";
            // 
            // LblSearchPreviewYearsOfApp
            // 
            this.LblSearchPreviewYearsOfApp.AutoSize = true;
            this.LblSearchPreviewYearsOfApp.Location = new System.Drawing.Point(12, 48);
            this.LblSearchPreviewYearsOfApp.Name = "LblSearchPreviewYearsOfApp";
            this.LblSearchPreviewYearsOfApp.Size = new System.Drawing.Size(123, 14);
            this.LblSearchPreviewYearsOfApp.TabIndex = 122;
            this.LblSearchPreviewYearsOfApp.Text = "Years of apprenticeship";
            // 
            // PnlSearchPreviewGeneral
            // 
            this.PnlSearchPreviewGeneral.Controls.Add(this.label28);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label27);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label26);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label25);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label24);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label23);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label22);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label21);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label20);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label19);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label18);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label17);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label15);
            this.PnlSearchPreviewGeneral.Controls.Add(this.LblSearchHeadlineGeneral);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label1);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label2);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label3);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label4);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label13);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label5);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label12);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label6);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label11);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label7);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label10);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label8);
            this.PnlSearchPreviewGeneral.Controls.Add(this.label9);
            this.PnlSearchPreviewGeneral.Location = new System.Drawing.Point(6, 35);
            this.PnlSearchPreviewGeneral.Name = "PnlSearchPreviewGeneral";
            this.PnlSearchPreviewGeneral.Size = new System.Drawing.Size(268, 230);
            this.PnlSearchPreviewGeneral.TabIndex = 126;
            // 
            // LblSearchPreviewStatus
            // 
            this.LblSearchPreviewStatus.AutoSize = true;
            this.LblSearchPreviewStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchPreviewStatus.Location = new System.Drawing.Point(544, 11);
            this.LblSearchPreviewStatus.Name = "LblSearchPreviewStatus";
            this.LblSearchPreviewStatus.Size = new System.Drawing.Size(42, 14);
            this.LblSearchPreviewStatus.TabIndex = 127;
            this.LblSearchPreviewStatus.Text = "Status";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(131, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 14);
            this.label15.TabIndex = 119;
            this.label15.Text = "label15";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(131, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 14);
            this.label17.TabIndex = 120;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(131, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 14);
            this.label18.TabIndex = 121;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(131, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 14);
            this.label19.TabIndex = 122;
            this.label19.Text = "label19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(131, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 14);
            this.label20.TabIndex = 123;
            this.label20.Text = "label20";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(131, 104);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 14);
            this.label21.TabIndex = 124;
            this.label21.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(131, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 14);
            this.label22.TabIndex = 125;
            this.label22.Text = "label22";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(131, 132);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 14);
            this.label23.TabIndex = 126;
            this.label23.Text = "label23";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(131, 147);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 14);
            this.label24.TabIndex = 127;
            this.label24.Text = "label24";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(131, 161);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 14);
            this.label25.TabIndex = 128;
            this.label25.Text = "label25";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(131, 175);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 14);
            this.label26.TabIndex = 129;
            this.label26.Text = "label26";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(131, 189);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 14);
            this.label27.TabIndex = 130;
            this.label27.Text = "label27";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(131, 203);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 14);
            this.label28.TabIndex = 131;
            this.label28.Text = "label28";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(175, 34);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 14);
            this.label29.TabIndex = 132;
            this.label29.Text = "label29";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(175, 48);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 14);
            this.label30.TabIndex = 133;
            this.label30.Text = "label30";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(175, 32);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 14);
            this.label31.TabIndex = 124;
            this.label31.Text = "label31";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(175, 47);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 14);
            this.label32.TabIndex = 125;
            this.label32.Text = "label32";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(175, 61);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 14);
            this.label33.TabIndex = 126;
            this.label33.Text = "label33";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(175, 33);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 14);
            this.label34.TabIndex = 127;
            this.label34.Text = "label34";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(175, 48);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(41, 14);
            this.label35.TabIndex = 128;
            this.label35.Text = "label35";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(175, 62);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 14);
            this.label36.TabIndex = 129;
            this.label36.Text = "label36";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(175, 76);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 14);
            this.label37.TabIndex = 130;
            this.label37.Text = "label37";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(175, 104);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 14);
            this.label38.TabIndex = 131;
            this.label38.Text = "label38";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(175, 118);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 14);
            this.label39.TabIndex = 132;
            this.label39.Text = "label39";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 198);
            this.dataGridView1.TabIndex = 128;
            // 
            // LblSearchNotes
            // 
            this.LblSearchNotes.AutoSize = true;
            this.LblSearchNotes.Depth = 0;
            this.LblSearchNotes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSearchNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSearchNotes.Location = new System.Drawing.Point(17, 341);
            this.LblSearchNotes.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSearchNotes.Name = "LblSearchNotes";
            this.LblSearchNotes.Size = new System.Drawing.Size(42, 19);
            this.LblSearchNotes.TabIndex = 129;
            this.LblSearchNotes.Text = "Notes";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 719);
            this.Controls.Add(this.TCtrlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TCtrlMain.ResumeLayout(false);
            this.TabSearch.ResumeLayout(false);
            this.TabSearch.PerformLayout();
            this.PnlSearchPreview.ResumeLayout(false);
            this.PnlSearchPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSearchResult)).EndInit();
            this.TabCreateEdit.ResumeLayout(false);
            this.TabCreate.ResumeLayout(false);
            this.TabCreate.PerformLayout();
            this.PnlCustomer.ResumeLayout(false);
            this.PnlCustomer.PerformLayout();
            this.PnlPerson.ResumeLayout(false);
            this.PnlPerson.PerformLayout();
            this.GrpType.ResumeLayout(false);
            this.GrpType.PerformLayout();
            this.PnlEmployee.ResumeLayout(false);
            this.PnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDegreeOfEmployment)).EndInit();
            this.PnlTrainee.ResumeLayout(false);
            this.PnlTrainee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYearOfApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentAppYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).EndInit();
            this.PnlSearchPreviewCustomer.ResumeLayout(false);
            this.PnlSearchPreviewCustomer.PerformLayout();
            this.PnlSearchPreviewEmployee.ResumeLayout(false);
            this.PnlSearchPreviewEmployee.PerformLayout();
            this.PnlSearchPreviewTrainee.ResumeLayout(false);
            this.PnlSearchPreviewTrainee.PerformLayout();
            this.PnlSearchPreviewGeneral.ResumeLayout(false);
            this.PnlSearchPreviewGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        
        

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TCtrlMain;
        private System.Windows.Forms.TabPage TabSearch;
        private System.Windows.Forms.TabPage TabCreateEdit;
        private MaterialSkin.Controls.MaterialLabel LblBusinessAddress;
        private MaterialSkin.Controls.MaterialLabel LblCurrentAppYear;
        private MaterialSkin.Controls.MaterialLabel LblYearOfApp;
        private MaterialSkin.Controls.MaterialLabel LblCadreLevel;
        private MaterialSkin.Controls.MaterialLabel LblRole;
        private MaterialSkin.Controls.MaterialLabel LblDegreeOfEmployment;
        private MaterialSkin.Controls.MaterialLabel LblDateOfLeaving;
        private MaterialSkin.Controls.MaterialLabel LblDateOfJoining;
        private MaterialSkin.Controls.MaterialLabel LblOasiNr;
        private MaterialSkin.Controls.MaterialLabel LblDepartement;
        private MaterialSkin.Controls.MaterialLabel LblEmployeeNumber;
        private MaterialSkin.Controls.MaterialCheckbox ChkTrainee;
        private MaterialSkin.Controls.MaterialTextBox TxtDepartement;
        private MaterialSkin.Controls.MaterialTextBox TxtRole;
        private System.Windows.Forms.NumericUpDown NumYearOfApp;
        private System.Windows.Forms.NumericUpDown NumCurrentAppYear;
        private System.Windows.Forms.NumericUpDown NumCadreLevel;
        private MaterialSkin.Controls.MaterialTextBox TxtBusinessAddress;
        private System.Windows.Forms.DateTimePicker DatDateOfLeaving;
        private System.Windows.Forms.DateTimePicker DatDateOfJoining;
        private MaterialSkin.Controls.MaterialButton CmdCreatePerson;
        private MaterialSkin.Controls.MaterialTextBox TxtPrivatePhone;
        private MaterialSkin.Controls.MaterialTextBox TxtBusnissPhone;
        private MaterialSkin.Controls.MaterialLabel LblBusnissPhone;
        private MaterialSkin.Controls.MaterialLabel LblPrivatePhone;
        private MaterialSkin.Controls.MaterialCard TabCreate;
        private MaterialSkin.Controls.MaterialTextBox TxtLastName;
        private MaterialSkin.Controls.MaterialTextBox TxtFirstName;
        private MaterialSkin.Controls.MaterialLabel LblLastName;
        private MaterialSkin.Controls.MaterialLabel LblFirstName;
        private MaterialSkin.Controls.MaterialLabel LblSalutation;
        private MaterialSkin.Controls.MaterialRadioButton RadEmployee;
        private MaterialSkin.Controls.MaterialRadioButton RadCustomer;
        private MaterialSkin.Controls.MaterialTextBox TxtOasiNr;
        private MaterialSkin.Controls.MaterialRadioButton RadOther;
        private MaterialSkin.Controls.MaterialRadioButton RadFemale;
        private MaterialSkin.Controls.MaterialRadioButton RadMale;
        private MaterialSkin.Controls.MaterialSwitch SwtActive;
        private System.Windows.Forms.DateTimePicker DatBirthday;
        private MaterialSkin.Controls.MaterialTextBox TxtPlz;
        private MaterialSkin.Controls.MaterialTextBox TxtAddress;
        private MaterialSkin.Controls.MaterialTextBox TxtPlaceOfResidence;
        private MaterialSkin.Controls.MaterialTextBox TxtTitle;
        private MaterialSkin.Controls.MaterialLabel LblPLZ;
        private MaterialSkin.Controls.MaterialLabel LblAddress;
        private MaterialSkin.Controls.MaterialLabel LblNationality;
        private MaterialSkin.Controls.MaterialLabel LblPlaceOfResidence;
        private MaterialSkin.Controls.MaterialLabel LblTitle;
        private MaterialSkin.Controls.MaterialLabel LblDateOfBirth;
        private MaterialSkin.Controls.MaterialTextBox TxtEmailAddress;
        private MaterialSkin.Controls.MaterialLabel LblEmailAddress;
        private System.Windows.Forms.Button CmdExecSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.TextBox txtOutput;
        private MaterialSkin.Controls.MaterialComboBox CmbNationality;
        private MaterialSkin.Controls.MaterialComboBox CmbSalutation;
        private System.Windows.Forms.Panel PnlPerson;
        private System.Windows.Forms.Panel PnlEmployee;
        private System.Windows.Forms.Panel PnlTrainee;
        private System.Windows.Forms.GroupBox GrpType;
        private MaterialSkin.Controls.MaterialTextBox TxtEmployeeNumber;
        private MaterialSkin.Controls.MaterialProgressBar PrgDegreeOfEmployment;
        private System.Windows.Forms.NumericUpDown NumDegreeOfEmployment;
        private System.Windows.Forms.Label LblTypeSelection;
        private MaterialSkin.Controls.MaterialButton CmdCancel;
        private MaterialSkin.Controls.MaterialButton CmdCreatePersonAndNew;
        private MaterialSkin.Controls.MaterialButton CmdNotesAll;
        private System.Windows.Forms.ListBox LstNoteOut;
        private MaterialSkin.Controls.MaterialButton CmdNoteAdd;
        private MaterialSkin.Controls.MaterialButton CmdNoteDelete;
        private MaterialSkin.Controls.MaterialButton CmdNoteEdit;
        private MaterialSkin.Controls.MaterialLabel LblNotes;
        private System.Windows.Forms.Panel PnlCustomer;
        private MaterialSkin.Controls.MaterialLabel LblCompanyName;
        private MaterialSkin.Controls.MaterialComboBox CmbCustomerType;
        private MaterialSkin.Controls.MaterialTextBox TxtCompanyName;
        private MaterialSkin.Controls.MaterialLabel LblCustomerType;
        private MaterialSkin.Controls.MaterialLabel LblCompanyContact;
        private MaterialSkin.Controls.MaterialTextBox TxtCompanyContact;
        private System.Windows.Forms.DataGridView DataGridViewSearchResult;
        private MaterialSkin.Controls.MaterialButton CmdSearchExec2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton CmdSearchAdvanced;
        private MaterialSkin.Controls.MaterialButton CmdQuickPersonEdit;
        private MaterialSkin.Controls.MaterialButton CmdQuickPersonCreate;
        private MaterialSkin.Controls.MaterialButton CmdQuickPersonDelete;
        private MaterialSkin.Controls.MaterialLabel LblSearchResultCounter;
        private System.Windows.Forms.Panel PnlSearchPreview;
        private MaterialSkin.Controls.MaterialLabel LblSearchFirstName;
        private MaterialSkin.Controls.MaterialLabel LblSearchLastName;
        private MaterialSkin.Controls.MaterialTextBox TxtSearchFirstName;
        private MaterialSkin.Controls.MaterialTextBox TxtSearchLastName;
        private MaterialSkin.Controls.MaterialTextBox TxtCustomerNumber;
        private MaterialSkin.Controls.MaterialLabel LblCustomerNumber;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LblSearchPreviewDepartement;
        private System.Windows.Forms.Panel PnlSearchPreviewTrainee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblSearchPreviewCurrentAppYear;
        private System.Windows.Forms.Label LblSearchPreviewYearsOfApp;
        private System.Windows.Forms.Panel PnlSearchPreviewGeneral;
        private System.Windows.Forms.Label LblSearchPreviewStatus;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel LblSearchNotes;
    }
}
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.TabCreateEdit = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.NumYearOfApp = new System.Windows.Forms.NumericUpDown();
            this.DatDateOfLeaving = new System.Windows.Forms.DateTimePicker();
            this.LblYearOfApp = new MaterialSkin.Controls.MaterialLabel();
            this.NumCurrentAppYear = new System.Windows.Forms.NumericUpDown();
            this.ChckTrainee = new MaterialSkin.Controls.MaterialCheckbox();
            this.LblCureentAppYear = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCompanyContact = new MaterialSkin.Controls.MaterialTextBox();
            this.DatDateOfJoining = new System.Windows.Forms.DateTimePicker();
            this.SwtActive = new MaterialSkin.Controls.MaterialSwitch();
            this.LblDateOfLeaving = new MaterialSkin.Controls.MaterialLabel();
            this.LblCompanyContact = new MaterialSkin.Controls.MaterialLabel();
            this.LblOasiNr = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCustomerType = new MaterialSkin.Controls.MaterialTextBox();
            this.LblDateOfJoining = new MaterialSkin.Controls.MaterialLabel();
            this.LblCustomerType = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBusinessAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.LblBusinessAddress = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCompanyName = new MaterialSkin.Controls.MaterialTextBox();
            this.NumCadreLevel = new System.Windows.Forms.NumericUpDown();
            this.LblCompanyName = new MaterialSkin.Controls.MaterialLabel();
            this.LblCadreLevel = new MaterialSkin.Controls.MaterialLabel();
            this.TxtRole = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtDegreeOfEmployment = new MaterialSkin.Controls.MaterialTextBox();
            this.CmdCreatePerson = new MaterialSkin.Controls.MaterialButton();
            this.LblRole = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDepartement = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtEmailAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.datBirthday = new System.Windows.Forms.DateTimePicker();
            this.LblDegreeOfEmployment = new MaterialSkin.Controls.MaterialLabel();
            this.LblDepartement = new MaterialSkin.Controls.MaterialLabel();
            this.LblEmployeeNumber = new MaterialSkin.Controls.MaterialLabel();
            this.TxtEmployeeNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.LblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.LblEmailAddress = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPlz = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtPrivatePhone = new MaterialSkin.Controls.MaterialTextBox();
            this.LblContact = new MaterialSkin.Controls.MaterialLabel();
            this.LblPrivatePhone = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBusnissPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.LblBusnissPhone = new MaterialSkin.Controls.MaterialLabel();
            this.TxtNationality = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtPlaceOfResidence = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.LblPLZ = new MaterialSkin.Controls.MaterialLabel();
            this.LblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.LblNationality = new MaterialSkin.Controls.MaterialLabel();
            this.LblPlaceOfResidence = new MaterialSkin.Controls.MaterialLabel();
            this.LblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.LblDateOfBirth = new MaterialSkin.Controls.MaterialLabel();
            this.RadEmployee = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadCustomer = new MaterialSkin.Controls.MaterialRadioButton();
            this.TxtOasiNr = new MaterialSkin.Controls.MaterialTextBox();
            this.RadOther = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtSalutation = new MaterialSkin.Controls.MaterialTextBox();
            this.LblLastName = new MaterialSkin.Controls.MaterialLabel();
            this.LblFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.LblSalutation = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.TCtrlMain.SuspendLayout();
            this.TabSearch.SuspendLayout();
            this.TabCreateEdit.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYearOfApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentAppYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // TCtrlMain
            // 
            this.TCtrlMain.Controls.Add(this.TabSearch);
            this.TCtrlMain.Controls.Add(this.TabCreateEdit);
            this.TCtrlMain.Depth = 0;
            this.TCtrlMain.Location = new System.Drawing.Point(12, 78);
            this.TCtrlMain.Margin = new System.Windows.Forms.Padding(2);
            this.TCtrlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCtrlMain.Multiline = true;
            this.TCtrlMain.Name = "TCtrlMain";
            this.TCtrlMain.SelectedIndex = 0;
            this.TCtrlMain.Size = new System.Drawing.Size(1433, 915);
            this.TCtrlMain.TabIndex = 0;
            // 
            // TabSearch
            // 
            this.TabSearch.Controls.Add(this.txtOutput);
            this.TabSearch.Controls.Add(this.btnSearch);
            this.TabSearch.Controls.Add(this.txtSearch);
            this.TabSearch.Controls.Add(this.Search);
            this.TabSearch.Location = new System.Drawing.Point(4, 22);
            this.TabSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TabSearch.Name = "TabSearch";
            this.TabSearch.Padding = new System.Windows.Forms.Padding(2);
            this.TabSearch.Size = new System.Drawing.Size(1425, 889);
            this.TabSearch.TabIndex = 0;
            this.TabSearch.Text = "Search";
            this.TabSearch.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(170, 137);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(938, 352);
            this.txtOutput.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(693, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(290, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(187, 74);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            // 
            // TabCreateEdit
            // 
            this.TabCreateEdit.Controls.Add(this.materialCard2);
            this.TabCreateEdit.Location = new System.Drawing.Point(4, 22);
            this.TabCreateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TabCreateEdit.Name = "TabCreateEdit";
            this.TabCreateEdit.Padding = new System.Windows.Forms.Padding(2);
            this.TabCreateEdit.Size = new System.Drawing.Size(1425, 889);
            this.TabCreateEdit.TabIndex = 1;
            this.TabCreateEdit.Text = "Create";
            this.TabCreateEdit.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.NumYearOfApp);
            this.materialCard2.Controls.Add(this.DatDateOfLeaving);
            this.materialCard2.Controls.Add(this.LblYearOfApp);
            this.materialCard2.Controls.Add(this.NumCurrentAppYear);
            this.materialCard2.Controls.Add(this.ChckTrainee);
            this.materialCard2.Controls.Add(this.LblCureentAppYear);
            this.materialCard2.Controls.Add(this.TxtCompanyContact);
            this.materialCard2.Controls.Add(this.DatDateOfJoining);
            this.materialCard2.Controls.Add(this.SwtActive);
            this.materialCard2.Controls.Add(this.LblDateOfLeaving);
            this.materialCard2.Controls.Add(this.LblCompanyContact);
            this.materialCard2.Controls.Add(this.LblOasiNr);
            this.materialCard2.Controls.Add(this.TxtCustomerType);
            this.materialCard2.Controls.Add(this.LblDateOfJoining);
            this.materialCard2.Controls.Add(this.LblCustomerType);
            this.materialCard2.Controls.Add(this.TxtBusinessAddress);
            this.materialCard2.Controls.Add(this.LblBusinessAddress);
            this.materialCard2.Controls.Add(this.TxtCompanyName);
            this.materialCard2.Controls.Add(this.NumCadreLevel);
            this.materialCard2.Controls.Add(this.LblCompanyName);
            this.materialCard2.Controls.Add(this.LblCadreLevel);
            this.materialCard2.Controls.Add(this.TxtRole);
            this.materialCard2.Controls.Add(this.TxtDegreeOfEmployment);
            this.materialCard2.Controls.Add(this.CmdCreatePerson);
            this.materialCard2.Controls.Add(this.LblRole);
            this.materialCard2.Controls.Add(this.TxtDepartement);
            this.materialCard2.Controls.Add(this.TxtEmailAddress);
            this.materialCard2.Controls.Add(this.datBirthday);
            this.materialCard2.Controls.Add(this.LblDegreeOfEmployment);
            this.materialCard2.Controls.Add(this.LblDepartement);
            this.materialCard2.Controls.Add(this.LblEmployeeNumber);
            this.materialCard2.Controls.Add(this.TxtEmployeeNumber);
            this.materialCard2.Controls.Add(this.LblStatus);
            this.materialCard2.Controls.Add(this.LblEmailAddress);
            this.materialCard2.Controls.Add(this.TxtPlz);
            this.materialCard2.Controls.Add(this.TxtPrivatePhone);
            this.materialCard2.Controls.Add(this.LblContact);
            this.materialCard2.Controls.Add(this.LblPrivatePhone);
            this.materialCard2.Controls.Add(this.TxtBusnissPhone);
            this.materialCard2.Controls.Add(this.TxtAddress);
            this.materialCard2.Controls.Add(this.LblBusnissPhone);
            this.materialCard2.Controls.Add(this.TxtNationality);
            this.materialCard2.Controls.Add(this.TxtPlaceOfResidence);
            this.materialCard2.Controls.Add(this.TxtTitle);
            this.materialCard2.Controls.Add(this.LblPLZ);
            this.materialCard2.Controls.Add(this.LblAddress);
            this.materialCard2.Controls.Add(this.LblNationality);
            this.materialCard2.Controls.Add(this.LblPlaceOfResidence);
            this.materialCard2.Controls.Add(this.LblTitle);
            this.materialCard2.Controls.Add(this.LblDateOfBirth);
            this.materialCard2.Controls.Add(this.RadEmployee);
            this.materialCard2.Controls.Add(this.RadCustomer);
            this.materialCard2.Controls.Add(this.TxtOasiNr);
            this.materialCard2.Controls.Add(this.RadOther);
            this.materialCard2.Controls.Add(this.RadFemale);
            this.materialCard2.Controls.Add(this.RadMale);
            this.materialCard2.Controls.Add(this.txtLastName);
            this.materialCard2.Controls.Add(this.txtFirstName);
            this.materialCard2.Controls.Add(this.TxtSalutation);
            this.materialCard2.Controls.Add(this.LblLastName);
            this.materialCard2.Controls.Add(this.LblFirstName);
            this.materialCard2.Controls.Add(this.LblSalutation);
            this.materialCard2.Controls.Add(this.label3);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(0, 0);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(9);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(9);
            this.materialCard2.Size = new System.Drawing.Size(1516, 913);
            this.materialCard2.TabIndex = 59;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // NumYearOfApp
            // 
            this.NumYearOfApp.Location = new System.Drawing.Point(911, 83);
            this.NumYearOfApp.Margin = new System.Windows.Forms.Padding(2);
            this.NumYearOfApp.Name = "NumYearOfApp";
            this.NumYearOfApp.Size = new System.Drawing.Size(165, 20);
            this.NumYearOfApp.TabIndex = 61;
            // 
            // DatDateOfLeaving
            // 
            this.DatDateOfLeaving.CustomFormat = "HTML Format";
            this.DatDateOfLeaving.Location = new System.Drawing.Point(642, 348);
            this.DatDateOfLeaving.Margin = new System.Windows.Forms.Padding(2);
            this.DatDateOfLeaving.Name = "DatDateOfLeaving";
            this.DatDateOfLeaving.Size = new System.Drawing.Size(166, 20);
            this.DatDateOfLeaving.TabIndex = 61;
            this.DatDateOfLeaving.Value = new System.DateTime(2023, 7, 2, 0, 0, 0, 0);
            // 
            // LblYearOfApp
            // 
            this.LblYearOfApp.AutoSize = true;
            this.LblYearOfApp.Depth = 0;
            this.LblYearOfApp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblYearOfApp.Location = new System.Drawing.Point(908, 57);
            this.LblYearOfApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblYearOfApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblYearOfApp.Name = "LblYearOfApp";
            this.LblYearOfApp.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblYearOfApp.Size = new System.Drawing.Size(168, 19);
            this.LblYearOfApp.TabIndex = 27;
            this.LblYearOfApp.Text = "Years of apprenticeship";
            // 
            // NumCurrentAppYear
            // 
            this.NumCurrentAppYear.Location = new System.Drawing.Point(685, 83);
            this.NumCurrentAppYear.Margin = new System.Windows.Forms.Padding(2);
            this.NumCurrentAppYear.Name = "NumCurrentAppYear";
            this.NumCurrentAppYear.Size = new System.Drawing.Size(165, 20);
            this.NumCurrentAppYear.TabIndex = 61;
            // 
            // ChckTrainee
            // 
            this.ChckTrainee.AutoSize = true;
            this.ChckTrainee.Depth = 0;
            this.ChckTrainee.Location = new System.Drawing.Point(531, 50);
            this.ChckTrainee.Margin = new System.Windows.Forms.Padding(0);
            this.ChckTrainee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChckTrainee.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChckTrainee.Name = "ChckTrainee";
            this.ChckTrainee.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ChckTrainee.Ripple = true;
            this.ChckTrainee.Size = new System.Drawing.Size(88, 37);
            this.ChckTrainee.TabIndex = 37;
            this.ChckTrainee.Text = "Trainee";
            this.ChckTrainee.UseVisualStyleBackColor = true;
            // 
            // LblCureentAppYear
            // 
            this.LblCureentAppYear.AutoSize = true;
            this.LblCureentAppYear.Depth = 0;
            this.LblCureentAppYear.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCureentAppYear.Location = new System.Drawing.Point(679, 57);
            this.LblCureentAppYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCureentAppYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCureentAppYear.Name = "LblCureentAppYear";
            this.LblCureentAppYear.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCureentAppYear.Size = new System.Drawing.Size(194, 19);
            this.LblCureentAppYear.TabIndex = 28;
            this.LblCureentAppYear.Text = "Current apprenticeship year";
            // 
            // TxtCompanyContact
            // 
            this.TxtCompanyContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCompanyContact.Depth = 0;
            this.TxtCompanyContact.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCompanyContact.Location = new System.Drawing.Point(599, 495);
            this.TxtCompanyContact.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCompanyContact.MaxLength = 50;
            this.TxtCompanyContact.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCompanyContact.Multiline = false;
            this.TxtCompanyContact.Name = "TxtCompanyContact";
            this.TxtCompanyContact.Size = new System.Drawing.Size(165, 50);
            this.TxtCompanyContact.TabIndex = 64;
            this.TxtCompanyContact.Text = "";
            // 
            // DatDateOfJoining
            // 
            this.DatDateOfJoining.CustomFormat = "HTML Format";
            this.DatDateOfJoining.Location = new System.Drawing.Point(642, 305);
            this.DatDateOfJoining.Margin = new System.Windows.Forms.Padding(2);
            this.DatDateOfJoining.Name = "DatDateOfJoining";
            this.DatDateOfJoining.Size = new System.Drawing.Size(166, 20);
            this.DatDateOfJoining.TabIndex = 54;
            this.DatDateOfJoining.Value = new System.DateTime(2023, 7, 2, 0, 0, 0, 0);
            // 
            // SwtActive
            // 
            this.SwtActive.AutoSize = true;
            this.SwtActive.Checked = true;
            this.SwtActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SwtActive.Depth = 0;
            this.SwtActive.Location = new System.Drawing.Point(837, 721);
            this.SwtActive.Margin = new System.Windows.Forms.Padding(0);
            this.SwtActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwtActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwtActive.Name = "SwtActive";
            this.SwtActive.Ripple = true;
            this.SwtActive.Size = new System.Drawing.Size(101, 37);
            this.SwtActive.TabIndex = 60;
            this.SwtActive.Text = "Active";
            this.SwtActive.UseVisualStyleBackColor = true;
            // 
            // LblDateOfLeaving
            // 
            this.LblDateOfLeaving.AutoSize = true;
            this.LblDateOfLeaving.Depth = 0;
            this.LblDateOfLeaving.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblDateOfLeaving.Location = new System.Drawing.Point(643, 327);
            this.LblDateOfLeaving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDateOfLeaving.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDateOfLeaving.Name = "LblDateOfLeaving";
            this.LblDateOfLeaving.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblDateOfLeaving.Size = new System.Drawing.Size(108, 19);
            this.LblDateOfLeaving.TabIndex = 22;
            this.LblDateOfLeaving.Text = "Date of leaving";
            // 
            // LblCompanyContact
            // 
            this.LblCompanyContact.AutoSize = true;
            this.LblCompanyContact.Depth = 0;
            this.LblCompanyContact.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCompanyContact.Location = new System.Drawing.Point(613, 474);
            this.LblCompanyContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCompanyContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCompanyContact.Name = "LblCompanyContact";
            this.LblCompanyContact.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCompanyContact.Size = new System.Drawing.Size(126, 19);
            this.LblCompanyContact.TabIndex = 33;
            this.LblCompanyContact.Text = "Company contact";
            // 
            // LblOasiNr
            // 
            this.LblOasiNr.AutoSize = true;
            this.LblOasiNr.Depth = 0;
            this.LblOasiNr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblOasiNr.Location = new System.Drawing.Point(221, 338);
            this.LblOasiNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOasiNr.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblOasiNr.Name = "LblOasiNr";
            this.LblOasiNr.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblOasiNr.Size = new System.Drawing.Size(94, 19);
            this.LblOasiNr.TabIndex = 16;
            this.LblOasiNr.Text = "OASI number";
            // 
            // TxtCustomerType
            // 
            this.TxtCustomerType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCustomerType.Depth = 0;
            this.TxtCustomerType.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCustomerType.Location = new System.Drawing.Point(419, 593);
            this.TxtCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerType.MaxLength = 50;
            this.TxtCustomerType.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCustomerType.Multiline = false;
            this.TxtCustomerType.Name = "TxtCustomerType";
            this.TxtCustomerType.Size = new System.Drawing.Size(165, 50);
            this.TxtCustomerType.TabIndex = 63;
            this.TxtCustomerType.Text = "";
            // 
            // LblDateOfJoining
            // 
            this.LblDateOfJoining.AutoSize = true;
            this.LblDateOfJoining.Depth = 0;
            this.LblDateOfJoining.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblDateOfJoining.Location = new System.Drawing.Point(643, 284);
            this.LblDateOfJoining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDateOfJoining.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDateOfJoining.Name = "LblDateOfJoining";
            this.LblDateOfJoining.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblDateOfJoining.Size = new System.Drawing.Size(105, 19);
            this.LblDateOfJoining.TabIndex = 21;
            this.LblDateOfJoining.Text = "Date of joining";
            // 
            // LblCustomerType
            // 
            this.LblCustomerType.AutoSize = true;
            this.LblCustomerType.Depth = 0;
            this.LblCustomerType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCustomerType.Location = new System.Drawing.Point(417, 566);
            this.LblCustomerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCustomerType.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCustomerType.Name = "LblCustomerType";
            this.LblCustomerType.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCustomerType.Size = new System.Drawing.Size(141, 19);
            this.LblCustomerType.TabIndex = 32;
            this.LblCustomerType.Text = "Customer type (A-E)";
            // 
            // TxtBusinessAddress
            // 
            this.TxtBusinessAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBusinessAddress.Depth = 0;
            this.TxtBusinessAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtBusinessAddress.Location = new System.Drawing.Point(224, 593);
            this.TxtBusinessAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBusinessAddress.MaxLength = 50;
            this.TxtBusinessAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBusinessAddress.Multiline = false;
            this.TxtBusinessAddress.Name = "TxtBusinessAddress";
            this.TxtBusinessAddress.Size = new System.Drawing.Size(165, 50);
            this.TxtBusinessAddress.TabIndex = 62;
            this.TxtBusinessAddress.Text = "";
            // 
            // LblBusinessAddress
            // 
            this.LblBusinessAddress.AutoSize = true;
            this.LblBusinessAddress.Depth = 0;
            this.LblBusinessAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblBusinessAddress.Location = new System.Drawing.Point(230, 566);
            this.LblBusinessAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBusinessAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBusinessAddress.Name = "LblBusinessAddress";
            this.LblBusinessAddress.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblBusinessAddress.Size = new System.Drawing.Size(125, 19);
            this.LblBusinessAddress.TabIndex = 31;
            this.LblBusinessAddress.Text = "Business address";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCompanyName.Depth = 0;
            this.TxtCompanyName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtCompanyName.Location = new System.Drawing.Point(420, 495);
            this.TxtCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCompanyName.MaxLength = 50;
            this.TxtCompanyName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCompanyName.Multiline = false;
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(165, 50);
            this.TxtCompanyName.TabIndex = 61;
            this.TxtCompanyName.Text = "";
            // 
            // NumCadreLevel
            // 
            this.NumCadreLevel.Location = new System.Drawing.Point(934, 572);
            this.NumCadreLevel.Margin = new System.Windows.Forms.Padding(2);
            this.NumCadreLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumCadreLevel.Name = "NumCadreLevel";
            this.NumCadreLevel.Size = new System.Drawing.Size(165, 20);
            this.NumCadreLevel.TabIndex = 60;
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Depth = 0;
            this.LblCompanyName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCompanyName.Location = new System.Drawing.Point(432, 474);
            this.LblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCompanyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCompanyName.Size = new System.Drawing.Size(113, 19);
            this.LblCompanyName.TabIndex = 30;
            this.LblCompanyName.Text = "Company name";
            // 
            // LblCadreLevel
            // 
            this.LblCadreLevel.AutoSize = true;
            this.LblCadreLevel.Depth = 0;
            this.LblCadreLevel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCadreLevel.Location = new System.Drawing.Point(932, 554);
            this.LblCadreLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCadreLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCadreLevel.Name = "LblCadreLevel";
            this.LblCadreLevel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCadreLevel.Size = new System.Drawing.Size(115, 19);
            this.LblCadreLevel.TabIndex = 25;
            this.LblCadreLevel.Text = "Cadre level (0-5)";
            // 
            // TxtRole
            // 
            this.TxtRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRole.Depth = 0;
            this.TxtRole.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtRole.Location = new System.Drawing.Point(935, 483);
            this.TxtRole.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRole.MaxLength = 50;
            this.TxtRole.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtRole.Multiline = false;
            this.TxtRole.Name = "TxtRole";
            this.TxtRole.Size = new System.Drawing.Size(165, 50);
            this.TxtRole.TabIndex = 55;
            this.TxtRole.Text = "";
            // 
            // TxtDegreeOfEmployment
            // 
            this.TxtDegreeOfEmployment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDegreeOfEmployment.Depth = 0;
            this.TxtDegreeOfEmployment.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtDegreeOfEmployment.Location = new System.Drawing.Point(935, 375);
            this.TxtDegreeOfEmployment.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDegreeOfEmployment.MaxLength = 50;
            this.TxtDegreeOfEmployment.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDegreeOfEmployment.Multiline = false;
            this.TxtDegreeOfEmployment.Name = "TxtDegreeOfEmployment";
            this.TxtDegreeOfEmployment.Size = new System.Drawing.Size(165, 50);
            this.TxtDegreeOfEmployment.TabIndex = 59;
            this.TxtDegreeOfEmployment.Text = "";
            // 
            // CmdCreatePerson
            // 
            this.CmdCreatePerson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdCreatePerson.Depth = 0;
            this.CmdCreatePerson.DrawShadows = true;
            this.CmdCreatePerson.HighEmphasis = true;
            this.CmdCreatePerson.Icon = null;
            this.CmdCreatePerson.Location = new System.Drawing.Point(971, 694);
            this.CmdCreatePerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdCreatePerson.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCreatePerson.Name = "CmdCreatePerson";
            this.CmdCreatePerson.Size = new System.Drawing.Size(76, 36);
            this.CmdCreatePerson.TabIndex = 55;
            this.CmdCreatePerson.Text = "Create";
            this.CmdCreatePerson.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CmdCreatePerson.UseAccentColor = false;
            this.CmdCreatePerson.UseVisualStyleBackColor = true;
            this.CmdCreatePerson.Click += new System.EventHandler(this.CmdCreatePerson_Click);
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Depth = 0;
            this.LblRole.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblRole.Location = new System.Drawing.Point(932, 448);
            this.LblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblRole.Name = "LblRole";
            this.LblRole.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblRole.Size = new System.Drawing.Size(104, 19);
            this.LblRole.TabIndex = 24;
            this.LblRole.Text = "Role (Job title)";
            // 
            // TxtDepartement
            // 
            this.TxtDepartement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDepartement.Depth = 0;
            this.TxtDepartement.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtDepartement.Location = new System.Drawing.Point(935, 268);
            this.TxtDepartement.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDepartement.MaxLength = 50;
            this.TxtDepartement.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDepartement.Multiline = false;
            this.TxtDepartement.Name = "TxtDepartement";
            this.TxtDepartement.Size = new System.Drawing.Size(165, 50);
            this.TxtDepartement.TabIndex = 58;
            this.TxtDepartement.Text = "";
            // 
            // TxtEmailAddress
            // 
            this.TxtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmailAddress.Depth = 0;
            this.TxtEmailAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtEmailAddress.Location = new System.Drawing.Point(216, 495);
            this.TxtEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmailAddress.MaxLength = 50;
            this.TxtEmailAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmailAddress.Multiline = false;
            this.TxtEmailAddress.Name = "TxtEmailAddress";
            this.TxtEmailAddress.Size = new System.Drawing.Size(173, 50);
            this.TxtEmailAddress.TabIndex = 76;
            this.TxtEmailAddress.Text = "";
            // 
            // datBirthday
            // 
            this.datBirthday.CustomFormat = "HTML Format";
            this.datBirthday.Location = new System.Drawing.Point(220, 210);
            this.datBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.datBirthday.Name = "datBirthday";
            this.datBirthday.Size = new System.Drawing.Size(179, 20);
            this.datBirthday.TabIndex = 75;
            this.datBirthday.Value = new System.DateTime(2023, 7, 2, 0, 0, 0, 0);
            // 
            // LblDegreeOfEmployment
            // 
            this.LblDegreeOfEmployment.AutoSize = true;
            this.LblDegreeOfEmployment.Depth = 0;
            this.LblDegreeOfEmployment.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblDegreeOfEmployment.Location = new System.Drawing.Point(932, 348);
            this.LblDegreeOfEmployment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDegreeOfEmployment.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDegreeOfEmployment.Name = "LblDegreeOfEmployment";
            this.LblDegreeOfEmployment.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblDegreeOfEmployment.Size = new System.Drawing.Size(161, 19);
            this.LblDegreeOfEmployment.TabIndex = 23;
            this.LblDegreeOfEmployment.Text = "Degree of employment";
            // 
            // LblDepartement
            // 
            this.LblDepartement.AutoSize = true;
            this.LblDepartement.Depth = 0;
            this.LblDepartement.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblDepartement.Location = new System.Drawing.Point(932, 247);
            this.LblDepartement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDepartement.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDepartement.Name = "LblDepartement";
            this.LblDepartement.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblDepartement.Size = new System.Drawing.Size(92, 19);
            this.LblDepartement.TabIndex = 15;
            this.LblDepartement.Text = "Departement";
            // 
            // LblEmployeeNumber
            // 
            this.LblEmployeeNumber.AutoSize = true;
            this.LblEmployeeNumber.Depth = 0;
            this.LblEmployeeNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblEmployeeNumber.Location = new System.Drawing.Point(932, 138);
            this.LblEmployeeNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmployeeNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEmployeeNumber.Name = "LblEmployeeNumber";
            this.LblEmployeeNumber.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblEmployeeNumber.Size = new System.Drawing.Size(128, 19);
            this.LblEmployeeNumber.TabIndex = 14;
            this.LblEmployeeNumber.Text = "Employee number";
            // 
            // TxtEmployeeNumber
            // 
            this.TxtEmployeeNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmployeeNumber.Depth = 0;
            this.TxtEmployeeNumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtEmployeeNumber.Location = new System.Drawing.Point(935, 164);
            this.TxtEmployeeNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmployeeNumber.MaxLength = 50;
            this.TxtEmployeeNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmployeeNumber.Multiline = false;
            this.TxtEmployeeNumber.Name = "TxtEmployeeNumber";
            this.TxtEmployeeNumber.Size = new System.Drawing.Size(165, 50);
            this.TxtEmployeeNumber.TabIndex = 53;
            this.TxtEmployeeNumber.Text = "";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Depth = 0;
            this.LblStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblStatus.Location = new System.Drawing.Point(843, 681);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblStatus.Size = new System.Drawing.Size(47, 19);
            this.LblStatus.TabIndex = 57;
            this.LblStatus.Text = "Status";
            // 
            // LblEmailAddress
            // 
            this.LblEmailAddress.AutoSize = true;
            this.LblEmailAddress.Depth = 0;
            this.LblEmailAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblEmailAddress.Location = new System.Drawing.Point(230, 474);
            this.LblEmailAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmailAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEmailAddress.Name = "LblEmailAddress";
            this.LblEmailAddress.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblEmailAddress.Size = new System.Drawing.Size(101, 19);
            this.LblEmailAddress.TabIndex = 75;
            this.LblEmailAddress.Text = "Email address";
            // 
            // TxtPlz
            // 
            this.TxtPlz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPlz.Depth = 0;
            this.TxtPlz.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtPlz.Location = new System.Drawing.Point(419, 364);
            this.TxtPlz.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPlz.MaxLength = 50;
            this.TxtPlz.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPlz.Multiline = false;
            this.TxtPlz.Name = "TxtPlz";
            this.TxtPlz.Size = new System.Drawing.Size(165, 50);
            this.TxtPlz.TabIndex = 73;
            this.TxtPlz.Text = "";
            // 
            // TxtPrivatePhone
            // 
            this.TxtPrivatePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrivatePhone.Depth = 0;
            this.TxtPrivatePhone.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtPrivatePhone.Location = new System.Drawing.Point(15, 599);
            this.TxtPrivatePhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrivatePhone.MaxLength = 50;
            this.TxtPrivatePhone.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPrivatePhone.Multiline = false;
            this.TxtPrivatePhone.Name = "TxtPrivatePhone";
            this.TxtPrivatePhone.Size = new System.Drawing.Size(173, 50);
            this.TxtPrivatePhone.TabIndex = 50;
            this.TxtPrivatePhone.Text = "";
            // 
            // LblContact
            // 
            this.LblContact.AutoSize = true;
            this.LblContact.Depth = 0;
            this.LblContact.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblContact.Location = new System.Drawing.Point(11, 443);
            this.LblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblContact.Name = "LblContact";
            this.LblContact.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblContact.Size = new System.Drawing.Size(56, 19);
            this.LblContact.TabIndex = 51;
            this.LblContact.Text = "Contact";
            // 
            // LblPrivatePhone
            // 
            this.LblPrivatePhone.AutoSize = true;
            this.LblPrivatePhone.Depth = 0;
            this.LblPrivatePhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblPrivatePhone.Location = new System.Drawing.Point(11, 572);
            this.LblPrivatePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrivatePhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPrivatePhone.Name = "LblPrivatePhone";
            this.LblPrivatePhone.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblPrivatePhone.Size = new System.Drawing.Size(98, 19);
            this.LblPrivatePhone.TabIndex = 48;
            this.LblPrivatePhone.Text = "Private phone";
            // 
            // TxtBusnissPhone
            // 
            this.TxtBusnissPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBusnissPhone.Depth = 0;
            this.TxtBusnissPhone.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtBusnissPhone.Location = new System.Drawing.Point(15, 501);
            this.TxtBusnissPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBusnissPhone.MaxLength = 50;
            this.TxtBusnissPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBusnissPhone.Multiline = false;
            this.TxtBusnissPhone.Name = "TxtBusnissPhone";
            this.TxtBusnissPhone.Size = new System.Drawing.Size(173, 50);
            this.TxtBusnissPhone.TabIndex = 49;
            this.TxtBusnissPhone.Text = "";
            // 
            // TxtAddress
            // 
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAddress.Depth = 0;
            this.TxtAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtAddress.Location = new System.Drawing.Point(419, 273);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAddress.MaxLength = 50;
            this.TxtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtAddress.Multiline = false;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(165, 50);
            this.TxtAddress.TabIndex = 72;
            this.TxtAddress.Text = "";
            // 
            // LblBusnissPhone
            // 
            this.LblBusnissPhone.AutoSize = true;
            this.LblBusnissPhone.Depth = 0;
            this.LblBusnissPhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblBusnissPhone.Location = new System.Drawing.Point(11, 480);
            this.LblBusnissPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBusnissPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBusnissPhone.Name = "LblBusnissPhone";
            this.LblBusnissPhone.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblBusnissPhone.Size = new System.Drawing.Size(113, 19);
            this.LblBusnissPhone.TabIndex = 47;
            this.LblBusnissPhone.Text = "Business phone";
            // 
            // TxtNationality
            // 
            this.TxtNationality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNationality.Depth = 0;
            this.TxtNationality.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtNationality.Location = new System.Drawing.Point(221, 273);
            this.TxtNationality.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNationality.MaxLength = 50;
            this.TxtNationality.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNationality.Multiline = false;
            this.TxtNationality.Name = "TxtNationality";
            this.TxtNationality.Size = new System.Drawing.Size(177, 50);
            this.TxtNationality.TabIndex = 71;
            this.TxtNationality.Text = "";
            // 
            // TxtPlaceOfResidence
            // 
            this.TxtPlaceOfResidence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPlaceOfResidence.Depth = 0;
            this.TxtPlaceOfResidence.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtPlaceOfResidence.Location = new System.Drawing.Point(419, 183);
            this.TxtPlaceOfResidence.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPlaceOfResidence.MaxLength = 50;
            this.TxtPlaceOfResidence.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPlaceOfResidence.Multiline = false;
            this.TxtPlaceOfResidence.Name = "TxtPlaceOfResidence";
            this.TxtPlaceOfResidence.Size = new System.Drawing.Size(165, 50);
            this.TxtPlaceOfResidence.TabIndex = 70;
            this.TxtPlaceOfResidence.Text = "";
            // 
            // TxtTitle
            // 
            this.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTitle.Depth = 0;
            this.TxtTitle.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtTitle.Location = new System.Drawing.Point(631, 176);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTitle.MaxLength = 50;
            this.TxtTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtTitle.Multiline = false;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(177, 50);
            this.TxtTitle.TabIndex = 69;
            this.TxtTitle.Text = "";
            // 
            // LblPLZ
            // 
            this.LblPLZ.AutoSize = true;
            this.LblPLZ.Depth = 0;
            this.LblPLZ.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblPLZ.Location = new System.Drawing.Point(417, 338);
            this.LblPLZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPLZ.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPLZ.Name = "LblPLZ";
            this.LblPLZ.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblPLZ.Size = new System.Drawing.Size(84, 19);
            this.LblPLZ.TabIndex = 68;
            this.LblPLZ.Text = "Postal code";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Depth = 0;
            this.LblAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblAddress.Location = new System.Drawing.Point(417, 247);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblAddress.Size = new System.Drawing.Size(58, 19);
            this.LblAddress.TabIndex = 67;
            this.LblAddress.Text = "Address";
            // 
            // LblNationality
            // 
            this.LblNationality.AutoSize = true;
            this.LblNationality.Depth = 0;
            this.LblNationality.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblNationality.Location = new System.Drawing.Point(219, 247);
            this.LblNationality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNationality.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNationality.Name = "LblNationality";
            this.LblNationality.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblNationality.Size = new System.Drawing.Size(78, 19);
            this.LblNationality.TabIndex = 66;
            this.LblNationality.Text = "Nationality";
            // 
            // LblPlaceOfResidence
            // 
            this.LblPlaceOfResidence.AutoSize = true;
            this.LblPlaceOfResidence.Depth = 0;
            this.LblPlaceOfResidence.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblPlaceOfResidence.Location = new System.Drawing.Point(417, 156);
            this.LblPlaceOfResidence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPlaceOfResidence.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPlaceOfResidence.Name = "LblPlaceOfResidence";
            this.LblPlaceOfResidence.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblPlaceOfResidence.Size = new System.Drawing.Size(130, 19);
            this.LblPlaceOfResidence.TabIndex = 65;
            this.LblPlaceOfResidence.Text = "Place of residence";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Depth = 0;
            this.LblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblTitle.Location = new System.Drawing.Point(629, 150);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblTitle.Size = new System.Drawing.Size(32, 19);
            this.LblTitle.TabIndex = 63;
            this.LblTitle.Text = "Title";
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Depth = 0;
            this.LblDateOfBirth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblDateOfBirth.Location = new System.Drawing.Point(218, 184);
            this.LblDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDateOfBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblDateOfBirth.Size = new System.Drawing.Size(89, 19);
            this.LblDateOfBirth.TabIndex = 62;
            this.LblDateOfBirth.Text = "Date of birth";
            // 
            // RadEmployee
            // 
            this.RadEmployee.AutoSize = true;
            this.RadEmployee.Depth = 0;
            this.RadEmployee.Location = new System.Drawing.Point(15, 47);
            this.RadEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.RadEmployee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadEmployee.Name = "RadEmployee";
            this.RadEmployee.Ripple = true;
            this.RadEmployee.Size = new System.Drawing.Size(104, 37);
            this.RadEmployee.TabIndex = 60;
            this.RadEmployee.TabStop = true;
            this.RadEmployee.Text = "Employee";
            this.RadEmployee.UseVisualStyleBackColor = true;
            this.RadEmployee.CheckedChanged += new System.EventHandler(this.RadEmployee_CheckedChanged);
            // 
            // RadCustomer
            // 
            this.RadCustomer.AutoSize = true;
            this.RadCustomer.Depth = 0;
            this.RadCustomer.Location = new System.Drawing.Point(166, 47);
            this.RadCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.RadCustomer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadCustomer.Name = "RadCustomer";
            this.RadCustomer.Ripple = true;
            this.RadCustomer.Size = new System.Drawing.Size(103, 37);
            this.RadCustomer.TabIndex = 61;
            this.RadCustomer.TabStop = true;
            this.RadCustomer.Text = "Customer";
            this.RadCustomer.UseVisualStyleBackColor = true;
            // 
            // TxtOasiNr
            // 
            this.TxtOasiNr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOasiNr.Depth = 0;
            this.TxtOasiNr.Enabled = false;
            this.TxtOasiNr.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtOasiNr.Location = new System.Drawing.Point(212, 364);
            this.TxtOasiNr.Margin = new System.Windows.Forms.Padding(2);
            this.TxtOasiNr.MaxLength = 50;
            this.TxtOasiNr.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtOasiNr.Multiline = false;
            this.TxtOasiNr.Name = "TxtOasiNr";
            this.TxtOasiNr.Size = new System.Drawing.Size(177, 50);
            this.TxtOasiNr.TabIndex = 59;
            this.TxtOasiNr.Text = "";
            // 
            // RadOther
            // 
            this.RadOther.AutoSize = true;
            this.RadOther.Depth = 0;
            this.RadOther.Location = new System.Drawing.Point(282, 98);
            this.RadOther.Margin = new System.Windows.Forms.Padding(0);
            this.RadOther.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadOther.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadOther.Name = "RadOther";
            this.RadOther.Ripple = true;
            this.RadOther.Size = new System.Drawing.Size(73, 37);
            this.RadOther.TabIndex = 58;
            this.RadOther.TabStop = true;
            this.RadOther.Text = "Other";
            this.RadOther.UseVisualStyleBackColor = true;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Depth = 0;
            this.RadFemale.Location = new System.Drawing.Point(15, 98);
            this.RadFemale.Margin = new System.Windows.Forms.Padding(0);
            this.RadFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Ripple = true;
            this.RadFemale.Size = new System.Drawing.Size(87, 37);
            this.RadFemale.TabIndex = 57;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Depth = 0;
            this.RadMale.Location = new System.Drawing.Point(166, 98);
            this.RadMale.Margin = new System.Windows.Forms.Padding(0);
            this.RadMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadMale.Name = "RadMale";
            this.RadMale.Ripple = true;
            this.RadMale.Size = new System.Drawing.Size(70, 37);
            this.RadMale.TabIndex = 56;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtLastName.Location = new System.Drawing.Point(11, 364);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(175, 50);
            this.txtLastName.TabIndex = 47;
            this.txtLastName.Text = "";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(11, 273);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(177, 50);
            this.txtFirstName.TabIndex = 46;
            this.txtFirstName.Text = "";
            // 
            // TxtSalutation
            // 
            this.TxtSalutation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSalutation.Depth = 0;
            this.TxtSalutation.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSalutation.Location = new System.Drawing.Point(11, 182);
            this.TxtSalutation.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSalutation.MaxLength = 50;
            this.TxtSalutation.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSalutation.Multiline = false;
            this.TxtSalutation.Name = "TxtSalutation";
            this.TxtSalutation.Size = new System.Drawing.Size(177, 50);
            this.TxtSalutation.TabIndex = 45;
            this.TxtSalutation.Text = "";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Depth = 0;
            this.LblLastName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblLastName.Location = new System.Drawing.Point(11, 338);
            this.LblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblLastName.Size = new System.Drawing.Size(76, 19);
            this.LblLastName.TabIndex = 44;
            this.LblLastName.Text = "Last name";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Depth = 0;
            this.LblFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblFirstName.Location = new System.Drawing.Point(11, 247);
            this.LblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblFirstName.Size = new System.Drawing.Size(76, 19);
            this.LblFirstName.TabIndex = 43;
            this.LblFirstName.Text = "First name";
            // 
            // LblSalutation
            // 
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.Depth = 0;
            this.LblSalutation.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblSalutation.Location = new System.Drawing.Point(11, 156);
            this.LblSalutation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSalutation.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblSalutation.Size = new System.Drawing.Size(74, 19);
            this.LblSalutation.TabIndex = 42;
            this.LblSalutation.Text = "Salutation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Generic";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.TCtrlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Contact Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TCtrlMain.ResumeLayout(false);
            this.TabSearch.ResumeLayout(false);
            this.TabSearch.PerformLayout();
            this.TabCreateEdit.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYearOfApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentAppYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).EndInit();
            this.ResumeLayout(false);

        }

        //FormMain_Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Employee TextBoxes
            TxtEmployeeNumber.Visible = false;
            TxtOasiNr.Visible = false;
            TxtRole.Visible = false;
            TxtDepartement.Visible = false;
            TxtDegreeOfEmployment.Visible = false;

            // Employee Labels
            LblEmployeeNumber.Visible = false;
            LblOasiNr.Visible = false;
            LblRole.Visible = false;
            LblDepartement.Visible = false;
            LblDegreeOfEmployment.Visible = false;

            // Other Employee Controls
            ChckTrainee.Visible = false;
            NumYearOfApp.Visible = false;
            NumCurrentAppYear.Visible = false;
            DatDateOfJoining.Visible = false;
            DatDateOfLeaving.Visible = false;

            // Customer TextBoxes
            TxtCustomerType.Visible = false;
            TxtCompanyContact.Visible = false;
            TxtBusinessAddress.Visible = false;
            TxtCompanyName.Visible = false;

            // Customer Labels
            LblCustomerType.Visible = false;
            LblCompanyContact.Visible = false;
            LblBusinessAddress.Visible = false;
            LblCompanyName.Visible = false;

            // Other Customer Controls
            RadFemale.Visible = false;
            RadMale.Visible = false;
            RadOther.Visible = false;
            LblSalutation.Visible = false;
            LblFirstName.Visible = false;
            LblLastName .Visible = false;
            LblNationality.Visible = false;
            LblOasiNr.Visible = false;
            LblPlaceOfResidence.Visible = false;
            LblPLZ.Visible = false;
            LblRole.Visible = false;
            LblStatus.Visible = false;
            LblYearOfApp.Visible = false;
            LblCureentAppYear.Visible = false;
            LblDateOfBirth.Visible = false;
            datBirthday.Visible = false;
            LblEmailAddress.Visible = false;
            LblPrivatePhone.Visible = false;
            LblBusnissPhone.Visible = false;
            TxtBusnissPhone.Visible = false;
            TxtPrivatePhone.Visible = false;
            CmdCreatePerson.Visible = false;
            LblTitle.Visible = false;
            LblCadreLevel.Visible = false;
           SwtActive.Visible = false;
            NumCadreLevel.Visible = false;
            NumCurrentAppYear.Visible = false;
            NumYearOfApp.Visible = false;
            LblAddress.Visible = false;
            TxtTitle.Visible = false;
            TxtCustomerType.Visible = false;
            LblDateOfJoining.Visible = false;
            LblDateOfLeaving.Visible = false;  
            TxtEmailAddress.Visible = false;
            LblContact.Visible = false;
            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            TxtSalutation.Visible = false;
            TxtAddress.Visible = false;
            TxtNationality.Visible = false;
            TxtOasiNr.Visible = false;
            TxtPlaceOfResidence.Visible=false;
            TxtPlz.Visible = false;
            TxtBusinessAddress.Visible = false;
            TxtRole.Visible = false;
            TxtCompanyContact.Visible = false;
           




        }
        //RadEmployee_CheckedChanged
        private void RadEmployee_CheckedChanged(object sender, EventArgs e)
        {
            bool isVisible = RadEmployee.Checked;

            // Employee TextBoxes
            TxtEmployeeNumber.Visible = isVisible;
            TxtOasiNr.Visible = isVisible;
            TxtRole.Visible = isVisible;
            TxtDepartement.Visible = isVisible;
            TxtDegreeOfEmployment.Visible = isVisible;
            txtFirstName.Visible = isVisible;
            txtLastName.Visible = isVisible;
            datBirthday.Visible = isVisible;

            // Employee Labels
            LblEmployeeNumber.Visible = isVisible;
            LblOasiNr.Visible = isVisible;
            LblRole.Visible = isVisible;
            LblDepartement.Visible = isVisible;
            LblDegreeOfEmployment.Visible = isVisible;
            LblSalutation.Visible = isVisible;
            LblFirstName.Visible = isVisible;
            LblLastName.Visible = isVisible;
            LblNationality.Visible = isVisible;
            LblOasiNr.Visible = isVisible;
            LblPlaceOfResidence.Visible = isVisible;
            LblPLZ.Visible = isVisible;
            LblRole.Visible = isVisible;
            LblStatus.Visible = isVisible;
            datBirthday.Visible = isVisible;

            // Other Employee Controls
            ChckTrainee.Visible = isVisible;
            NumYearOfApp.Visible = isVisible;
            NumCurrentAppYear.Visible = isVisible;
            DatDateOfJoining.Visible = isVisible;
            DatDateOfLeaving.Visible = isVisible;

            // Customer TextBoxes
            TxtCustomerType.Visible = !isVisible;
            TxtCompanyContact.Visible = !isVisible;
            TxtBusinessAddress.Visible = !isVisible;
            TxtCompanyName.Visible = !isVisible;

            // Customer Labels
            LblCustomerType.Visible = !isVisible;
            LblCompanyContact.Visible = !isVisible;
            LblBusinessAddress.Visible = !isVisible;
            LblCompanyName.Visible = !isVisible;
            

            // Customer Radio
            RadFemale.Visible = isVisible;
            RadMale.Visible = isVisible;
            RadOther.Visible = isVisible;

            // Employee BNT

            CmdCreatePerson.Visible = isVisible;


        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TCtrlMain;
        private System.Windows.Forms.TabPage TabSearch;
        private System.Windows.Forms.TabPage TabCreateEdit;
        private MaterialSkin.Controls.MaterialLabel LblCompanyContact;
        private MaterialSkin.Controls.MaterialLabel LblCustomerType;
        private MaterialSkin.Controls.MaterialLabel LblBusinessAddress;
        private MaterialSkin.Controls.MaterialLabel LblCompanyName;
        private MaterialSkin.Controls.MaterialLabel LblCureentAppYear;
        private MaterialSkin.Controls.MaterialLabel LblYearOfApp;
        private MaterialSkin.Controls.MaterialLabel LblCadreLevel;
        private MaterialSkin.Controls.MaterialLabel LblRole;
        private MaterialSkin.Controls.MaterialLabel LblDegreeOfEmployment;
        private MaterialSkin.Controls.MaterialLabel LblDateOfLeaving;
        private MaterialSkin.Controls.MaterialLabel LblDateOfJoining;
        private MaterialSkin.Controls.MaterialLabel LblOasiNr;
        private MaterialSkin.Controls.MaterialLabel LblDepartement;
        private MaterialSkin.Controls.MaterialLabel LblEmployeeNumber;
        private MaterialSkin.Controls.MaterialCheckbox ChckTrainee;
        private MaterialSkin.Controls.MaterialTextBox TxtDegreeOfEmployment;
        private MaterialSkin.Controls.MaterialTextBox TxtDepartement;
        private MaterialSkin.Controls.MaterialTextBox TxtRole;
        private MaterialSkin.Controls.MaterialTextBox TxtEmployeeNumber;
        private System.Windows.Forms.NumericUpDown NumYearOfApp;
        private System.Windows.Forms.NumericUpDown NumCurrentAppYear;
        private System.Windows.Forms.NumericUpDown NumCadreLevel;
        private MaterialSkin.Controls.MaterialTextBox TxtCompanyContact;
        private MaterialSkin.Controls.MaterialTextBox TxtCustomerType;
        private MaterialSkin.Controls.MaterialTextBox TxtBusinessAddress;
        private MaterialSkin.Controls.MaterialTextBox TxtCompanyName;
        private System.Windows.Forms.DateTimePicker DatDateOfLeaving;
        private System.Windows.Forms.DateTimePicker DatDateOfJoining;
        private MaterialSkin.Controls.MaterialButton CmdCreatePerson;
        private MaterialSkin.Controls.MaterialTextBox TxtPrivatePhone;
        private MaterialSkin.Controls.MaterialTextBox TxtBusnissPhone;
        private MaterialSkin.Controls.MaterialLabel LblBusnissPhone;
        private MaterialSkin.Controls.MaterialLabel LblPrivatePhone;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialTextBox txtFirstName;
        public MaterialSkin.Controls.MaterialTextBox TxtSalutation;
        private MaterialSkin.Controls.MaterialLabel LblLastName;
        private MaterialSkin.Controls.MaterialLabel LblFirstName;
        private MaterialSkin.Controls.MaterialLabel LblSalutation;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel LblContact;
        private MaterialSkin.Controls.MaterialRadioButton RadEmployee;
        private MaterialSkin.Controls.MaterialRadioButton RadCustomer;
        private MaterialSkin.Controls.MaterialTextBox TxtOasiNr;
        private MaterialSkin.Controls.MaterialRadioButton RadOther;
        private MaterialSkin.Controls.MaterialRadioButton RadFemale;
        private MaterialSkin.Controls.MaterialRadioButton RadMale;
        private MaterialSkin.Controls.MaterialSwitch SwtActive;
        private MaterialSkin.Controls.MaterialLabel LblStatus;
        private System.Windows.Forms.DateTimePicker datBirthday;
        private MaterialSkin.Controls.MaterialTextBox TxtPlz;
        private MaterialSkin.Controls.MaterialTextBox TxtAddress;
        private MaterialSkin.Controls.MaterialTextBox TxtNationality;
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox txtOutput;
    }
}
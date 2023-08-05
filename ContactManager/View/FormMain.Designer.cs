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
            this.CmdExecSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.TabCreateEdit = new System.Windows.Forms.TabPage();
            this.TabCreate = new MaterialSkin.Controls.MaterialCard();
            this.CmdNoteEdit = new MaterialSkin.Controls.MaterialButton();
            this.LblNotes = new MaterialSkin.Controls.MaterialLabel();
            this.CmdNoteAdd = new MaterialSkin.Controls.MaterialButton();
            this.CmdNoteDelete = new MaterialSkin.Controls.MaterialButton();
            this.LstNoteOut = new System.Windows.Forms.ListBox();
            this.CmdNotesAll = new MaterialSkin.Controls.MaterialButton();
            this.CmdCancel = new MaterialSkin.Controls.MaterialButton();
            this.CmdCreatePersonAndNew = new MaterialSkin.Controls.MaterialButton();
            this.LblTypeSelection = new System.Windows.Forms.Label();
            this.PnlCustomer = new System.Windows.Forms.Panel();
            this.LblCompanyName = new MaterialSkin.Controls.MaterialLabel();
            this.CmbCustomerType = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtCompanyName = new MaterialSkin.Controls.MaterialTextBox();
            this.LblCustomerType = new MaterialSkin.Controls.MaterialLabel();
            this.LblCompanyContact = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCompanyContact = new MaterialSkin.Controls.MaterialTextBox();
            this.PnlEmployee = new System.Windows.Forms.Panel();
            this.NumDegreeOfEmployment = new System.Windows.Forms.NumericUpDown();
            this.PrgDegreeOfEmployment = new MaterialSkin.Controls.MaterialProgressBar();
            this.PnlTrainee = new System.Windows.Forms.Panel();
            this.LblYearOfApp = new MaterialSkin.Controls.MaterialLabel();
            this.NumYearOfApp = new System.Windows.Forms.NumericUpDown();
            this.LblCureentAppYear = new MaterialSkin.Controls.MaterialLabel();
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
            this.TCtrlMain.SuspendLayout();
            this.TabSearch.SuspendLayout();
            this.TabCreateEdit.SuspendLayout();
            this.TabCreate.SuspendLayout();
            this.PnlCustomer.SuspendLayout();
            this.PnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDegreeOfEmployment)).BeginInit();
            this.PnlTrainee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYearOfApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentAppYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).BeginInit();
            this.PnlPerson.SuspendLayout();
            this.GrpType.SuspendLayout();
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
            this.TabSearch.Controls.Add(this.txtOutput);
            this.TabSearch.Controls.Add(this.CmdExecSearch);
            this.TabSearch.Controls.Add(this.TxtSearch);
            this.TabSearch.Controls.Add(this.Search);
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
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(22, 51);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(637, 532);
            this.txtOutput.TabIndex = 4;
            // 
            // CmdExecSearch
            // 
            this.CmdExecSearch.Location = new System.Drawing.Point(327, 13);
            this.CmdExecSearch.Name = "CmdExecSearch";
            this.CmdExecSearch.Size = new System.Drawing.Size(75, 23);
            this.CmdExecSearch.TabIndex = 3;
            this.CmdExecSearch.Text = "Search";
            this.CmdExecSearch.UseVisualStyleBackColor = true;
            this.CmdExecSearch.Click += new System.EventHandler(this.CmdExecSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(67, 14);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(244, 20);
            this.TxtSearch.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(19, 17);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(42, 14);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
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
            this.TabCreate.Controls.Add(this.CmdNoteEdit);
            this.TabCreate.Controls.Add(this.LblNotes);
            this.TabCreate.Controls.Add(this.CmdNoteAdd);
            this.TabCreate.Controls.Add(this.CmdNoteDelete);
            this.TabCreate.Controls.Add(this.LstNoteOut);
            this.TabCreate.Controls.Add(this.CmdNotesAll);
            this.TabCreate.Controls.Add(this.CmdCancel);
            this.TabCreate.Controls.Add(this.CmdCreatePersonAndNew);
            this.TabCreate.Controls.Add(this.LblTypeSelection);
            this.TabCreate.Controls.Add(this.PnlCustomer);
            this.TabCreate.Controls.Add(this.PnlEmployee);
            this.TabCreate.Controls.Add(this.PnlPerson);
            this.TabCreate.Controls.Add(this.CmdCreatePerson);
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
            // PnlCustomer
            // 
            this.PnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCustomer.Controls.Add(this.LblCompanyName);
            this.PnlCustomer.Controls.Add(this.CmbCustomerType);
            this.PnlCustomer.Controls.Add(this.TxtCompanyName);
            this.PnlCustomer.Controls.Add(this.LblCustomerType);
            this.PnlCustomer.Controls.Add(this.LblCompanyContact);
            this.PnlCustomer.Controls.Add(this.TxtCompanyContact);
            this.PnlCustomer.Location = new System.Drawing.Point(637, 5);
            this.PnlCustomer.Name = "PnlCustomer";
            this.PnlCustomer.Size = new System.Drawing.Size(692, 124);
            this.PnlCustomer.TabIndex = 85;
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Depth = 0;
            this.LblCompanyName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCompanyName.Location = new System.Drawing.Point(10, 30);
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
            this.CmbCustomerType.Location = new System.Drawing.Point(545, 56);
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
            this.TxtCompanyName.Location = new System.Drawing.Point(10, 56);
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
            this.LblCustomerType.Location = new System.Drawing.Point(542, 29);
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
            this.LblCompanyContact.Location = new System.Drawing.Point(292, 29);
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
            this.TxtCompanyContact.Location = new System.Drawing.Point(291, 56);
            this.TxtCompanyContact.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCompanyContact.MaxLength = 50;
            this.TxtCompanyContact.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCompanyContact.Multiline = false;
            this.TxtCompanyContact.Name = "TxtCompanyContact";
            this.TxtCompanyContact.Size = new System.Drawing.Size(239, 50);
            this.TxtCompanyContact.TabIndex = 32;
            this.TxtCompanyContact.Text = "";
            this.TxtCompanyContact.TextChanged += new System.EventHandler(this.TxtCompanyContact_TextChanged);
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
            this.PnlTrainee.Controls.Add(this.LblCureentAppYear);
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
            // LblCureentAppYear
            // 
            this.LblCureentAppYear.AutoSize = true;
            this.LblCureentAppYear.Depth = 0;
            this.LblCureentAppYear.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblCureentAppYear.Location = new System.Drawing.Point(2, 11);
            this.LblCureentAppYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCureentAppYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCureentAppYear.Name = "LblCureentAppYear";
            this.LblCureentAppYear.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblCureentAppYear.Size = new System.Drawing.Size(194, 19);
            this.LblCureentAppYear.TabIndex = 28;
            this.LblCureentAppYear.Text = "Current apprenticeship year";
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
            this.TxtEmployeeNumber.Size = new System.Drawing.Size(86, 50);
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
            this.TxtAddress.Location = new System.Drawing.Point(18, 207);
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
            this.TxtPlaceOfResidence.Location = new System.Drawing.Point(394, 207);
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
            this.TabCreateEdit.ResumeLayout(false);
            this.TabCreate.ResumeLayout(false);
            this.TabCreate.PerformLayout();
            this.PnlCustomer.ResumeLayout(false);
            this.PnlCustomer.PerformLayout();
            this.PnlEmployee.ResumeLayout(false);
            this.PnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDegreeOfEmployment)).EndInit();
            this.PnlTrainee.ResumeLayout(false);
            this.PnlTrainee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumYearOfApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCurrentAppYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCadreLevel)).EndInit();
            this.PnlPerson.ResumeLayout(false);
            this.PnlPerson.PerformLayout();
            this.GrpType.ResumeLayout(false);
            this.GrpType.PerformLayout();
            this.ResumeLayout(false);

        }

        
        

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TCtrlMain;
        private System.Windows.Forms.TabPage TabSearch;
        private System.Windows.Forms.TabPage TabCreateEdit;
        private MaterialSkin.Controls.MaterialLabel LblBusinessAddress;
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
        private System.Windows.Forms.Label Search;
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
    }
}
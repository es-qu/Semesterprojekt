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
            this.SuspendLayout();
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(858, 702);
            this.Name = "FormMain";
            //   this.Load += new System.EventHandler(this.FormMain_Load_1);
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
        private MaterialSkin.Controls.MaterialTextBox TxtDepartement;
        private MaterialSkin.Controls.MaterialTextBox TxtRole;
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
        private System.Windows.Forms.Button CmdExecSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.TextBox txtOutput;

        private MaterialSkin.Controls.MaterialComboBox CmdNationality;
        private MaterialSkin.Controls.MaterialComboBox CmbSalutation;
        private System.Windows.Forms.Panel PnlPerson;
        private System.Windows.Forms.Panel PnlEmployee;
        private System.Windows.Forms.Panel PnlTrainee;
        private System.Windows.Forms.GroupBox GrpType;

        private MaterialSkin.Controls.MaterialComboBox CmbCreateNationality;
        private MaterialSkin.Controls.MaterialComboBox CmbCreateSalutation;
        private System.Windows.Forms.Panel PnlCreateInfoGeneral;
        private System.Windows.Forms.Panel PnlCreateInfoEmployee;
        private System.Windows.Forms.Panel PnlCreateInfoTrainee;
        private System.Windows.Forms.GroupBox GrpCreateType;

        private MaterialSkin.Controls.MaterialTextBox TxtEmployeeNumber;
        private MaterialSkin.Controls.MaterialProgressBar PrgDegreeOfEmployment;
        private System.Windows.Forms.NumericUpDown NumDegreeOfEmployment;
        private System.Windows.Forms.Label LblCreateTypeSelection;
        private MaterialSkin.Controls.MaterialButton CmdCreateCancel;
        private MaterialSkin.Controls.MaterialButton CmdCreatePersonSaveAndNew;
        private MaterialSkin.Controls.MaterialButton CmdNotesAll;
        private System.Windows.Forms.ListBox LstCreateNoteOut;
        private MaterialSkin.Controls.MaterialButton CmdCreateNoteAdd;
        private MaterialSkin.Controls.MaterialButton CmdCreateNoteDelete;
        private MaterialSkin.Controls.MaterialButton CmdCreateNoteEdit;
        private MaterialSkin.Controls.MaterialLabel LblCreateNotes;
        private System.Windows.Forms.Panel PnlCreateInfoCustomer;
        private MaterialSkin.Controls.MaterialLabel LblCreateCompanyName;
        private MaterialSkin.Controls.MaterialComboBox CmbCreateCustomerType;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateCompanyName;
        private MaterialSkin.Controls.MaterialLabel LblCreateCustomerType;
        private MaterialSkin.Controls.MaterialLabel LblCreateCompanyContact;
        private MaterialSkin.Controls.MaterialTextBox TxtCreateCompanyContact;
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
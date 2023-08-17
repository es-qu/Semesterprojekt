using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class FormMain : MaterialForm
    {
        MaterialSkinManager manager = Program.GetStandardManager();

        public enum Tab
        {
            Create,
            Search
        }

        public FormMain()
        {
            InitializeComponent();

            manager.AddFormToManage(this);


            //Countries in ComboBox Nationality
            PopulateCountryComboBox();
            TxtCreateOasiNr.KeyPress += TxtCreateOasiNr_KeyPress;

            DataGridViewSearchResult.BackgroundColor = Color.Gray;
            DataGridViewSearchResult.ForeColor = Color.White;

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
        }

        public FormMain(int selectedTab) : this()
        {
            Tab tab = (Tab)selectedTab;

            switch (tab)
            {
                case Tab.Create:
                    TCtrlMain.SelectedTab = TabCreateEdit;
                    break;
                case Tab.Search:
                    TCtrlMain.SelectedTab = TabSearch;
                    break;

                default:
                    break;
            }
        }

        //FormMain_Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            //Don't show employee & trainee elements.
            PnlCreateInfoEmployee.Visible = false;
            PnlCreateInfoTrainee.Visible = false;
            ChkCreateTrainee.Visible = false;

            //Don't show customer elements.
            PnlCreateInfoCustomer.Visible = false;



        }


        private void TxtCreateOasiNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the key pressed is not a digit and not a dot, consume the key event (do not input the key)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;

                // Show a tooltip to inform the user that only numbers and dots are allowed
                System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
                toolTip.Show("Only numbers and dots are allowed", (Control)sender, 0, ((Control)sender).Height, 2000);
            }
        }

        public int checkState;
        private void CmdCreatePerson_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            string gender = RadCreateMale.Checked ? "Male" :
                     RadCreateFemale.Checked ? "Female" :
                     RadCreateOther.Checked ? "Other" : null;

            if (gender == null)
            {
                // Handle the case when no radio button is selected, e.g., show a MessageBox
                MessageBox.Show("Please select a gender");
                return;
            }
            // Check if the first name contains only letters
            Regex regexLetters = new Regex("^[A-Za-z]+$");
            if (!regexLetters.IsMatch(TxtCreateFirstName.Text))
            {
                MessageBox.Show("The first name can contain only letters");
                return;
            }
            if (RadCreateEmployee.Checked)
            {
                if (ChkCreateTrainee.Checked)
                {
                    controller.CreateTrainee(
                TxtCreateFirstName.Text,
                TxtCreateLastName.Text,
                DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                TxtCreateEmployeeNumber.Text,
                checkState = (int)SwtCreateActive.CheckState,
                gender,
                CmbCreateSalutation.SelectedItem?.ToString(),
                TxtCreateTitle.Text,
                TxtCreateAddress.Text,
                TxtCreatePlz.Text,
                TxtCreatePlaceOfResidence.Text,
                CmbCreateNationality.SelectedItem?.ToString(),
                TxtCreateOasiNr.Text,
                TxtCreatePrivatePhone.Text,
                TxtCreateBusnissPhone.Text,
                TxtCreateEmailAddress.Text,
                LstCreateNoteOut.SelectedItem?.ToString(),
                TxtCreateRole.Text,
                TxtCreateDepartement.Text,
                DatCreateDateOfJoining.Value.ToString("yyyy-MM-dd"),
                DatCreateDateOfLeaving.Value.ToString("yyyy-MM-dd"),
                NumCadreLevel.Value.ToString(),
                NumCreateCurrentAppYear.Value.ToString(),
                NumCreateYearOfApp.Value.ToString(),
                this
                );
                }
                else
                {
                    controller.CreateEmployee(
                  TxtCreateFirstName.Text,
                  TxtCreateLastName.Text,
                  DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                  TxtCreateEmployeeNumber.Text,
                  checkState = (int)SwtCreateActive.CheckState,
                  RadCreateMale.Checked ? "1" : "0",
                  CmbCreateSalutation.SelectedItem?.ToString(),
                  TxtCreateTitle.Text,
                  TxtCreateAddress.Text,
                  TxtCreatePlz.Text,
                  TxtCreatePlaceOfResidence.Text,
                  CmbCreateNationality.SelectedItem?.ToString(),
                  TxtCreateOasiNr.Text,
                  TxtCreatePrivatePhone.Text,
                  TxtCreateBusnissPhone.Text,
                  TxtCreateEmailAddress.Text,
                  LstCreateNoteOut.SelectedItem?.ToString(),
                  TxtCreateRole.Text,
                  TxtCreateDepartement.Text,
                  DatCreateDateOfJoining.Value.ToString("yyyy-MM-dd"),
                  DatCreateDateOfLeaving.Value.ToString("yyyy-MM-dd"),
                  NumCadreLevel.Value.ToString(),
                  this

               );
                }
            }
        }

        //private void CmdExecSearch_Click(object sender, EventArgs e)
        //{
        //    string searchText = TxtSearch.Text;
        //    List<Person> people = SqliteDateAccess.LoadPeople(searchText);
        //    if (people.Count == 0)
        //    {
        //        txtOutput.Text = "No users found.";
        //    }
        //    else
        //    {
        //        txtOutput.Text = "";
        //        foreach (Person person in people)
        //        {
        //            DateTime dob = DateTime.Parse(person.dateOfBirth);
        //            txtOutput.Text += $"First Name: {person.firstName}, Last Name: {person.lastName}, Date of Birth: {dob.ToString("yyyy-MM-dd")}\n";
        //        }
        //    }

        //}

        private void RadCreateCustomer_CheckedChanged(object sender, EventArgs e)
        {

            LblCreateTypeSelection.Visible = false;

            if (RadCreateCustomer.Checked == true)
            {
                PnlCreateInfoCustomer.Visible = true;
            }
            else
            {
                PnlCreateInfoCustomer.Visible = false;
            }
        }

        private void RadCreateEmployee_CheckedChanged(object sender, EventArgs e)
        {
            LblCreateTypeSelection.Visible = false;

            if (RadCreateEmployee.Checked == true)
            {
                PnlCreateInfoEmployee.Visible = true;
                ChkCreateTrainee.Visible = true;
                ChkCreateTrainee.Checked = false;

            }
            else
            {
                PnlCreateInfoEmployee.Visible = false;
                ChkCreateTrainee.Visible = false;

            }

            //Trainee Panel visibility when Radiobuttion Employee gets checked
            if (ChkCreateTrainee.Checked == true && RadCreateEmployee.Checked == true)
            {
                PnlCreateInfoTrainee.Visible = true;
            }
            else
            {
                PnlCreateInfoTrainee.Visible = false;
            }

        }

        private void ChkCreateTrainee_CheckedChanged(object sender, EventArgs e)
        {

            if (ChkCreateTrainee.Checked == true && RadCreateEmployee.Checked == true)
            {
                PnlCreateInfoTrainee.Visible = true;
            }
            else
            {
                PnlCreateInfoTrainee.Visible = false;
            }
        }

        private void NumCreateDegreeOfEmployment_ValueChanged(object sender, EventArgs e)
        {
            PrgDegreeOfEmployment.Value = Convert.ToInt16(NumCreateDegreeOfEmployment.Value);
        }

        //Closes the Create Window when the Button CmdCreateCancel is clicked
        private void CmdCreateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Countries in DropDown
        private void PopulateCountryComboBox()
        {

            // Get the list of all countries using CultureInfo
            List<string> countriesList = new List<string>();
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo region = new RegionInfo(ci.Name);
                if (!countriesList.Contains(region.EnglishName))
                {
                    countriesList.Add(region.EnglishName);
                }
            }

            // Sort the list of countries alphabetically
            countriesList.Sort();

            // Populate the ComboBox with the list of countries
            CmbCreateNationality.DataSource = countriesList;


        }

        private void CmdSearchAdvanced_Click(object sender, EventArgs e)
        {
            //Try to show Advanced Search windows over the Search window of FormMain
            var formAdvancedSearch = new FormSearchAdvanced();
            formAdvancedSearch.Visible = false;
            DialogResult dialogResult = ShowDialog(formAdvancedSearch);

        }

        /// <summary>
        /// Search button click event, searches persons via Controller and SQLite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdSearchExec_Click(object sender, EventArgs e)
        {
            if (TxtSearch.Text != string.Empty)
            {
                string searchTerm = TxtSearch.Text;
                List<Person> res = Controller.SearchContact(searchTerm);

                DataGridViewSearchResult.AutoGenerateColumns = false;
                DataGridViewSearchResult.Columns.Clear();

                DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
                {
                    Name = "idColumn",
                    HeaderText = "ID",
                    DataPropertyName = "Id"
                };
                DataGridViewSearchResult.Columns.Add(idColumn);

                DataGridViewTextBoxColumn firstNameColumn = new DataGridViewTextBoxColumn
                {
                    Name = "firstNameColumn",
                    HeaderText = "First Name",
                    DataPropertyName = "firstName"
                };
                DataGridViewSearchResult.Columns.Add(firstNameColumn);

                DataGridViewTextBoxColumn lastNameColumn = new DataGridViewTextBoxColumn
                {
                    Name = "lastNameColumn",
                    HeaderText = "Last Name",
                    DataPropertyName = "lastName"
                };
                DataGridViewSearchResult.Columns.Add(lastNameColumn);

                DataGridViewSearchResult.DataSource = res;

                DataGridViewSearchResult.CurrentCell = DataGridViewSearchResult.FirstDisplayedCell;
                int currentSelectedCol = DataGridViewSearchResult.CurrentCell.ColumnIndex;
            }
        }
    }
}





using ContactManager.Model;
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

        List<Person> searchResults;

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

        /// <summary>
        /// Show popup window with more search options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdSearchAdvanced_Click(object sender, EventArgs e)
        {
            List<object> searchParams = new List<object>();

            FormSearchAdvanced formSearchAdvanced = new FormSearchAdvanced();

            if (formSearchAdvanced.ShowDialog() == DialogResult.OK)
            {
                searchParams = formSearchAdvanced.searchParams;
            }
        }

        /// <summary>
        /// Search persons with fulltext search or filters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdSearchExec_Click(object sender, EventArgs e)
        {
            searchResults = null;

            DataGridViewSearchResult.CurrentCell = null;
            DataGridViewSearchResult.AutoGenerateColumns = false;
            DataGridViewSearchResult.Columns.Clear();
            DataGridViewSearchResult.DataSource = null;

            LblSearchResultCounter.Text = "Results: 0";

            if (TxtSearch.Text != string.Empty)
            {
                string searchTerm = TxtSearch.Text;
                searchResults = Controller.SearchContactsByFullText(searchTerm, ChkSearchInactive.Checked);
            }
            else
            {
                List<Type> types = new List<Type>();
                List<string> searchParams = new List<string>();

                // Type filter
                if (ChkSearchTypeCustomer.Checked) types.Add(typeof(Customer));
                if (ChkSearchTypeEmployee.Checked) types.Add(typeof(Employee));
                if (ChkSearchTypeTrainee.Checked) types.Add(typeof(Trainee));
                if (types.Count == 3) types.Clear();

                // Inactive filter
                if (ChkSearchInactive.Checked) searchParams.Add("(status = 0 OR status = 1)");
                else searchParams.Add("status = 1");

                // First name, last name
                if (TxtSearchFirstName.Text != string.Empty) searchParams.Add($"firstName LIKE '{TxtSearchFirstName.Text}'");
                if (TxtSearchLastName.Text != string.Empty) searchParams.Add($"lastName LIKE '{TxtSearchLastName.Text}'");

                // Customer no. / employee no.
                if (TxtSearchNumber.Text != string.Empty) searchParams.Add($"(CustomerNumber = '{TxtSearchNumber.Text}' OR EmployeeNumber = '{TxtSearchNumber.Text}')");

                // Search address, place of residence
                if (TxtSearchAddress.Text != string.Empty) searchParams.Add($"street LIKE '{TxtSearchAddress.Text}'");
                if (TxtSearchPlaceOfResidence.Text != string.Empty) searchParams.Add($"placeOfResidence LIKE '{TxtSearchPlaceOfResidence.Text}'");

                // Date of birth
                if (TxtSearchDateOfBirth.Text != string.Empty) searchParams.Add($"dateOfBirth LIKE '{TxtSearchDateOfBirth.Text}'");

                searchResults = (searchParams.Count > 0)
                    ? Controller.SearchContactsByFilters((types.Count > 0) ? types : new List<Type>() { typeof(Person) }, searchParams)
                    : null;
            }


            if (searchResults != null)
            {
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

                DataGridViewTextBoxColumn dateOfBirthColumn = new DataGridViewTextBoxColumn
                {
                    Name = "dateOfBirthColumn",
                    HeaderText = "Date of birth",
                    DataPropertyName = "dateOfBirth"
                };
                DataGridViewSearchResult.Columns.Add(dateOfBirthColumn);

                if (searchResults.Count > 0)
                {
                    LblNoResults.Visible = false;

                    DataGridViewSearchResult.DataSource = searchResults;

                    DataGridViewSearchResult.CurrentCell = DataGridViewSearchResult.FirstDisplayedCell;
                    int currentSelectedCol = DataGridViewSearchResult.CurrentCell.ColumnIndex;
                }
                else
                {
                    LblNoResults.BackColor = Color.DimGray;
                    LblNoResults.Visible = true;
                }

                LblSearchResultCounter.Text = $"Results: {searchResults.Count}";
            }
            else
            {
                LblNoResults.BackColor = Color.DimGray;
                LblNoResults.Visible = true;
            }
        }

        /// <summary>
        /// When the selected field in seach results changes, update the preview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewSearchResultSelectionChanged_CellClick(object sender, EventArgs e)
        {
            if (DataGridViewSearchResult.Columns.Count > 0)
            {
                if (DataGridViewSearchResult.SelectedCells.Count > 0 && DataGridViewSearchResult.SelectedCells[0].RowIndex >= 0)
                {
                    DataGridViewRow currentRow = DataGridViewSearchResult.Rows[DataGridViewSearchResult.SelectedCells[0].RowIndex];

                    if (currentRow != null && currentRow.Index < searchResults.Count)
                    {
                        var clickedPerson = searchResults[currentRow.Index];

                        LblSearchViewStatus.Text = (clickedPerson.status != 0) ? "Active" : "Inactive";
                        LblSearchViewTitle.Text = clickedPerson.title;
                        LblSearchViewFirstName.Text = clickedPerson.firstName;
                        LblSearchViewLastName.Text = clickedPerson.lastName;
                        LblSearchViewAddress.Text = clickedPerson.street;
                        LblSearchViewPostalCode.Text = clickedPerson.postalCode;
                        LblSearchViewPlaceOfResidence.Text = clickedPerson.placeOfResidence;
                        LblSearchViewNationality.Text = clickedPerson.nationality;
                        LblSearchViewOasiNumber.Text = clickedPerson.socialSecurityNumber;
                        LblSearchViewDateOfBirth.Text = clickedPerson.dateOfBirth;
                        LblSearchViewEmailAddress.Text = clickedPerson.email;
                        LblSearchViewPrivatePhone.Text = clickedPerson.phoneNumberPrivat;
                        LblSearchViewBusinessPhone.Text = clickedPerson.phoneNumberBusiness;
                        //LblSearchViewBusinessAddress.Text = clickedPerson;
                    }
                }
                else
                {
                    LblSearchViewTitle.Text = "-";
                    LblSearchViewFirstName.Text = "-";
                    LblSearchViewLastName.Text = "-";
                    LblSearchViewAddress.Text = "-";
                    LblSearchViewPostalCode.Text = "-";
                    LblSearchViewPlaceOfResidence.Text = "-";
                    LblSearchViewNationality.Text = "-";
                    LblSearchViewOasiNumber.Text = "-";
                    LblSearchViewDateOfBirth.Text = "-";
                    LblSearchViewEmailAddress.Text = "-";
                    LblSearchViewPrivatePhone.Text = "-";
                    LblSearchViewBusinessPhone.Text = "-";
                    //LblSearchViewBusinessAddress.Text = "-";
                }
            }
        }

        /// <summary>
        /// Search on enter keydown event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmdSearchExec_Click(sender, e);
            }
        }

        /// <summary>
        /// Clear fulltext input when entering filter inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFilters_Enter(object sender, EventArgs e)
        {
            TxtSearch.Clear();
        }

        /// <summary>
        /// Clear filters when entering fulltext input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            TxtSearchFirstName.Clear();
            TxtSearchLastName.Clear();
            TxtSearchNumber.Clear();
            TxtSearchAddress.Clear();
            TxtSearchPlaceOfResidence.Clear();
            TxtSearchDateOfBirth.Clear();
        }
    }
}
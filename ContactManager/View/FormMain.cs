using ContactManager.Entity;
using ContactManager.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class FormMain : MaterialForm
    {
        MaterialSkinManager manager = Program.GetStandardManager();

        public SearchFilters filters = new SearchFilters();

        List<object> searchResults;
        Person currentContact;
        List<Note> currentContactNotes;
        List<object> importContent;

        public enum Tab
        {
            Create,
            Search,
            Import
        }

        public FormMain()
        {
            InitializeComponent();

            manager.AddFormToManage(this);


            //Countries in ComboBox Nationality
            PopulateCountryComboBox();
            TxtCreateOasiNr.KeyPress += TxtCreateOasiNr_KeyPress;

            // Disable the employee && Customer number text box
            TxtCreateEmployeeNumber.Enabled = false;
            TxtCreateCustomerNumber.Enabled = false;


        }

        public string selectedPerson;

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

                case Tab.Import:
                    TCtrlMain.SelectedTab = TabImport;
                    break;

                default:
                    TCtrlMain.SelectedTab = TabSearch;
                    break;
            }
        }

        //FormMain_Load
        private void ResetFormState()
        {
            //Don't show employee & trainee elements.
            PnlCreateInfoEmployee.Visible = false;
            PnlCreateInfoTrainee.Visible = false;
            ChkCreateTrainee.Visible = false;

            //Don't show customer elements.
            PnlCreateInfoCustomer.Visible = false;

            // Reset CheckState
            ChkCreateTrainee.Checked = false;
            isEditMode = false;

            // Clear ComboBoxes
            CmbCreateSalutation.SelectedIndex = 0;
            CmbCreateSalutation.Refresh();

            CmbCreateNationality.SelectedIndex = -1;
            CmbCreateNationality.Refresh();

            CmbCreateCustomerType.SelectedIndex = 0;
            CmbCreateCustomerType.Refresh();


            // Clear TextBoxes
            TxtCreateTitle.Clear();
            TxtCreateFirstName.Clear();
            TxtCreateLastName.Clear();
            TxtCreateAddress.Clear();
            TxtCreatePlz.Clear();
            TxtCreatePlaceOfResidence.Clear();
            TxtCreateOasiNr.Clear();
            TxtCreatePrivatePhone.Clear();
            TxtCreateEmailAddress.Clear();
            TxtCreateBusinessPhone.Clear();
            TxtCreateRole.Clear();
            TxtCreateDepartement.Clear();
            TxtCreateEmployeeNumber.Clear();
            TxtCreateCompanyName.Clear();
            TxtCreateCompanyContact.Clear();
            TxtCreateCustomerNumber.Clear();
            TxtCreateBusinessAddress.Clear();

            // Reset DateTimePickers
            DatCreateBirthday.Value = DateTime.Now.AddYears(-20);
            DatCreateDateOfJoining.Value = DateTime.Now;
            DatCreateDateOfLeaving.Value = new DateTime(9998, 12, 31);

            // Reset Numeric Indicator
            NumCadreLevel.Value = 0;
            NumCreateDegreeOfEmployment.Value = 0;

            // Reset RadioButton
            RadCreateFemale.Checked = false;
            RadCreateMale.Checked = false;
            RadCreateOther.Checked = false;
            RadCreateCustomer.Checked = false;
            RadCreateCustomer.Enabled = true;
            RadCreateEmployee.Enabled = true;
            RadCreateEmployee.Checked = false;

        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            ResetFormState();
        }


        private void TxtCreateOasiNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the key pressed is not a digit and not a dot, consume the key event (do not input the key)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;

                // Show a tooltip to inform the user that only numbers and dots are allowed
                System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
                toolTip.Show("Only numbers allowed", (Control)sender, 0, ((Control)sender).Height, 2000);
            }
        }

        public List<string> GetIdsFromCurrentContactNotes()
        {
            List<string> ids = new List<string>();

            if (currentContactNotes != null)
            {
                foreach (Note note in currentContactNotes)
                {
                    ids.Add(note.Id);
                }
            }

            return ids;
        }

        public Person CreatePersonFromForm()
        {
            string gender = RadCreateMale.Checked ? "Male" :
                RadCreateFemale.Checked ? "Female" :
                RadCreateOther.Checked ? "Other" : null;

            if (RadCreateCustomer.Checked)
            {
                return new Customer
                {
                    Active = (int)SwtCreateActive.CheckState,
                    Gender = gender,
                    Salutation = CmbCreateSalutation.SelectedItem?.ToString(),
                    Title = TxtCreateTitle.Text,
                    FirstName = TxtCreateFirstName.Text,
                    LastName = TxtCreateLastName.Text,
                    Address = TxtCreateAddress.Text,
                    PostalCode = TxtCreatePlz.Text,
                    PlaceOfResidence = TxtCreatePlaceOfResidence.Text,
                    Nationality = CmbCreateNationality.SelectedItem?.ToString(),
                    OasiNumber = TxtCreateOasiNr.Text,
                    DateOfBirth = DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                    PrivatePhone = TxtCreatePrivatePhone.Text,
                    BusinessAddress = TxtCreateBusinessAddress.Text,
                    BusinessPhone = TxtCreateBusinessPhone.Text,
                    EmailAddress = TxtCreateEmailAddress.Text,
                    NoteIds = GetIdsFromCurrentContactNotes(),
                    CompanyName = TxtCreateCompanyName.Text,
                    CustomerType = CmbCreateCustomerType.Text,
                    CompanyContact = TxtCreateCompanyContact.Text,
                    CustomerNumber = TxtCreateCustomerNumber.Text
                };
            }
            else if (RadCreateEmployee.Checked)
            {
                var employee = new Employee
                {
                    Active = (int)SwtCreateActive.CheckState,
                    Gender = gender,
                    Salutation = CmbCreateSalutation.SelectedItem?.ToString(),
                    Title = TxtCreateTitle.Text,
                    FirstName = TxtCreateFirstName.Text,
                    LastName = TxtCreateLastName.Text,
                    Address = TxtCreateAddress.Text,
                    PostalCode = TxtCreatePlz.Text,
                    PlaceOfResidence = TxtCreatePlaceOfResidence.Text,
                    Nationality = CmbCreateNationality.SelectedItem?.ToString(),
                    OasiNumber = TxtCreateOasiNr.Text,
                    DateOfBirth = DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                    PrivatePhone = TxtCreatePrivatePhone.Text,
                    BusinessAddress = TxtCreateBusinessAddress.Text,
                    BusinessPhone = TxtCreateBusinessPhone.Text,
                    EmailAddress = TxtCreateEmailAddress.Text,
                    NoteIds = GetIdsFromCurrentContactNotes(),
                    Role = TxtCreateRole.Text,
                    Department = TxtCreateDepartement.Text,
                    EmployeeNumber = TxtCreateEmployeeNumber.Text,
                    DateOfJoining = DatCreateDateOfJoining.Value.ToString("yyyy-MM-dd"),
                    DateOfLeaving = DatCreateDateOfLeaving.Value.ToString("yyyy-MM-dd"),
                    CadreLevel = NumCadreLevel.Value.ToString(),
                    DegreeOfEmployment = NumCreateDegreeOfEmployment.Value.ToString()
                };

                if (ChkCreateTrainee.Checked)
                {
                    return new Trainee
                    {
                        Active = (int)SwtCreateActive.CheckState,
                        Gender = gender,
                        Salutation = CmbCreateSalutation.SelectedItem?.ToString(),
                        Title = TxtCreateTitle.Text,
                        FirstName = TxtCreateFirstName.Text,
                        LastName = TxtCreateLastName.Text,
                        Address = TxtCreateAddress.Text,
                        PostalCode = TxtCreatePlz.Text,
                        PlaceOfResidence = TxtCreatePlaceOfResidence.Text,
                        Nationality = CmbCreateNationality.SelectedItem?.ToString(),
                        OasiNumber = TxtCreateOasiNr.Text,
                        DateOfBirth = DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                        PrivatePhone = TxtCreatePrivatePhone.Text,
                        BusinessAddress = TxtCreateBusinessAddress.Text,
                        BusinessPhone = TxtCreateBusinessPhone.Text,
                        EmailAddress = TxtCreateEmailAddress.Text,
                        NoteIds = GetIdsFromCurrentContactNotes(),
                        Role = TxtCreateRole.Text,
                        Department = TxtCreateDepartement.Text,
                        EmployeeNumber = TxtCreateEmployeeNumber.Text,
                        DateOfJoining = DatCreateDateOfJoining.Value.ToString("yyyy-MM-dd"),
                        DateOfLeaving = DatCreateDateOfLeaving.Value.ToString("yyyy-MM-dd"),
                        CadreLevel = NumCadreLevel.Value.ToString(),
                        DegreeOfEmployment = NumCreateDegreeOfEmployment.Value.ToString(),
                        CurrentApprenticeshipYear = NumCreateCurrentAppYear.Value.ToString(),
                        YearsOfApprenticeship = NumCreateYearOfApp.Value.ToString()
                    };
                }
                else
                {
                    return employee;
                }
            }
            else
            {
                throw new Exception("Neither Customer nor Employee was selected");
            }
        }
        private LogTable LogForm(string eventType)
        {

            string gender = RadCreateMale.Checked ? "Male" :
                RadCreateFemale.Checked ? "Female" :
                RadCreateOther.Checked ? "Other" : null;
            LogTable logInfo = new LogTable
            {
                EventType = eventType,
                Active = (int)SwtCreateActive.CheckState,
                Gender = gender,
                Salutation = CmbCreateSalutation.SelectedItem?.ToString(),
                Title = TxtCreateTitle.Text,
                FirstName = TxtCreateFirstName.Text,
                LastName = TxtCreateLastName.Text,
                Address = TxtCreateAddress.Text,
                PostalCode = TxtCreatePlz.Text,
                PlaceOfResidence = TxtCreatePlaceOfResidence.Text,
                Nationality = CmbCreateNationality.SelectedItem?.ToString(),
                OasiNumber = TxtCreateOasiNr.Text,
                DateOfBirth = DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                PrivatePhone = TxtCreatePrivatePhone.Text,
                BusinessAddress = TxtCreateBusinessAddress.Text,
                BusinessPhone = TxtCreateBusinessPhone.Text,
                EmailAddress = TxtCreateEmailAddress.Text,
                //CommaSeparatedNoteIds = string.Join(',', GetIdsFromCurrentContactNotes()),
                Role = TxtCreateRole.Text,
                Department = TxtCreateDepartement.Text,
                DateOfJoining = DatCreateDateOfJoining.Value.ToString("yyyy-MM-dd"),
                DateOfLeaving = DatCreateDateOfLeaving.Value.ToString("yyyy-MM-dd"),
                CadreLevel = NumCadreLevel.Value.ToString(),
                DegreeOfEmployment = NumCreateDegreeOfEmployment.Value.ToString(),
                CompanyName = TxtCreateCompanyName.Text,
                CustomerType = CmbCreateCustomerType.Text,
                CompanyContact = TxtCreateCompanyContact.Text,
                CurrentApprenticeshipYear = NumCreateCurrentAppYear.Value.ToString("yyyy-MM-dd"),
                YearsOfApprenticeship = NumCreateYearOfApp.Value.ToString("yyyy-MM-dd"),
                CustomerNumber = TxtCreateCustomerNumber.Text,
                EmployeeNumber = TxtCreateEmployeeNumber.Text
            };

            return logInfo;
        }


        private void LogAndCloseIfSuccessful(bool success, string successEvent, string failureEvent)
        {
            string eventType = success ? successEvent : failureEvent;
            LogTable logInfo = LogForm(eventType);
            //Controller controller = new Controller();
            //controller.Log(logInfo);

            if (success)
            {
                this.Close();
            }
        }

        private void DeleteAndRecreate(string identifier, Func<string, bool> deleteFunc, Func<bool> createFunc, Action<bool, string, string> logAction)
        {
            bool deletionSuccessful = deleteFunc(identifier);
            string deletionEvent = deletionSuccessful ? "UpdateSuccess" : "UpdateFailure";
            logAction(deletionSuccessful, deletionEvent, deletionEvent);

            if (deletionSuccessful)
            {
                bool creationSuccessful = createFunc();
                // Log it as an update instead of a creation
                string creationEvent = creationSuccessful ? "UpdateSuccess" : "UpdateFailure";
                logAction(creationSuccessful, creationEvent, creationEvent);
            }
        }

        private void LogAndClearIfSuccessful(bool success, string successEvent, string failureEvent)
        {
            string eventType = success ? successEvent : failureEvent;
            LogTable logInfo = LogForm(eventType);
            //Controller controller = new Controller();
            //controller.Log(logInfo);

            if (success)
            {
                TCtrlMain.SelectedTab = TabCreateEdit;
                ResetFormState();
            }
        }

        public int checkState;
        private void CreateAndSavePerson(Action<bool, string, string> logAction)
        {
            Controller controller = new Controller();
            var person = CreatePersonFromForm();
            currentContact = person;

            if (isEditMode == false)
            {
                if (person is Trainee trainee)
                {
                    bool success = controller.CreateTrainee(trainee, this, false);
                    logAction(success, "TraineCreationSuccess", "TraineCreationFailure");
                }
                else if (person is Employee employee)
                {
                    bool success = controller.CreateEmployee(employee, this, false);
                    logAction(success, "EmployeeCreationSuccess", "EmployeeCreationFailure");
                }
                else if (person is Customer customer)
                {
                    bool success = controller.CreateCustomer(customer, this, false);
                    logAction(success, "CustomerCreationSuccess", "CustomerCreationFailure");
                }
            }
            else
            {
                Action<bool, string, string> deleteAndRecreateLogAction = isEditMode && checkState == 0 ? logAction : LogAndCloseIfSuccessful;

                if (person is Trainee trainee)
                {
                    DeleteAndRecreate(TxtCreateEmployeeNumber.Text, (empNumber) => SqliteDataAccess.DeleteEmployee(empNumber), () => controller.CreateTrainee(trainee, this, true), deleteAndRecreateLogAction);
                }
                else if (person is Employee employee)
                {
                    DeleteAndRecreate(TxtCreateEmployeeNumber.Text, (empNumber) => SqliteDataAccess.DeleteEmployee(empNumber), () => controller.CreateEmployee(employee, this, true), deleteAndRecreateLogAction);
                }
                else if (person is Customer customer)
                {
                    DeleteAndRecreate(TxtCreateCustomerNumber.Text, (custNumber) => SqliteDataAccess.DeleteCustomer(custNumber), () => controller.CreateCustomer(customer, this, true), deleteAndRecreateLogAction);
                }
            }
        }

        private void CmdCreatePerson_Click(object sender, EventArgs e)
        {
            if (CheckMandatroyFields())
            {
                CreateAndSavePerson(LogAndCloseIfSuccessful);
            }
        }

        private void CmdCreatePersonSaveAndNew_Click(object sender, EventArgs e)
        {
            if (CheckMandatroyFields())
            {
                CreateAndSavePerson(LogAndClearIfSuccessful);
            }
        }

        private bool CheckMandatroyFields()
        {
            // Variables for If-Statements
            Regex regexLetters = new Regex("^[A-Za-zÄ-Üä-ü ]+$");
            Regex regexEmailValidation = new Regex("^[^@\\s]+@[^@\\s]+\\.(\\w{1,2}\\D)$");
            var dateMin = new DateTime(1900, 1, 1);
            var dateMax = new DateTime(2100, 1, 1);


            // Handle the case when no radio button is selected for person type
            if (!RadCreateCustomer.Checked && !RadCreateEmployee.Checked)
            {
                MessageBox.Show("Please select a type");
                return false;
            }

            // Handle the case when no radio button is selected for gender
            if (!RadCreateMale.Checked && !RadCreateFemale.Checked && !RadCreateOther.Checked)
            {
                MessageBox.Show("Please select a gender");
                return false;
            }

            // Check if the first name contains only letters and is not empty
            if (TxtCreateFirstName.Text == "")
            {
                MessageBox.Show("The first name can not be empty");
                return false;
            }
            else if (!regexLetters.IsMatch(TxtCreateFirstName.Text))
            {
                MessageBox.Show("The first name can only contain letters");
                return false;
            }

            // Check if the last name contains only letters and is not empty
            if (TxtCreateLastName.Text == "")
            {
                MessageBox.Show("The last name can not be empty");
                return false;
            }
            else if (!regexLetters.IsMatch(TxtCreateLastName.Text))
            {
                MessageBox.Show("The last name can only contain letters");
                return false;
            }

            // Check if the address is not empty
            if (TxtCreateAddress.Text == "")
            {
                MessageBox.Show("The address can not be empty");
                return false;
            }

            // Check if the postal code is not empty
            if (TxtCreatePlz.Text == "")
            {
                MessageBox.Show("The postal code can not be empty");
                return false;
            }

            // Check if the Place of residence is not empty
            if (TxtCreatePlaceOfResidence.Text == "")
            {
                MessageBox.Show("The place of residence can not be empty");
                return false;
            }

            // Check if the Birthday is changed
            if (dateMax > DatCreateBirthday.Value && DatCreateBirthday.Value > dateMin && DatCreateBirthday.Value < DateTime.Today)
            {
                Debug.WriteLine("Date is correct");
            }
            else
            {
                MessageBox.Show("Please set the date of birth");
                return false;
            }

            // Check if the Email is not empty
            if (TxtCreateEmailAddress.Text == "")
            {
                MessageBox.Show("The email address can not be empty");
                return false;
            }
            else if (!regexEmailValidation.IsMatch(TxtCreateEmailAddress.Text))
            {
                MessageBox.Show("The email address needs to be valid");
                return false;
            }


            //--------------------------------------
            //              Customer
            //--------------------------------------
            if (RadCreateCustomer.Checked)
            {
                // Check if the customer Type has changed
                if (CmbCreateCustomerType.Text == "-" || CmbCreateCustomerType.Text == "")
                {
                    MessageBox.Show("Please select the customer type (A-E)");
                    return false;
                }

                // Check if the Company Name is not empty
                if (TxtCreateCompanyName.Text == "")
                {
                    MessageBox.Show("The company name can not be empty");
                    return false;
                }

                // Check if the Company contact is not empty
                if (TxtCreateCompanyContact.Text == "")
                {
                    MessageBox.Show("The company contact can not be empty");
                    return false;
                }
            }
            //--------------------------------------
            //              Employee
            //--------------------------------------
            if (RadCreateEmployee.Checked)
            {
                // Check if the degree of employment is not empty
                if (NumCreateDegreeOfEmployment.Value < 1)
                {
                    MessageBox.Show("The degree of employment needs to be over zero");
                    return false;
                }

                // Check if the date of joining is changed
                if (dateMax > DatCreateDateOfJoining.Value && DatCreateDateOfJoining.Value > dateMin)
                {
                    Debug.WriteLine("Date is correct");
                }
                else
                {
                    MessageBox.Show("Please set the date of joining");
                    return false;
                }


                // looks if Employee is a Trainee
                if (ChkCreateTrainee.Checked)
                {
                    // Check if the years of apprenticeship is not empty
                    if (NumCreateYearOfApp.Value < 1)
                    {
                        MessageBox.Show("The years of apprenticeship needs to be over zero");
                        return false;
                    }
                }
            }

            //Everthing Mandatory is filled out
            return true;
        }

        // Falg for Customer and employee
        private bool isEditMode = false;
        private void RadCreateCustomer_CheckedChanged(object sender, EventArgs e)
        {
            LblCreateTypeSelection.Visible = false;

            if (RadCreateCustomer.Checked == true)
            {
                PnlCreateInfoCustomer.Visible = true;
                // Generate the next Customer number
                if (!isEditMode)
                {
                    TxtCreateCustomerNumber.Text = SqliteDataAccess.GetNextNumber("Customer", "CustomerNumber", "CUST");
                }
                else
                {

                    // Get existing employee number
                    TxtCreateEmployeeNumber.Text = selectedPerson;

                }
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
                if (!isEditMode)
                {
                    // Generate the next employee number
                    TxtCreateEmployeeNumber.Text = SqliteDataAccess.GetNextNumber("Employee", "EmployeeNumber", "EMP");
                }
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
            // Save the filter input states to sync them later with advanced search GUI
            storeSearchFilters();

            FormSearchAdvanced formSearchAdvanced = new FormSearchAdvanced(this);
            formSearchAdvanced.ShowDialog();
        }

        /// <summary>
        /// Search persons with fulltext search or filters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CmdSearchExec_Click(object sender, EventArgs e)
        {
            searchResults = null;
            currentContact = null;
            currentContactNotes = null;

            DataGridViewSearchResult.CurrentCell = null;
            DataGridViewSearchResult.AutoGenerateColumns = false;
            DataGridViewSearchResult.Columns.Clear();
            DataGridViewSearchResult.DataSource = null;

            DataGridViewSearchNotes.CurrentCell = null;
            DataGridViewSearchNotes.AutoGenerateColumns = false;
            DataGridViewSearchNotes.Columns.Clear();
            DataGridViewSearchNotes.DataSource = null;

            LblSearchResultCounter.Text = "Results: 0";

            storeSearchFilters();

            if (TxtSearch.Text != string.Empty)
            {
                // Fulltext search

                string searchTerm = TxtSearch.Text;
                searchResults = Controller.SearchContactsByFullText(filters, searchTerm);
            }
            else
            {
                if (!Controller.FiltersAreClear(filters))
                {
                    // Filter search
                    searchResults = Controller.SearchContactsByFilters(filters);
                }
                else
                {
                    string searchTerm = "";
                    searchResults = Controller.SearchContactsByFullText(filters, searchTerm);
                }
            }


            // Display the results and get notes

            if (searchResults != null)
            {
                // Format search results
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

                DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn
                {
                    Name = "statusColumn",
                    HeaderText = "Status",
                    DataPropertyName = "status"
                };
                DataGridViewSearchResult.Columns.Add(statusColumn);

                DataGridViewSearchResult.CellFormatting += DataGridViewSearchResult_CellFormatting;

                if (searchResults.Count > 0)
                {
                    LblNoResults.Visible = false;

                    DataGridViewSearchResult.DataSource = searchResults;

                    DataGridViewSearchResult.CurrentCell = DataGridViewSearchResult.FirstDisplayedCell;
                    int currentSelectedRow = DataGridViewSearchResult.CurrentCell.RowIndex;

                    currentContact = (Person)searchResults[currentSelectedRow];
                    currentContactNotes = Controller.GetNotes(currentContact.NoteIds);

                    // Format notes
                    DataGridViewTextBoxColumn contentColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "contentColumn",
                        HeaderText = "Content",
                        DataPropertyName = "Content"
                    };
                    DataGridViewSearchNotes.Columns.Add(contentColumn);

                    DataGridViewTextBoxColumn editTimestampColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "editTimestampColumn",
                        HeaderText = "Last Edit",
                        DataPropertyName = "EditTimestamp"
                    };
                    DataGridViewSearchNotes.Columns.Add(editTimestampColumn);

                    DataGridViewTextBoxColumn createTimestampColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "createTimestampColumn",
                        HeaderText = "Created",
                        DataPropertyName = "CreateTimestamp"
                    };
                    DataGridViewSearchNotes.Columns.Add(createTimestampColumn);

                    DataGridViewSearchNotes.DataSource = currentContactNotes;
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
        /// Format the result in status column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewSearchResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DataGridViewSearchResult.Columns["statusColumn"].Index && e.RowIndex >= 0)
            {
                if (searchResults != null)
                {
                    if (searchResults.Count > 0)
                    {
                        Person res = (Person)searchResults[e.RowIndex];

                        e.Value = (res.Active == 0) ? "Inactive" : "Active";
                    }
                }
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

                        // Enable/disable buttons
                        CmdSearchPersonEdit.Enabled = true;
                        CmdSearchPersonDelete.Enabled = true;
                        CmdSearchAddNote.Enabled = true;
                        CmdSearchDeleteNote.Enabled = false;
                        CmdSearchSaveNote.Enabled = false;

                        var clickedPerson = (Person)searchResults[currentRow.Index];
                        LblSearchPreviewStatusOutput.Text = (clickedPerson.Active != 0) ? "Active" : "Inactive";
                        LblSearchPreviewTitleOutput.Text = clickedPerson.Title;
                        LblSearchPreviewGenderOutput.Text = clickedPerson.Gender;
                        LblSearchPreviewSalutationOutput.Text = clickedPerson.Salutation;
                        LblSearchPreviewFirstNameOutput.Text = clickedPerson.FirstName;
                        LblSearchPreviewLastNameOutput.Text = clickedPerson.LastName;
                        LblSearchPreviewAddressOutput.Text = clickedPerson.Address;
                        LblSearchPreviewPostalCodeOutput.Text = clickedPerson.PostalCode;
                        LblSearchPreviewPlaceOfResidenceOutput.Text = clickedPerson.PlaceOfResidence;
                        LblSearchPreviewNationalityOutput.Text = clickedPerson.Nationality;
                        LblSearchPreviewOasiNumberOutput.Text = clickedPerson.OasiNumber;
                        LblSearchPreviewDateOfBirthOutput.Text = clickedPerson.DateOfBirth;
                        LblSearchPreviewEmailAddressOutput.Text = clickedPerson.EmailAddress;
                        LblSearchPreviewPrivatePhoneOutput.Text = clickedPerson.PrivatePhone;
                        LblSearchPreviewBusinessPhoneOutput.Text = clickedPerson.BusinessPhone;
                        LblSearchPreviewBusinessAddressOutput.Text = clickedPerson.BusinessAddress;
                        DataGridViewSearchNotes.DataSource = currentContactNotes;

                        // Clear type specific informations

                        LblSearchPreviewNumberOutput.Text = "-";
                        LblSearchPreviewTypeOutput.Text = "-";
                        LblSearchPreviewCustomerTypeOutput.Text = "-";
                        LblSearchPreviewCompanyNameOutput.Text = "-";
                        LblSearchPreviewCompanyContactOutput.Text = "-";

                        LblSearchPreviewDegreeOfEmploymentOutput.Text = "-";
                        LblSearchPreviewDepartementOutput.Text = "-";
                        LblSearchPreviewRoleOutput.Text = "-";
                        LblSearchPreviewCadreLevelOutput.Text = "-";
                        LblSearchPreviewDateOfJoiningOutput.Text = "-";
                        LblSearchPreviewDateOfLeavingOutput.Text = "-";

                        LblSearchPreviewCurrentAppYearOutput.Text = "-";
                        LblSearchPreviewYearsOfAppOutput.Text = "-";

                        PnlSearchPreviewCustomer.Visible = false;
                        PnlSearchPreviewEmployee.Visible = false;
                        PnlSearchPreviewTrainee.Visible = false;

                        var type = searchResults[currentRow.Index].GetType();

                        if (type == typeof(Customer))
                        {
                            Customer customer = (Customer)searchResults[currentRow.Index];

                            LblSearchPreviewNumberOutput.Text = customer.CustomerNumber;
                            LblSearchPreviewTypeOutput.Text = "Customer";
                            LblSearchPreviewCustomerTypeOutput.Text = customer.CustomerType;
                            LblSearchPreviewCompanyNameOutput.Text = customer.CompanyName;
                            LblSearchPreviewCompanyContactOutput.Text = customer.CompanyContact;

                            PnlSearchPreviewCustomer.Visible = true;
                            selectedPerson = customer.CustomerNumber;
                        }
                        else if (type == typeof(Employee) || type == typeof(Trainee))
                        {
                            Employee employee = (Employee)searchResults[currentRow.Index];

                            if (type == typeof(Trainee))
                            {
                                Trainee trainee = (Trainee)searchResults[currentRow.Index];
                                LblSearchPreviewTypeOutput.Text = "Trainee";

                                LblSearchPreviewCurrentAppYearOutput.Text = trainee.CurrentApprenticeshipYear;
                                LblSearchPreviewYearsOfAppOutput.Text = trainee.YearsOfApprenticeship;

                                PnlSearchPreviewTrainee.Visible = true;
                            }
                            else
                            {
                                LblSearchPreviewTypeOutput.Text = "Employee";
                            }

                            LblSearchPreviewNumberOutput.Text = employee.EmployeeNumber;

                            selectedPerson = employee.EmployeeNumber;

                            LblSearchPreviewDegreeOfEmploymentOutput.Text = employee.DegreeOfEmployment;
                            LblSearchPreviewDepartementOutput.Text = employee.Department;
                            LblSearchPreviewRoleOutput.Text = employee.Role;
                            LblSearchPreviewCadreLevelOutput.Text = employee.CadreLevel;
                            LblSearchPreviewDateOfJoiningOutput.Text = employee.DateOfJoining;
                            LblSearchPreviewDateOfLeavingOutput.Text = employee.DateOfLeaving;

                            PnlSearchPreviewEmployee.Visible = true;
                        }
                        else
                        {
                            LblSearchPreviewNumber.Text = "-";
                            LblSearchPreviewType.Text = "-";
                            LblSearchPreviewCustomerTypeOutput.Text = "-";
                            LblSearchPreviewCompanyNameOutput.Text = "-";
                            LblSearchPreviewCompanyContactOutput.Text = "-";
                        }
                    }
                }
                else
                {
                    // Clear all labels
                    LblSearchPreviewTitleOutput.Text = "-";
                    LblSearchPreviewGenderOutput.Text = "-";
                    LblSearchPreviewSalutationOutput.Text = "-";
                    LblSearchPreviewFirstNameOutput.Text = "-";
                    LblSearchPreviewLastNameOutput.Text = "-";
                    LblSearchPreviewAddressOutput.Text = "-";
                    LblSearchPreviewPostalCodeOutput.Text = "-";
                    LblSearchPreviewPlaceOfResidenceOutput.Text = "-";
                    LblSearchPreviewNationalityOutput.Text = "-";
                    LblSearchPreviewOasiNumberOutput.Text = "-";
                    LblSearchPreviewDateOfBirthOutput.Text = "-";
                    LblSearchPreviewEmailAddressOutput.Text = "-";
                    LblSearchPreviewPrivatePhoneOutput.Text = "-";
                    LblSearchPreviewBusinessPhoneOutput.Text = "-";
                    LblSearchPreviewBusinessAddressOutput.Text = "-";
                    DataGridViewSearchNotes.DataSource = null;

                    LblSearchPreviewNumberOutput.Text = "-";
                    LblSearchPreviewTypeOutput.Text = "-";
                    LblSearchPreviewCustomerTypeOutput.Text = "-";
                    LblSearchPreviewCompanyNameOutput.Text = "-";
                    LblSearchPreviewCompanyContactOutput.Text = "-";

                    LblSearchPreviewDegreeOfEmploymentOutput.Text = "-";
                    LblSearchPreviewDepartementOutput.Text = "-";
                    LblSearchPreviewRoleOutput.Text = "-";
                    LblSearchPreviewCadreLevelOutput.Text = "-";
                    LblSearchPreviewDateOfJoiningOutput.Text = "-";
                    LblSearchPreviewDateOfLeavingOutput.Text = "-";

                    // Disable buttons
                    CmdSearchPersonEdit.Enabled = false;
                    CmdSearchPersonDelete.Enabled = false;
                    CmdSearchAddNote.Enabled = false;
                    CmdSearchDeleteNote.Enabled = false;
                    CmdSearchSaveNote.Enabled = false;
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

        /// <summary>
        /// Sync the search GUI with the input states in filters object
        /// </summary>
        public void syncSearchGUI()
        {
            // Check boxes
            ChkSearchInactive.Checked = filters.SearchInactive;

            ChkSearchTypeCustomer.Checked = filters.TypeCustomer;
            ChkSearchTypeEmployee.Checked = filters.TypeEmployee;
            ChkSearchTypeTrainee.Checked = filters.TypeTrainee;

            // Quick search
            TxtSearchFirstName.Text = filters.FirstName;
            TxtSearchLastName.Text = filters.LastName;
            TxtSearchNumber.Text = filters.Number;
            TxtSearchAddress.Text = filters.Address;
            TxtSearchPlaceOfResidence.Text = filters.PlaceOfResidence;
            TxtSearchDateOfBirth.Text = filters.DateOfBirth;
        }

        /// <summary>
        /// Save the states of all inputs into filters object
        /// </summary>
        public void storeSearchFilters()
        {
            // Check boxes
            filters.SearchInactive = ChkSearchInactive.Checked;

            filters.TypeCustomer = ChkSearchTypeCustomer.Checked;
            filters.TypeEmployee = ChkSearchTypeEmployee.Checked;
            filters.TypeTrainee = ChkSearchTypeTrainee.Checked;

            // Quick search
            filters.FirstName = TxtSearchFirstName.Text;
            filters.LastName = TxtSearchLastName.Text;
            filters.Number = TxtSearchNumber.Text;
            filters.Address = TxtSearchAddress.Text;
            filters.PlaceOfResidence = TxtSearchPlaceOfResidence.Text;
            filters.DateOfBirth = TxtSearchDateOfBirth.Text;
        }

        private void CmdSearchClear_Click(object sender, EventArgs e)
        {
            filters = new SearchFilters();
            syncSearchGUI();
        }

        private void CmdSearchPersonEdit_Click(object sender, EventArgs e)
        {
            isEditMode = true;
            UpdateEmployeeNumber();

            TCtrlMain.SelectedTab = TabCreateEdit;

        }

        private void TCtrlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchResults != null)
            {

                // Visability Delete Button
                CmdCreateDeletePerson.Visible = true;

                // Edit

                DataGridViewRow currentRow = DataGridViewSearchResult.Rows[DataGridViewSearchResult.SelectedCells[0].RowIndex];

                if (currentRow != null && currentRow.Index < searchResults.Count)
                {
                    Person contact = (Person)searchResults[currentRow.Index];

                    // Fill out generic fields
                    SwtCreateActive.Checked = (contact.Active == 0) ? false : true;

                    switch (contact.Gender)
                    {
                        case "Female":
                            RadCreateFemale.Checked = true;
                            break;

                        case "Male":
                            RadCreateMale.Checked = true;
                            break;

                        case "Other":
                            RadCreateOther.Checked = true;
                            break;

                        default:
                            RadCreateFemale.Checked = true;
                            RadCreateMale.Checked = false;
                            RadCreateOther.Checked = false;
                            break;
                    }

                    foreach (var item in CmbCreateSalutation.Items)
                    {
                        if (item.ToString() == contact.Salutation) CmbCreateSalutation.SelectedItem = item;
                    }
                    TxtCreateTitle.Text = contact.Title;
                    TxtCreateFirstName.Text = contact.FirstName;
                    TxtCreateLastName.Text = contact.LastName;
                    TxtCreateAddress.Text = contact.Address;
                    TxtCreatePlz.Text = contact.PostalCode;
                    TxtCreatePlaceOfResidence.Text = contact.PlaceOfResidence;
                    foreach (var item in CmbCreateNationality.Items)
                    {
                        if (item.ToString() == contact.Nationality) CmbCreateNationality.SelectedItem = item;
                    }
                    TxtCreateOasiNr.Text = contact.OasiNumber;
                    DatCreateBirthday.Text = contact.DateOfBirth;
                    TxtCreatePrivatePhone.Text = contact.PrivatePhone;
                    TxtCreateEmailAddress.Text = contact.EmailAddress;
                    TxtCreateBusinessPhone.Text = contact.BusinessPhone;
                    TxtCreateBusinessAddress.Text = contact.BusinessAddress;
                    TxtCreateBusinessPhone.Text = contact.BusinessPhone;

                    // Fill out specific fields
                    Type type = contact.GetType();

                    if (type == typeof(Customer))
                    {
                        Customer customer = (Customer)contact;
                        RadCreateCustomer.Checked = true;
                        TxtCreateCustomerNumber.Text = customer.CustomerNumber;
                        foreach (var item in CmbCreateCustomerType.Items)
                        {
                            if (item.ToString() == customer.CustomerType) CmbCreateCustomerType.SelectedItem = item;
                        }
                        TxtCreateCompanyName.Text = customer.CompanyName;
                        TxtCreateCompanyContact.Text = customer.CompanyContact;
                    }
                    else if (type == typeof(Employee))
                    {
                        Employee employee = (Employee)contact;
                        RadCreateEmployee.Checked = true;
                        TxtCreateEmployeeNumber.Text = employee.EmployeeNumber;
                        NumCreateDegreeOfEmployment.Value = Convert.ToInt32(employee.DegreeOfEmployment);
                        TxtCreateDepartement.Text = employee.Department;
                        TxtCreateRole.Text = employee.Role;
                        NumCadreLevel.Value = Convert.ToInt32(employee.CadreLevel);
                        DatCreateDateOfJoining.Text = employee.DateOfJoining;
                        DatCreateDateOfLeaving.Text = employee.DateOfLeaving;
                    }
                    else if (type == typeof(Trainee))
                    {
                        Trainee trainee = (Trainee)contact;
                        RadCreateEmployee.Checked = true;
                        ChkCreateTrainee.Checked = true;
                        NumCreateDegreeOfEmployment.Value = Convert.ToInt32(trainee.DegreeOfEmployment);
                        TxtCreateDepartement.Text = trainee.Department;
                        TxtCreateRole.Text = trainee.Role;
                        NumCadreLevel.Value = Convert.ToInt32(trainee.CadreLevel);
                        DatCreateDateOfJoining.Text = trainee.DateOfJoining;
                        DatCreateDateOfLeaving.Text = trainee.DateOfLeaving;
                        NumCreateCurrentAppYear.Value = Convert.ToInt32(trainee.CurrentApprenticeshipYear);
                        NumCreateYearOfApp.Value = Convert.ToInt32(trainee.YearsOfApprenticeship);
                    }

                }
                else
                {
                    // Create
                }
            }
        }

        private void CmdSearchPersonDelete_Click(object sender, EventArgs e)
        {
            if (DataGridViewSearchResult.SelectedCells != null)
            {
                var selectedContact = searchResults[DataGridViewSearchResult.SelectedCells[0].RowIndex];

                // Ask the user to confirm the deletion
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete contact {TxtCreateFirstName.Text} {TxtCreateLastName.Text}?",
                                                            "Confirm Deletion",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // User clicked 'Yes', proceed with the deletion
                    bool deletionSuccessful = false;

                    if (selectedContact.GetType() == typeof(Customer))
                    {
                        deletionSuccessful = SqliteDataAccess.DeleteCustomer(((Customer)selectedContact).CustomerNumber);
                    }
                    else if (selectedContact.GetType() == typeof(Employee) || selectedContact.GetType() == typeof(Trainee))
                    {
                        deletionSuccessful = SqliteDataAccess.DeleteEmployee(((Employee)selectedContact).EmployeeNumber);
                    }

                    if (deletionSuccessful)
                    {
                        // Deletion was successful. Show a success message.
                        MessageBox.Show($"Contact {TxtCreateFirstName.Text} {TxtCreateLastName.Text} has been deleted successfully.",
                                        "Customer Deletion Successful",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        // Refresh the DataGridView 
                        searchResults.Remove(selectedContact);
                        DataGridViewSearchResult.DataSource = null;
                        DataGridViewSearchResult.DataSource = searchResults;
                    }
                    else
                    {
                        // Deletion failed. Show an error message.
                        MessageBox.Show("Failed to delete the contact. Please check try again.",
                                        "Contact Deletion Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // User clicked 'No', close the dialog popup
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.");
            }
        }

        private void UpdateEmployeeNumber()
        {
            if (string.IsNullOrEmpty(selectedPerson))
            {
                // Handle no selected person
                TxtCreateEmployeeNumber.Text = "No person selected";
            }
            else
            {
                if (selectedPerson.Contains("EMP"))
                {
                    TxtCreateEmployeeNumber.Text = selectedPerson;
                    RadCreateCustomer.Enabled = false;
                }
                else if (selectedPerson.Contains("CUS"))
                {
                    TxtCreateCustomerNumber.Text = selectedPerson;
                    RadCreateEmployee.Enabled = false;
                }

            }
        }

        private void CmdSearchCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdSearchCreate_Click(object sender, EventArgs e)
        {
            TCtrlMain.SelectedTab = TabCreateEdit;
        }

        private void CmdSearchNoteSave_Click(object sender, EventArgs e)
        {
            //
        }


        private void CmdCreateDeletePerson_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {TxtCreateFirstName.Text} {TxtCreateLastName.Text}?",
                                                        "Confirm Deletion",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // User confirmed the deletion
                if (RadCreateCustomer.Checked)
                {
                    bool deletionSuccessful = SqliteDataAccess.DeleteCustomer(TxtCreateCustomerNumber.Text);
                    if (deletionSuccessful)
                    {
                        // Deletion was successful. Show a success message.
                        MessageBox.Show($"Customer {TxtCreateFirstName.Text} {TxtCreateLastName.Text} has been deleted successfully.", "Customer Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Deletion failed. Show an error message.
                        MessageBox.Show("Failed to delete the Customer. Please check the Customer number and try again.", "Customer Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Close the current form
                    this.Close();
                }
                else if (RadCreateEmployee.Checked)
                {
                    if (ChkCreateTrainee.Checked)
                    {
                        bool deletionSuccessful = SqliteDataAccess.DeleteEmployee(TxtCreateEmployeeNumber.Text);
                        if (deletionSuccessful)
                        {
                            // Deletion was successful. Show a success message.
                            MessageBox.Show($"Trainee {TxtCreateFirstName.Text} {TxtCreateLastName.Text} has been deleted successfully.", "Trainee Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Deletion failed. Show an error message.
                            MessageBox.Show("Failed to delete the Trainee. Please check the employee number and try again.", "Trainee Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Close the current form
                        this.Close();
                    }
                    else
                    {
                        bool deletionSuccessful = SqliteDataAccess.DeleteEmployee(TxtCreateEmployeeNumber.Text);
                        if (deletionSuccessful)
                        {
                            // Deletion was successful. Show a success message.
                            MessageBox.Show($"Employee {TxtCreateFirstName.Text} {TxtCreateLastName.Text} has been deleted successfully.", "Employee Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Deletion failed. Show an error message.
                            MessageBox.Show("Failed to delete the employee. Please check the employee number and try again.", "Employee Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Close the current form
                        this.Close();
                    }
                }
            }
        }

        private void CmdImportOpenFile_Click(object sender, EventArgs e)
        {
            //Open dialog
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialogImportContacts)
            {
                CmdImportConfirm.Enabled = false;

                if (OpenFileDialogImportContacts.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = OpenFileDialogImportContacts.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = OpenFileDialogImportContacts.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();

                        // importContent contains all types of contacts
                        importContent = new List<object>() { };
                        importContent.AddRange(ParseCsvWithReflection(fileContent));

                        if (importContent.Count > 0)
                        {
                            LblImportPreviewEmpty.Visible = false;
                            CmdImportConfirm.Enabled = true;

                            // Generic data as List of type Person
                            List<Person> importContentAsPersons = new List<Person>();

                            foreach (Person person in importContent)
                            {
                                importContentAsPersons.Add(person);
                            }

                            DataGridViewImportGeneric.DataSource = importContentAsPersons;

                            DataGridViewImportGeneric.CurrentCell = DataGridViewImportGeneric.FirstDisplayedCell;
                            int currentSelectedCol = DataGridViewImportGeneric.CurrentCell.ColumnIndex;
                        }
                        else
                        {
                            LblImportPreviewEmpty.BackColor = Color.DimGray;
                            LblImportPreviewEmpty.Visible = true;
                        }
                    }
                }
            }
        }

        private void CmdImportConfirm_Click(object sender, EventArgs e)
        {
            ProgrBarImport.Value = 0;
            ProgrBarImport.Visible = true;
            int step = 1000 / importContent.Count;

            Controller controller = new Controller();
            bool success = true;

            foreach (var item in importContent)
            {
                Type type = item.GetType();
                if (type == typeof(Customer))
                {
                    Customer customer = (Customer)item;
                    success &= controller.CreateCustomer(customer, this, false, false);

                    ProgrBarImport.Value += step;
                }
                else if (type == typeof(Employee))
                {
                    Employee employee = (Employee)item;
                    success &= controller.CreateEmployee(employee, this, false, false);

                    ProgrBarImport.Value += step;
                }
                else if (type == typeof(Trainee))
                {
                    Trainee trainee = (Trainee)item;
                    success &= controller.CreateTrainee(trainee, this, false, false);

                    ProgrBarImport.Value += step;
                }
            }

            if (success)
            {
                MessageBox.Show(this, "Imported contacts successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CmdImportConfirm.Enabled = false;
                DataGridViewImportGeneric.DataSource = null;
                DataGridViewImportSpecific.DataSource = null;
            }
            else
            {
                MessageBox.Show(this, "An error occurred while importing contacts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ProgrBarImport.Value = 0;
            ProgrBarImport.Visible = false;
        }

        private void CmdImportCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public List<Person> ParseCsvWithReflection(string csvContent)
        {
            var lines = csvContent.Split('\n');
            var people = new List<Person>();
            var headers = lines[0].Split(',').Select(h => h.Trim()).ToArray();

            for (int i = 1; i < lines.Length; i++) // Starting from 1 to skip the header
            {
                var line = lines[i].Trim();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    var columns = line.Split(',');

                    // Determine the type based on specific fields in the CSV for each row
                    // Customer specific
                    int companyNameIndex = Array.IndexOf(headers, "CompanyName");
                    int customerTypeIndex = Array.IndexOf(headers, "CustomerType");
                    int companyContactIndex = Array.IndexOf(headers, "CompanyContact");
                    int customerNumberIndex = Array.IndexOf(headers, "CustomerNumber");
                    // Employee or Trainee
                    int departmentIndex = Array.IndexOf(headers, "Department");
                    int roleIndex = Array.IndexOf(headers, "Role");
                    int cadreLevelIndex = Array.IndexOf(headers, "CadreLevel");
                    int degreeOfEmploymentIndex = Array.IndexOf(headers, "DegreeOfEmployment");
                    int dateOfJoiningIndex = Array.IndexOf(headers, "DateOfJoining");
                    int dateOfLeavingIndex = Array.IndexOf(headers, "DateOfLeaving");
                    int employeeNumberIndex = Array.IndexOf(headers, "EmployeeNumber");
                    // Trainee
                    int currentApprenticeshipYearIndex = Array.IndexOf(headers, "CurrentApprenticeshipYear");
                    int yearsOfApprenticeshipIndex = Array.IndexOf(headers, "YearsOfApprenticeship");

                    Person person;
                    if ((companyNameIndex != -1 && !string.IsNullOrWhiteSpace(columns[companyNameIndex])) ||
                    (customerTypeIndex != -1 && !string.IsNullOrWhiteSpace(columns[customerTypeIndex])) ||
                    (companyContactIndex != -1 && !string.IsNullOrWhiteSpace(columns[companyContactIndex])) ||
                    (customerNumberIndex != -1 && !string.IsNullOrWhiteSpace(columns[customerNumberIndex])))
                    {
                        person = new Customer();
                    }
                    else if ((departmentIndex != -1 && !string.IsNullOrWhiteSpace(columns[departmentIndex])) ||
                    (roleIndex != -1 && !string.IsNullOrWhiteSpace(columns[roleIndex])) ||
                    (cadreLevelIndex != -1 && !string.IsNullOrWhiteSpace(columns[cadreLevelIndex])) ||
                    (degreeOfEmploymentIndex != -1 && !string.IsNullOrWhiteSpace(columns[degreeOfEmploymentIndex])) ||
                    (dateOfJoiningIndex != -1 && !string.IsNullOrWhiteSpace(columns[dateOfJoiningIndex])) ||
                    (dateOfLeavingIndex != -1 && !string.IsNullOrWhiteSpace(columns[dateOfLeavingIndex])) ||
                    (employeeNumberIndex != -1 && !string.IsNullOrWhiteSpace(columns[employeeNumberIndex])))
                    {
                        if ((currentApprenticeshipYearIndex != -1 && !string.IsNullOrWhiteSpace(columns[currentApprenticeshipYearIndex])) ||
                        (yearsOfApprenticeshipIndex != -1 && !string.IsNullOrWhiteSpace(columns[yearsOfApprenticeshipIndex])))
                        {
                            person = new Trainee();
                        }
                        else
                        {
                            person = new Employee();
                        }
                    }
                    else
                    {
                        person = new Customer();  // Defaulting to Customer
                    }


                    // Reflect on the determined type
                    var type = person.GetType();

                    for (int j = 0; j < headers.Length; j++)
                    {
                        var prop = type.GetProperty(headers[j]);
                        if (prop != null && j < columns.Length)
                        {
                            Type propType = prop.PropertyType;

                            if (propType == typeof(Int32))
                            {
                                prop.SetValue(person, Convert.ToInt32(columns[j].Trim()));
                            }
                            else
                            {
                                prop.SetValue(person, columns[j].Trim());
                            }
                        }
                    }

                    people.Add(person);
                }
            }

            return people;
        }

        private void DataGridViewImportGeneric_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewImportGeneric.SelectedCells.Count > 0)
            {
                object selectedContact = importContent[DataGridViewImportGeneric.SelectedCells[0].RowIndex];

                if (selectedContact != null)
                {
                    Type type = selectedContact.GetType();
                    LblImportType.Text = $"{type.Name} Informations: ";

                    DataGridViewImportSpecific.CurrentCell = null;
                    DataGridViewImportSpecific.AutoGenerateColumns = false;
                    DataGridViewImportSpecific.Columns.Clear();
                    DataGridViewImportSpecific.DataSource = null;

                    if (type == typeof(Customer))
                    {
                        DataGridViewImportSpecific.DataSource = new List<Customer>() { (Customer)selectedContact };

                        DataGridViewTextBoxColumn companyNameColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "companyNameColumn",
                            HeaderText = "Company Name",
                            DataPropertyName = "companyName"
                        };
                        DataGridViewImportSpecific.Columns.Add(companyNameColumn);

                        DataGridViewTextBoxColumn customerTypeColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "customerTypeColumn",
                            HeaderText = "Customer Type",
                            DataPropertyName = "customerType"
                        };
                        DataGridViewImportSpecific.Columns.Add(customerTypeColumn);

                        DataGridViewTextBoxColumn companyContactColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "companyContactColumn",
                            HeaderText = "Company Contact",
                            DataPropertyName = "companyContact"
                        };
                        DataGridViewImportSpecific.Columns.Add(companyContactColumn);

                        DataGridViewTextBoxColumn customerNumberColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "customerNumberColumn",
                            HeaderText = "Customer Number",
                            DataPropertyName = "customerNumber"
                        };
                        DataGridViewImportSpecific.Columns.Add(customerNumberColumn);
                    }
                    else if (type == typeof(Employee) || type == typeof(Trainee))
                    {
                        DataGridViewImportSpecific.DataSource = new List<Employee>() { (Employee)selectedContact };

                        DataGridViewTextBoxColumn departmentColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "departmentColumn",
                            HeaderText = "Department",
                            DataPropertyName = "department"
                        };
                        DataGridViewImportSpecific.Columns.Add(departmentColumn);

                        DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "roleColumn",
                            HeaderText = "Role",
                            DataPropertyName = "role"
                        };
                        DataGridViewImportSpecific.Columns.Add(roleColumn);

                        DataGridViewTextBoxColumn cadreLevelColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "cadreLevelColumn",
                            HeaderText = "Cadre Level",
                            DataPropertyName = "cadreLevel"
                        };
                        DataGridViewImportSpecific.Columns.Add(cadreLevelColumn);

                        DataGridViewTextBoxColumn degreeOfEmploymentColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "degreeOfEmploymentColumn",
                            HeaderText = "Degree Of Employment",
                            DataPropertyName = "degreeOfEmployment"
                        };
                        DataGridViewImportSpecific.Columns.Add(degreeOfEmploymentColumn);

                        DataGridViewTextBoxColumn dateOfJoiningColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "dateOfJoiningColumn",
                            HeaderText = "Date Of Joining",
                            DataPropertyName = "dateOfJoining"
                        };
                        DataGridViewImportSpecific.Columns.Add(dateOfJoiningColumn);

                        DataGridViewTextBoxColumn dateOfLeavingColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "dateOfLeavingColumn",
                            HeaderText = "Date Of Leaving",
                            DataPropertyName = "dateOfLeaving"
                        };
                        DataGridViewImportSpecific.Columns.Add(dateOfLeavingColumn);

                        DataGridViewTextBoxColumn employeeNumberColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "employeeNumberColumn",
                            HeaderText = "Employee Number",
                            DataPropertyName = "employeeNumber"
                        };
                        DataGridViewImportSpecific.Columns.Add(employeeNumberColumn);

                        if (type == typeof(Trainee))
                        {
                            DataGridViewImportSpecific.DataSource = new List<Trainee>() { (Trainee)selectedContact };

                            DataGridViewTextBoxColumn currentApprenticeshipYearColumn = new DataGridViewTextBoxColumn
                            {
                                Name = "currentApprenticeshipYearColumn",
                                HeaderText = "Current Apprenticeship Year",
                                DataPropertyName = "currentApprenticeshipYear"
                            };
                            DataGridViewImportSpecific.Columns.Add(currentApprenticeshipYearColumn);

                            DataGridViewTextBoxColumn yearsOfApprenticeshipColumn = new DataGridViewTextBoxColumn
                            {
                                Name = "yearsOfApprenticeshipColumn",
                                HeaderText = "Years Of Apprenticeship",
                                DataPropertyName = "yearsOfApprenticeship"
                            };
                            DataGridViewImportSpecific.Columns.Add(yearsOfApprenticeshipColumn);
                        }
                    }
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form menu = new FormMenu();
            menu.Show();
        }

        private void CmdSearchAddNote_Click(object sender, EventArgs e)
        {
            //
        }

        private void CmdSearchDeleteNote_Click(object sender, EventArgs e)
        {
            //
        }

        private void DataGridViewSearchNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentContactNotes != null)
            {
                if (e.RowIndex >= 0 && e.RowIndex < currentContactNotes.Count)
                {
                    CmdSearchDeleteNote.Enabled = true;
                }
            }
        }

        private void DataGridViewSearchNotes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (currentContactNotes != null)
            {
                if (e.RowIndex >= 0 && e.RowIndex < currentContactNotes.Count)
                {
                    if (e.ColumnIndex == 0)
                    {
                        // Update the 'Content' property of the corresponding Note object in currentContactNotes
                        currentContactNotes[e.RowIndex].Content = DataGridViewSearchNotes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                        CmdSearchSaveNote.Enabled = true;
                    }
                }
            }

        }
    }
}
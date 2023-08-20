using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactManager
{
    public partial class FormMain : MaterialForm
    {
        MaterialSkinManager manager = Program.GetStandardManager();

        public enum Tab
        {
            Create,
            Search,

        }

        public FormMain()
        {
            InitializeComponent();

            manager.AddFormToManage(this);


            //Countries in ComboBox Nationality
            PopulateCountryComboBox();
            TxtCreateOasiNr.KeyPress += TxtCreateOasiNr_KeyPress;


            this.RadCreateMale.CheckedChanged += new System.EventHandler(this.RadCreateMale_CheckedChanged);
            this.RadCreateFemale.CheckedChanged += new System.EventHandler(this.RadCreateFemale_CheckedChanged);
            this.RadCreateOther.CheckedChanged += new System.EventHandler(this.RadCreateOther_CheckedChanged);

            // Disable the employee && Customer number text box
            TxtCreateEmployeeNumber.Enabled = false;
            TxtCreateCustomerNumber.Enabled = false;

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

        // Event handler for RadCreateMale
        private void RadCreateMale_CheckedChanged(object sender, EventArgs e)
        {
            if (RadCreateMale.Checked)
            {
                ChangeFormColor(MaterialSkin.Primary.Blue500);
            }
        }

        // Event handler for RadCreateFemale
        private void RadCreateFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (RadCreateFemale.Checked)
            {
                ChangeFormColor(MaterialSkin.Primary.Pink500);
            }
        }

        // Event handler for RadCreateOther
        private void RadCreateOther_CheckedChanged(object sender, EventArgs e)
        {
            if (RadCreateOther.Checked)
            {
                ChangeFormColor(MaterialSkin.Primary.Grey500);
            }
        }

        private void ChangeFormColor(MaterialSkin.Primary primaryColor)
        {
            manager.ColorScheme = new ColorScheme(
                primaryColor,
                primaryColor,
                primaryColor,
                Accent.Blue100,
                TextShade.WHITE
            );
            Refresh();
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
            Regex regexLetters = new Regex("^[A-Za-zÄ-Üä-ü ]+$");
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
                  this

               );
                }

            }
            else if (RadCreateCustomer.Checked)
            {
                controller.CreateCustomer(
                TxtCreateFirstName.Text,
                TxtCreateLastName.Text,
                DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                TxtCreateCustomerNumber.Text,
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
                TxtCreateCompanyName.Text,
                CmbCreateCustomerType.SelectedItem.ToString(),
                TxtCreateCompanyContact.Text,
                this
                );
            }
        }

        private void CmdExecSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtOutput.Text;
            List<Person> people = SqliteDateAccess.LoadPeople(searchText);
            if (people.Count == 0)
            {
                txtOutput.Text = "No users found.";
            }
            else
            {
                txtOutput.Text = "";
                foreach (Person person in people)
                {
                    DateTime dob = DateTime.Parse(person.dateOfBirth);
                    txtOutput.Text += $"First Name: {person.firstName}, Last Name: {person.lastName}, Date of Birth: {dob.ToString("yyyy-MM-dd")}\n";
                }
            }

        }

        private void RadCreateCustomer_CheckedChanged(object sender, EventArgs e)
        {

            LblCreateTypeSelection.Visible = false;

            if (RadCreateCustomer.Checked == true)
            {
                PnlCreateInfoCustomer.Visible = true;
                // Generate the next Customer number
                TxtCreateCustomerNumber.Text = SqliteDateAccess.GetNextNumber("Customer", "CustomerNumber").ToString();
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

                // Generate the next employee number
                TxtCreateEmployeeNumber.Text = SqliteDateAccess.GetNextNumber("Employee", "EmployeeNumber").ToString();
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
    }
}





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
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Model;
using Dapper;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ContactManager
{
    public partial class FormMain : MaterialForm
    {
        MaterialSkinManager manager = Program.GetStandardManager();

        public enum Tab
        {
            Create,
            Search,
            Edit,
            Delete
        }

        public FormMain()
        {
            InitializeComponent();

            manager.AddFormToManage(this);

            //Countries in ComboBox Nationality
            PopulateCountryComboBox();
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
                case Tab.Edit:
                    TCtrlMain.SelectedTab = TabSearch;
                    break;
                case Tab.Delete:
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

            //Nationality
            CmdNationality.Items.Add("British");

        }

        public int checkState;
        private void CmdCreatePerson_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
<<<<<<< HEAD
            if (RadEmployee.Checked)
            {
                if (ChkTrainee.Checked)
                {
                    controller.CreateEmployee(
                   TxtFirstName.Text,
                   TxtLastName.Text,
                   DatBirthday.Value.ToString("yyyy-MM-dd"),
                   TxtEmployeeNumber.Text,
                   checkState = (int)SwtActive.CheckState,
                   RadMale.Checked ? "1" : "0",
                   CmbSalutation.SelectedItem?.ToString(),
                   TxtTitle.Text,
                   TxtAddress.Text,
                   TxtPlz.Text,
                   TxtPlaceOfResidence.Text,
                   CmdNationality.SelectedItem?.ToString(),
                   TxtOasiNr.Text,
                   TxtPrivatePhone.Text,
                   TxtBusnissPhone.Text,
                   TxtEmailAddress.Text,
                   LstNoteOut.SelectedItem?.ToString(),
                   TxtRole.Text,
                   TxtDepartement.Text,
                   DatDateOfJoining.Value.ToString("yyyy-MM-dd"),
                   DatDateOfLeaving.Value.ToString("yyyy-MM-dd"),
                   NumCadreLevel.Value.ToString()

                );
                }
                else
                {
                    controller.CreateTrainee(
                 TxtFirstName.Text,
                 TxtLastName.Text,
                 DatBirthday.Value.ToString("yyyy-MM-dd"),
                 TxtEmployeeNumber.Text,
                 checkState = (int)SwtActive.CheckState,
                 RadMale.Checked ? "1" : "0",
                 CmbSalutation.SelectedItem?.ToString(),
                 TxtTitle.Text,
                 TxtAddress.Text,
                 TxtPlz.Text,
                 TxtPlaceOfResidence.Text,
                 CmdNationality.SelectedItem?.ToString(),
                 TxtOasiNr.Text,
                 TxtPrivatePhone.Text,
                 TxtBusnissPhone.Text,
                 TxtEmailAddress.Text,
                 LstNoteOut.SelectedItem?.ToString(),
                 TxtRole.Text,
                 TxtDepartement.Text,
                 DatDateOfJoining.Value.ToString("yyyy-MM-dd"),
                 DatDateOfLeaving.Value.ToString("yyyy-MM-dd"),
                 NumCadreLevel.Value.ToString(),
                 NumCurrentAppYear.Value.ToString(),
                 NumYearOfApp.Value.ToString()
                 );
                }
            }
            else if (RadCustomer.Checked)
            {
                controller.CreateCustomer(
                    TxtFirstName.Text,
                    TxtLastName.Text,
                    DatBirthday.Value.ToString("yyyy-MM-dd"),
                    "",
                    "",
                    ""
                    );
            }
=======
            controller.CreateEmployee(
                TxtCreateFirstName.Text,
                TxtCreateLastName.Text,
                DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                TxtEmployeeNumber.Text 
            );
>>>>>>> cde6e7827a880b5454d6b309931dedc26b7b91f8
        }

        private void CmdExecSearch_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string searchText = txtSearch.Text;
            List<Employee> people = SqliteDateAccess.LoadPeople(searchText);
=======
            string searchText = TxtSearch.Text;
            List<Person> people = SqliteDateAccess.LoadPeople(searchText);
>>>>>>> cde6e7827a880b5454d6b309931dedc26b7b91f8
            if (people.Count == 0)
            {
                txtOutput.Text = "No users found.";
            }
            else
            {
                txtOutput.Text = "";
                foreach (Employee person in people)
                {
                    DateTime dob = DateTime.Parse(person.dateOfBirth);
                    txtOutput.Text += $"First Name: {person.firstName}, EmployeeNumber: {person.EmployeeNumber}, Last Name: {person.lastName}, Date of Birth: {dob.ToString("yyyy-MM-dd")}\n";
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
            PrgDegreeOfEmployment.Value = Convert.ToInt16(NumDegreeOfEmployment.Value);
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
    }
}





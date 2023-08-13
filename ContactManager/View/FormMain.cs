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
            //PopulateCountryComboBox();
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

            if (RadCreateEmployee.Checked)
            {
                if (ChkCreateTrainee.Checked)
                {
                    controller.CreateEmployee(
                   TxtCreateFirstName.Text,
                   TxtCreateLastName.Text,
                   DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                   TxtEmployeeNumber.Text,
                   checkState = (int)SwtCreateActive.CheckState,
                   RadCreateMale.Checked ? "1" : "0",
                   CmbSalutation.SelectedItem?.ToString(),
                   TxtCreateTitle.Text,
                   TxtCreateAddress.Text,
                   TxtCreatePlz.Text,
                   TxtCreatePlaceOfResidence.Text,
                   CmdNationality.SelectedItem?.ToString(),
                   TxtCreateOasiNr.Text,
                   TxtCreatePrivatePhone.Text,
                   TxtCreateBusnissPhone.Text,
                   TxtCreateEmailAddress.Text,
                   LstCreateNoteOut.SelectedItem?.ToString(),
                   TxtRole.Text,
                   TxtDepartement.Text,
                   DatCreateDateOfJoining.Value.ToString("yyyy-MM-dd"),
                   DatCreateDateOfLeaving.Value.ToString("yyyy-MM-dd"),
                   NumCadreLevel.Value.ToString()

                );
                }
                else
                {
                    controller.CreateTrainee(
                 TxtCreateFirstName.Text,
                 TxtCreateLastName.Text,
                 DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                 TxtEmployeeNumber.Text,
                 checkState = (int)SwtCreateActive.CheckState,
                 RadCreateMale.Checked ? "1" : "0",
                 CmbSalutation.SelectedItem?.ToString(),
                 TxtCreateTitle.Text,
                 TxtCreateAddress.Text,
                 TxtCreatePlz.Text,
                 TxtCreatePlaceOfResidence.Text,
                 CmdNationality.SelectedItem?.ToString(),
                 TxtCreateOasiNr.Text,
                 TxtCreatePrivatePhone.Text,
                 TxtCreateBusnissPhone.Text,
                 TxtCreateEmailAddress.Text,
                 LstCreateNoteOut.SelectedItem?.ToString(),
                 TxtRole.Text,
                 TxtDepartement.Text,
                 DatCreateDateOfJoining.Value.ToString("yyyy-MM-dd"),
                 DatCreateDateOfLeaving.Value.ToString("yyyy-MM-dd"),
                 NumCadreLevel.Value.ToString(),
                 NumCreateCurrentAppYear.Value.ToString(),
                 NumCreateYearOfApp.Value.ToString()
                 );
                }
            }
            else if (RadCreateCustomer.Checked)
            {
                controller.CreateCustomer(
                    TxtCreateFirstName.Text,
                    TxtCreateLastName.Text,
                    DatCreateBirthday.Value.ToString("yyyy-MM-dd"),
                    "",
                    "",
                    ""
                    );
            }

        }

        private void CmdExecSearch_Click(object sender, EventArgs e)
        {

            string searchText = TxtSearch.Text;
            List<Person> people = SqliteDateAccess.LoadPeople( searchText );

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
        //  private void PopulateCountryComboBox()
        // {

        // Get the list of all countries using CultureInfo
        // List<string> countriesList = new List<string>();
        //   foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
        //   {
        //  RegionInfo region = new RegionInfo(ci.Name);
        //      if (!countriesList.Contains(region.EnglishName))
        //     {
        // countriesList.Add(region.EnglishName);
        // }
        //}

        // Sort the list of countries alphabetically
        //  countriesList.Sort();

        // Populate the ComboBox with the list of countries
        // CmbCreateNationality.DataSource = countriesList;


    }

    
}





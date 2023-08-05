using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            PnlEmployee.Visible = false;
            PnlTrainee.Visible = false;
            ChkTrainee.Visible = false;

            //Don't show customer elements.
            PnlCustomer.Visible = false;

        }


        private void CmdCreatePerson_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            //controller.CreatePerson(txtFirstName.Text, txtLastName.Text, datBirthday.Text);

        }

        private void CmdExecSearch_Click(object sender, EventArgs e)
        {
            string searchText = TxtSearch.Text;
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

        private void RadCustomer_CheckedChanged(object sender, EventArgs e)
        {

            LblTypeSelection.Visible = false;

            if (RadCustomer.Checked == true)
            {
                PnlCustomer.Visible = true;
            }
            else
            {
                PnlCustomer.Visible = false;
            }
        }

        private void RadEmployee_CheckedChanged(object sender, EventArgs e)
        {
            LblTypeSelection.Visible = false;

            if (RadEmployee.Checked == true)
            {
                PnlEmployee.Visible = true;
                ChkTrainee.Visible = true;

            }
            else
            {
                PnlEmployee.Visible = false;
                ChkTrainee.Visible = false;
                PnlTrainee.Visible = false;
            }

        }

        private void ChkTrainee_CheckedChanged(object sender, EventArgs e)
        {

            if (ChkTrainee.Checked == true && RadEmployee.Checked == true)
            {
                PnlTrainee.Visible = true;
            }
            else
            {
                PnlTrainee.Visible = false;
            }
        }

        private void NumDegreeOfEmployment_ValueChanged(object sender, EventArgs e)
        {
            PrgDegreeOfEmployment.Value = Convert.ToInt16(NumDegreeOfEmployment.Value);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCompanyContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





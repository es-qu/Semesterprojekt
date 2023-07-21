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

        private void CmdCreatePerson_Click(object sender, EventArgs e)
        {
            Person p = new Person();


            p.firstName = txtFirstName.Text;
            p.lastName = txtLastName.Text;
            p.dateOfBirth = datBirthday.Text;

            SqliteDateAccess.SavePerson(p);
            //if (/*Radiobutton Customer checked */)
            //{
            //    CreateCustomer();
            //}
            //else if (/*Radiobutton Employee checked */)
            //{
            //    if (/*Checkbox Trainee checked */)
            //    {
            //        CreateTrainee();
            //    }
            //    else
            //    {
            //        CreateEmployee();
            //    }
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            List<Person> people = SqliteDateAccess.LoadPepole(searchText);
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

        
    }
}





using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    internal class Controller
    {
        public void CreatePerson(string firstName, string lastName, string dateOfBirth)
        {
            Person p = new Person
            {
                firstName = firstName,
                lastName = lastName,
                dateOfBirth = dateOfBirth
            };

            SqliteDateAccess.SavePerson(p);
        }

        public void CreateEmployee(string firstName, string lastName, string dateOfBirth, string position, string department)
        {
            Employee e = new Employee
            {
                firstName = firstName,
                lastName = lastName,
                dateOfBirth = dateOfBirth,
                Position = position,
                Department = department
            };

            SqliteDateAccess.SavePerson(e);

            // Show confirmation message
            MessageBox.Show($"Employee {e.firstName} {e.lastName} has been created.", "Confirmation", MessageBoxButtons.OK);

            // Clear input fields
        

        }

        public void CreateTrainee(string firstName, string lastName, string dateOfBirth, string position, string department, string mentorName, DateTime trainingStart, DateTime trainingEnd)
        {
            Trainee t = new Trainee
            {
                firstName = firstName,
                lastName = lastName,
                dateOfBirth = dateOfBirth,
                Position = position,
                Department = department,
                MentorName = mentorName,
                TrainingStartDate = trainingStart,
                TrainingEndDate = trainingEnd
            };

            SqliteDateAccess.SavePerson(t);
        }
    }
}

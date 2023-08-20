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
        public void CreateEmployee(string firstName, string lastName, string dateOfBirth, string employeeNumber, int status, string gender, string Salutaion, string title,
                                    string street, string postalCode, string placeOfResidence, string nationality, string ahv, string phonePrivate,
                                     string phoneBuiness, string email, string note, string Position, string Department, string dateofjoining, string dateofleaving, string NumCadreLevel, Form form)
        {
            Employee e = new Employee
            { 
                status = status,
                firstName = firstName,
                lastName = lastName,
                dateOfBirth = dateOfBirth,
                EmployeeNumber = employeeNumber,
                gender =gender,
                Salutation = Salutaion,
                title = title,
                street = street,
                postalCode = postalCode,
                placeOfResidence = placeOfResidence,
                nationality = nationality,
                socialSecurityNumber = ahv,
                phoneNumberPrivat = phonePrivate,
                phoneNumberBusiness = phoneBuiness,
                email = email,
                note = note,
                Position = Position,
                Department = Department,
                NumCadreLevel = NumCadreLevel,
                dateofjoining = dateofjoining,
                dateofleaving = dateofleaving

            };

        SqliteDateAccess.SaveEmployee(e);

            // Show confirmation message
            MessageBox.Show($"Employee {e.firstName} {e.lastName} has been created.", "Confirmation", MessageBoxButtons.OK);
            form.Close();

        }

        public void CreateTrainee(string firstName, string lastName, string dateOfBirth, string employeeNumber, int status, string gender, string Salutaion, string title,
                                   string street, string postalCode, string placeOfResidence, string nationality, string ahv, string phonePrivate,
                                    string phoneBuiness, string email, string note, string Position, string Department, string dateofjoining, string dateofleaving, string NumCadreLevel,
                                   string TrainingStartDate, string TrainingEndDate, Form form)
        {
            Trainee t = new Trainee
            {
                status = status,
                firstName = firstName,
                lastName = lastName,
                dateOfBirth = dateOfBirth,
                EmployeeNumber = employeeNumber,
                gender = gender,
                Salutation = Salutaion,
                title = title,
                street = street,
                postalCode = postalCode,
                placeOfResidence = placeOfResidence,
                nationality = nationality,
                socialSecurityNumber = ahv,
                phoneNumberPrivat = phonePrivate,
                phoneNumberBusiness = phoneBuiness,
                email = email,
                note = note,
                Position = Position,
                Department = Department,
                NumCadreLevel = NumCadreLevel,
                dateofjoining = dateofjoining,
                dateofleaving = dateofleaving,
                TrainingStartDate = TrainingStartDate,
                TrainingEndDate = TrainingEndDate
            };

            SqliteDateAccess.SaveTrainee(t);
            // Show confirmation message
            MessageBox.Show($"Employee {t.firstName} {t.lastName} has been created.", "Confirmation", MessageBoxButtons.OK);
            form.Close();
        }

        public void CreateCustomer(string firstName, string lastName, string dateOfBirth, string CustomerNumber, int status, string gender, string Salutaion, string title,
                                    string street, string postalCode, string placeOfResidence, string nationality, string ahv, string phonePrivate,
                                     string phoneBuiness, string email, string note, string CompanyName, string CustomerType, string CompanyContact, Form form)
        {
            Customer c = new Customer
            {
                status = status,
                firstName = firstName,
                lastName = lastName,
                dateOfBirth = dateOfBirth,
                CustomerNumber = CustomerNumber,
                gender = gender,
                Salutation = Salutaion,
                title = title,
                street = street,
                postalCode = postalCode,
                placeOfResidence = placeOfResidence,
                nationality = nationality,
                socialSecurityNumber = ahv,
                phoneNumberPrivat = phonePrivate,
                phoneNumberBusiness = phoneBuiness,
                email = email,
                note = note,
                CompanyName = CompanyName,
                CustomerType = CustomerType,
                CompanyContact = CompanyContact

            };

            SqliteDateAccess.SaveCustomer(c);

            // Show confirmation message
            MessageBox.Show($"Customer {c.firstName} {c.lastName} has been created.", "Confirmation", MessageBoxButtons.OK);
            form.Close();

        }

    }
}

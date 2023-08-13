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

        public void CreateEmployee(string firstName, string lastName, string dateOfBirth, string employeeNumber, int status, string gender, string Salutaion, string title,
                                    string street, string postalCode, string placeOfResidence, string nationality, string ahv, string phonePrivate,
                                     string phoneBuiness, string email, string note, string Position, string Department, string dateofjoining, string dateofleaving, string NumCadreLevel)
        {
            Employee e = new Employee
            { 
                status = status == 1,
                firstName = firstName,
                lastName = lastName,
                dateOfBirth = dateOfBirth,
                EmployeeNumber = employeeNumber,
                gender = int.TryParse(gender, out int genderValue) ? genderValue : 0,
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

            // Clear input fields
        }

        public void CreateTrainee(string firstName, string lastName, string dateOfBirth, string employeeNumber, int status, string gender, string Salutaion, string title,
                                   string street, string postalCode, string placeOfResidence, string nationality, string ahv, string phonePrivate,
                                    string phoneBuiness, string email, string note, string Position, string Department, string dateofjoining, string dateofleaving, string NumCadreLevel,
                                   string TrainingStartDate, string TrainingEndDate)
        {
            Trainee t = new Trainee
            {
                status = status == 1,
                firstName = firstName,
                lastName = lastName,
                dateOfBirth = dateOfBirth,
                EmployeeNumber = employeeNumber,
                gender = int.TryParse(gender, out int genderValue) ? genderValue : 0,
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

            SqliteDateAccess.SavePerson(t);
        }

        public void CreateCustomer(string firstName, string lastName, string dateOfBirth, string companyName, string customerType, string companyContact)
        {
            // Validate firstName and lastName
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("First name and last name cannot be empty.", "Error", MessageBoxButtons.OK);
                return;
            }

            // Validate dateOfBirth
            DateTime dob;
            if (!DateTime.TryParse(dateOfBirth, out dob))
            {
                MessageBox.Show("Invalid date of birth.", "Error", MessageBoxButtons.OK);
                return;
            }

            // Validate companyName
            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Company name cannot be empty.", "Error", MessageBoxButtons.OK);
                return;
            }

            // Validate customerType
            char[] validCustomerTypes = { 'A', 'B', 'C', 'D', 'E' };
            if (!validCustomerTypes.Contains(customerType[0]))
            {
                MessageBox.Show("Invalid customer type. It should be A, B, C, D, or E.", "Error", MessageBoxButtons.OK);
                return;
            }

            // Validate companyContact
            if (string.IsNullOrEmpty(companyContact))
            {
                MessageBox.Show("Company contact cannot be empty.", "Error", MessageBoxButtons.OK);
                return;
            }

            // If validations pass, create the Customer
            Customer c = new Customer
            {
                    firstName = firstName,
                    lastName = lastName,
                    dateOfBirth = dateOfBirth,
                    CompanyName = companyName,
                    CustomerType = customerType,
                    CompanyContact = companyContact
            };

            SqliteDateAccess.SaveCustomer(c);
        

            // Show confirmation message
            MessageBox.Show($"Customer {c.firstName} {c.lastName} has been created.", "Confirmation", MessageBoxButtons.OK);
             
        }

    }
}

using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
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

        SqliteDataAccess.SaveEmployee(e);

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

            SqliteDataAccess.SaveTrainee(t);
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

            SqliteDataAccess.SaveCustomer(c);

            // Show confirmation message
            MessageBox.Show($"Customer {c.firstName} {c.lastName} has been created.", "Confirmation", MessageBoxButtons.OK);
            form.Close();

        }


    
        public static List<object> SearchContactsByFullText(SearchFilters filters, string searchTerm, bool searchInactive)
        {
            List<Type> types = getTypes(filters);

            // SearchByQueryString ? ----------------------------------------------------------- EG

            return SqliteDataAccess.SearchPersonsByFullText(searchTerm, searchInactive);
        }

        public static List<Type> getTypes(SearchFilters filters)
        {
            List<Type> types = new List<Type>();

            // Type filter
            if (filters.TypeCustomer) types.Add(typeof(Customer));
            if (filters.TypeEmployee) types.Add(typeof(Employee));
            if (filters.TypeTrainee) types.Add(typeof(Trainee));
            types = (types.Count == 0) 
                ? new List<Type>() { typeof(Customer), typeof(Employee), typeof(Trainee) } 
                : types;

            return types;
        }

        public static List<string> createSqlStatements(SearchFilters filters)
        {
            List<string> sqlConditions = new List<string>();

            // Inactive filter
            if (filters.Inactive) sqlConditions.Add("(status = 0 OR status = 1)");
            else sqlConditions.Add("status = 1");

            // First name, last name
            if (filters.FirstName != string.Empty) sqlConditions.Add($"firstName LIKE '{filters.FirstName}'");
            if (filters.LastName != string.Empty) sqlConditions.Add($"lastName LIKE '{filters.LastName}'");

            // Customer no. / employee no.
            if (filters.Number != string.Empty) sqlConditions.Add($"(CustomerNumber = '{filters.Number}' OR EmployeeNumber = '{filters.Number}')");

            // Search address, place of residence
            if (filters.Address != string.Empty) sqlConditions.Add($"street LIKE '{filters.Address}'");
            if (filters.PlaceOfResidence != string.Empty) sqlConditions.Add($"placeOfResidence LIKE '{filters.PlaceOfResidence}'");

            // Date of birth
            if (filters.DateOfBirth != string.Empty) sqlConditions.Add($"dateOfBirth LIKE '{filters.DateOfBirth}'");

            return sqlConditions;
        }

        public static string createQueryString(List<string> sqlConditions)
        {
            string queryString = string.Empty;

            for (int i = 0; i < sqlConditions.Count; i++)
            {
                var item = sqlConditions[i];

                if (i > 0)
                {
                    queryString += "AND";
                }

                queryString += $" {item} ";
            }

            return queryString;
        }

        public static List<object> SearchContactsByFilters(SearchFilters filters)
        {
            List<Type> types = getTypes(filters);
            List<string> sqlCondotions = createSqlStatements(filters);
            string queryString = createQueryString(sqlCondotions);

            return SqliteDataAccess.SearchPersonsByQueryString(types, queryString);
        }

    }
}

using ContactManager.Model;
using System;
using System.Collections.Generic;
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


        /// <summary>
        /// Check if the filters are set.
        /// </summary>
        /// <param name="filters">Filter states</param>
        /// <returns>True if no filter is set, else false</returns>
        public static bool FiltersAreClear(SearchFilters filters)
        {
            bool clear = true;

            // First name, last name
            clear = (filters.FirstName == string.Empty && clear);
            clear = (filters.LastName == string.Empty && clear);

            // Customer no. / employee no.
            clear = (filters.Number == string.Empty && clear);

            // Search address, place of residence
            clear = (filters.Address == string.Empty && clear);
            clear = (filters.PlaceOfResidence == string.Empty && clear);

            // Date of birth
            clear = (filters.DateOfBirth == string.Empty && clear);


            //
            //  Add all other filters --------------------------------------------------------
            //


            return clear;
        }

        /// <summary>
        /// Search contacts with fulltext search.
        /// </summary>
        /// <param name="filters">Filter states object</param>
        /// <param name="searchTerm">Content of searchbar</param>
        /// <returns>Instances of Contact, Employee and Trainee that match the criteria</returns>
        public static List<object> SearchContactsByFullText(SearchFilters filters, string searchTerm)
        {
            List<Type> types = getTypes(filters);

            string filterCondition =
                $"firstName LIKE '%{searchTerm}%' " +
                $"OR lastName LIKE '%{searchTerm}%' " +
                $"OR street LIKE '%{searchTerm}%' " +
                $"OR placeOfResidence LIKE '%{searchTerm}%' " +
                $"OR dateOfBirth LIKE '%{searchTerm}%'";

            string inactiveCondition = (filters.Inactive) ? "(status = 0 OR status = 1)" : "status = 1";

            List<object> res = new List<object>();

            string customerSqlCondition = $"({filterCondition} OR CustomerNumber LIKE '%{searchTerm}%') AND {inactiveCondition}";
            if (types.Contains(typeof(Customer))) res.AddRange(SqliteDataAccess.SearchPersonsByQueryString(new List<Type>() { typeof(Customer) }, customerSqlCondition));

            string employeeSqlCondition = $"({filterCondition} OR EmployeeNumber LIKE '%{searchTerm}%') AND {inactiveCondition}";
            if (types.Contains(typeof(Employee))) res.AddRange(SqliteDataAccess.SearchPersonsByQueryString(new List<Type>() { typeof(Employee) }, employeeSqlCondition));

            string traineeSqlCondition = $"({filterCondition}) AND {inactiveCondition}";
            if (types.Contains(typeof(Trainee))) res.AddRange(SqliteDataAccess.SearchPersonsByQueryString(new List<Type>() { typeof(Trainee) }, traineeSqlCondition));

            return res;
        }

        /// <summary>
        /// Extracts the types that are active in the given search filters
        /// </summary>
        /// <param name="filters">Filter states</param>
        /// <returns>The active types</returns>
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

        /// <summary>
        /// Create statements to be used in SQL WHERE clause to search contacts
        /// </summary>
        /// <param name="filters">Filter states object</param>
        /// <returns>A list of conditions</returns>
        public static List<string> createSqlConditions(SearchFilters filters)
        {
            List<string> sqlConditions = new List<string>();

            // Inactive filter
            if (filters.Inactive) sqlConditions.Add("(status = 0 OR status = 1)");
            else sqlConditions.Add("status = 1");

            // First name, last name
            if (filters.FirstName != string.Empty) sqlConditions.Add($"firstName LIKE '{filters.FirstName}'");
            if (filters.LastName != string.Empty) sqlConditions.Add($"lastName LIKE '{filters.LastName}'");

            // Customer no. / employee no.
            // --------------------------- Doesn't work !!! --------------------- :/

            if (filters.Number != string.Empty) sqlConditions.Add($"(CustomerNumber = '{filters.Number}' OR EmployeeNumber = '{filters.Number}')");

            // Search address, place of residence
            if (filters.Address != string.Empty) sqlConditions.Add($"street LIKE '{filters.Address}'");
            if (filters.PlaceOfResidence != string.Empty) sqlConditions.Add($"placeOfResidence LIKE '{filters.PlaceOfResidence}'");

            // Date of birth
            if (filters.DateOfBirth != string.Empty) sqlConditions.Add($"dateOfBirth LIKE '{filters.DateOfBirth}'");

            return sqlConditions;
        }

        /// <summary>
        /// Join the conditions to one string that will be used as WHERE condition in DB
        /// </summary>
        /// <param name="sqlConditions">List of conditions</param>
        /// <returns>String for WHERE statement</returns>
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

        /// <summary>
        /// Search contacts using filters.
        /// </summary>
        /// <param name="filters">Search filter states object</param>
        /// <returns>Instances of Contact, Employee and Trainee that match the criteria</returns>
        public static List<object> SearchContactsByFilters(SearchFilters filters)
        {
            List<Type> types = getTypes(filters);
            List<string> sqlCondotions = createSqlConditions(filters);
            string queryString = createQueryString(sqlCondotions);

            return SqliteDataAccess.SearchPersonsByQueryString(types, queryString);
        }

    }
}

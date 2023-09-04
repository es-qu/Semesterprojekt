using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ContactManager
{
    internal class Controller
    {
        public bool CreateEmployee(string firstName, string lastName, string dateOfBirth, string employeeNumber, int status, string gender, string salutaion, string title,
                                    string street, string postalCode, string placeOfResidence, string nationality, string oasiNumber, string phonePrivate,
                                     string phoneBuiness, string email, string businessEmail, string note, string role, string department, string dateOfJoining, string dateOfLeaving, string cadreLevel, Form form)
        {
            Employee e = new Employee
            {
                Active = status,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                EmployeeNumber = employeeNumber,
                Gender = gender,
                Salutation = salutaion,
                Title = title,
                Address = street,
                PostalCode = postalCode,
                PlaceOfResidence = placeOfResidence,
                Nationality = nationality,
                OasiNumber = oasiNumber,
                PrivatePhone = phonePrivate,
                BusinessPhone = phoneBuiness,
                EmailAddress = email,
                BusinessAddress = businessEmail,
                Note = note,
                Role = role,
                Department = department,
                CadreLevel = cadreLevel,
                DateOfJoining = dateOfJoining,
                DateOfLeaving = dateOfLeaving
            };

            SqliteDataAccess.SaveEmployee(e);

            // Show confirmation message
            MessageBox.Show($"Employee {e.FirstName} {e.LastName} has been created.", "Employee Creation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public bool CreateTrainee(string firstName, string lastName, string dateOfBirth, string employeeNumber, int status, string gender, string Salutaion, string title,
                                    string street, string postalCode, string placeOfResidence, string nationality, string ahv, string phonePrivate,
                                     string phoneBuiness, string email, string EmailBusiness, string note, string role, string Department, string dateofjoining, string dateofleaving, string NumCadreLevel,
                                    string currentApprenticeshipYear, string yearsOfApprenticeship, Form form)
        {
            Trainee t = new Trainee
            {
                Active = status,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                EmployeeNumber = employeeNumber,
                Gender = gender,
                Salutation = Salutaion,
                Title = title,
                Address = street,
                PostalCode = postalCode,
                PlaceOfResidence = placeOfResidence,
                Nationality = nationality,
                OasiNumber = ahv,
                PrivatePhone = phonePrivate,
                BusinessPhone = phoneBuiness,
                EmailAddress = email,
                BusinessAddress = EmailBusiness,
                Note = note,
                Role = role,
                Department = Department,
                CadreLevel = NumCadreLevel,
                DateOfJoining = dateofjoining,
                DateOfLeaving = dateofleaving,
                CurrentApprenticeshipYear = currentApprenticeshipYear,
                YearsOfApprenticeship = yearsOfApprenticeship
            };

            SqliteDataAccess.SaveTrainee(t);
            // Show confirmation message
            MessageBox.Show($"Employee {t.FirstName} {t.LastName} has been created.", "Employee Creation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public Boolean CreateCustomer(string firstName, string lastName, string dateOfBirth, string customerNumber, int status, string gender, string salutation, string title,
                                    string street, string postalCode, string placeOfResidence, string nationality, string oasiNumber, string phonePrivate,
                                     string phoneBuiness, string emailBusiness, string email, string note, string companyName, string customerType, string companyContact, Form form)
        {
            Customer c = new Customer
            {
                Active = status,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                CustomerNumber = customerNumber,
                Gender = gender,
                Salutation = salutation,
                Title = title,
                Address = street,
                PostalCode = postalCode,
                PlaceOfResidence = placeOfResidence,
                Nationality = nationality,
                OasiNumber = oasiNumber,
                PrivatePhone = phonePrivate,
                BusinessPhone = phoneBuiness,
                EmailAddress = email,
                BusinessAddress = emailBusiness,
                Note = note,
                CompanyName = companyName,
                CustomerType = customerType,
                CompanyContact = companyContact

            };

            SqliteDataAccess.SaveCustomer(c);

            // Show confirmation message
            MessageBox.Show($"Employee {c.FirstName} {c.LastName} has been created.", "Employee Creation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        /// <summary>
        /// Check if the filters are set.
        /// </summary>
        /// <param name="filters">Filter states</param>
        /// <returns>True if no filter is set, else false</returns>
        public static bool FiltersAreClear(SearchFilters filters)
        {
            bool clear =
                string.IsNullOrEmpty(filters.Number) &&
                string.IsNullOrEmpty(filters.Title) &&
                string.IsNullOrEmpty(filters.Gender) &&
                string.IsNullOrEmpty(filters.Salutation) &&
                string.IsNullOrEmpty(filters.FirstName) &&
                string.IsNullOrEmpty(filters.LastName) &&
                string.IsNullOrEmpty(filters.DateOfBirth) &&
                string.IsNullOrEmpty(filters.Address) &&
                string.IsNullOrEmpty(filters.PostalCode) &&
                string.IsNullOrEmpty(filters.PlaceOfResidence) &&
                string.IsNullOrEmpty(filters.Nationality) &&
                string.IsNullOrEmpty(filters.OasiNumber) &&
                string.IsNullOrEmpty(filters.EmailAddress) &&
                string.IsNullOrEmpty(filters.PrivatePhone) &&
                string.IsNullOrEmpty(filters.BusinessPhone) &&
                string.IsNullOrEmpty(filters.BusinessAddress) &&

                string.IsNullOrEmpty(filters.CustomerType) &&
                string.IsNullOrEmpty(filters.CompanyName) &&
                string.IsNullOrEmpty(filters.CompanyContact) &&

                string.IsNullOrEmpty(filters.CurrentApprenticeshipYear) &&
                string.IsNullOrEmpty(filters.YearsOfApprenticeship) &&

                string.IsNullOrEmpty(filters.Departement) &&
                string.IsNullOrEmpty(filters.Role) &&
                string.IsNullOrEmpty(filters.CadreLevel) &&
                string.IsNullOrEmpty(filters.DegreeOfEmployment) &&
                string.IsNullOrEmpty(filters.DateOfJoining) &&
                string.IsNullOrEmpty(filters.DateOfLeaving);

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

            string inactiveCondition = (filters.SearchInactive) ? "(status = 0 OR status = 1)" : "status = 1";

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
        public static Dictionary<string, List<string>> createSqlConditions(SearchFilters filters)
        {
            Dictionary<string, List<string>> sqlConditions = new Dictionary<string, List<string>>() { };

            // General Information
            List<string> generic = new List<string>();
            if (!string.IsNullOrEmpty(filters.Title)) generic.Add($"title LIKE '%{filters.Title}%'");
            if (!string.IsNullOrEmpty(filters.Gender)) generic.Add($"gender LIKE '{filters.Gender}%'");
            if (!string.IsNullOrEmpty(filters.Salutation)) generic.Add($"Salutation LIKE '%{filters.Salutation}%'");
            if (!string.IsNullOrEmpty(filters.FirstName)) generic.Add($"firstName LIKE '%{filters.FirstName}%'");
            if (!string.IsNullOrEmpty(filters.LastName)) generic.Add($"lastName LIKE '%{filters.LastName}%'");
            if (!string.IsNullOrEmpty(filters.Address)) generic.Add($"street LIKE '%{filters.Address}%'");
            if (!string.IsNullOrEmpty(filters.PostalCode)) generic.Add($"postalCode LIKE '%{filters.PostalCode}%'");
            if (!string.IsNullOrEmpty(filters.DateOfBirth)) generic.Add($"dateOfBirth LIKE '%{filters.DateOfBirth}%'");
            if (!string.IsNullOrEmpty(filters.PlaceOfResidence)) generic.Add($"placeOfResidence LIKE '%{filters.PlaceOfResidence}%'");
            if (!string.IsNullOrEmpty(filters.Nationality)) generic.Add($"nationality LIKE '%{filters.Nationality}%'");
            if (!string.IsNullOrEmpty(filters.OasiNumber)) generic.Add($"oasiNumber LIKE '%{filters.OasiNumber}%'");
            if (!string.IsNullOrEmpty(filters.EmailAddress)) generic.Add($"emailAddress LIKE '%{filters.EmailAddress}%'");
            if (!string.IsNullOrEmpty(filters.PrivatePhone)) generic.Add($"privatePhone LIKE '%{filters.PrivatePhone}%'");
            if (!string.IsNullOrEmpty(filters.BusinessPhone)) generic.Add($"businessPhone LIKE '%{filters.BusinessPhone}%'");
            if (!string.IsNullOrEmpty(filters.BusinessAddress)) generic.Add($"businessAddress LIKE '%{filters.BusinessAddress}%'");
            sqlConditions["generic"] = generic;

            // Customer Information
            List<string> customer = new List<string>();
            if (!string.IsNullOrEmpty(filters.Number)) customer.Add($"CustomerNumber LIKE '%{filters.Number}%'");
            if (!string.IsNullOrEmpty(filters.CustomerType)) customer.Add($"customerType LIKE '%{filters.CustomerType}%'");
            if (!string.IsNullOrEmpty(filters.CompanyName)) customer.Add($"companyName LIKE '%{filters.CompanyName}%'");
            if (!string.IsNullOrEmpty(filters.CompanyContact)) customer.Add($"companyContact LIKE '%{filters.CompanyContact}%'");
            sqlConditions["customer"] = customer;

            // Employee Information
            List<string> employee = new List<string>();
            if (!string.IsNullOrEmpty(filters.Number)) employee.Add($"EmployeeNumber LIKE '%{filters.Number}%'");
            if (!string.IsNullOrEmpty(filters.Departement)) employee.Add($"departement LIKE '%{filters.Departement}%'");
            if (!string.IsNullOrEmpty(filters.Role)) employee.Add($"role LIKE '%{filters.Role}%'");
            if (!string.IsNullOrEmpty(filters.CadreLevel)) employee.Add($"cadreLevel LIKE '%{filters.CadreLevel}%'");
            if (!string.IsNullOrEmpty(filters.DegreeOfEmployment)) employee.Add($"degreeOfEmployment LIKE '%{filters.DegreeOfEmployment}%'");
            if (!string.IsNullOrEmpty(filters.DateOfJoining)) employee.Add($"dateOfJoining LIKE '%{filters.DateOfJoining}%'");
            if (!string.IsNullOrEmpty(filters.DateOfLeaving)) employee.Add($"dateOfLeaving LIKE '%{filters.DateOfLeaving}%'");
            sqlConditions["employee"] = employee;

            // Trainee Information
            List<string> trainee = new List<string>();
            if (!string.IsNullOrEmpty(filters.CurrentApprenticeshipYear)) trainee.Add($"currentApprenticeshipYear LIKE '%{filters.CurrentApprenticeshipYear}%'");
            if (!string.IsNullOrEmpty(filters.YearsOfApprenticeship)) trainee.Add($"yearsOfApprenticeship LIKE '%{filters.YearsOfApprenticeship}%'");
            sqlConditions["trainee"] = trainee;

            // Search Inactive Checkbox
            List<string> inactive = new List<string>();
            if (filters.SearchInactive) inactive.Add("(status = 0 OR status = 1)");
            else inactive.Add("status = 1");
            sqlConditions["inactive"] = inactive;

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
            Dictionary<string, List<string>> sqlConditions = createSqlConditions(filters);

            string genericQueryString = createQueryString(sqlConditions["generic"]);
            string customerQueryString = createQueryString(sqlConditions["customer"]);
            string employeeQueryString = createQueryString(sqlConditions["employee"]);
            string traineeQueryString = createQueryString(sqlConditions["trainee"]);
            string inactiveQueryString = createQueryString(sqlConditions["inactive"]);

            List<object> res = new List<object>();

            string customerSqlCondition = $"{((genericQueryString.Length > 0) ? genericQueryString + " AND " : "")}{((customerQueryString.Length > 0) ? customerQueryString + " AND " : "")}{inactiveQueryString}";
            if (types.Contains(typeof(Customer)) && employeeQueryString.Count() == 0 && traineeQueryString.Count() == 0) res.AddRange(SqliteDataAccess.SearchPersonsByQueryString(new List<Type>() { typeof(Customer) }, customerSqlCondition));

            string employeeSqlCondition = $"{((genericQueryString.Length > 0) ? genericQueryString + " AND " : "")}{((employeeQueryString.Length > 0) ? employeeQueryString + " AND " : "")}{inactiveQueryString}";
            if (types.Contains(typeof(Employee)) && customerQueryString.Count() == 0 && traineeQueryString.Count() == 0) res.AddRange(SqliteDataAccess.SearchPersonsByQueryString(new List<Type>() { typeof(Employee) }, employeeSqlCondition));

            string traineeSqlCondition = $"{((genericQueryString.Length > 0) ? genericQueryString + " AND " : "")}{((employeeQueryString.Length > 0) ? employeeQueryString + " AND " : "")}{((traineeQueryString.Length > 0) ? traineeQueryString + " AND " : "")}{inactiveQueryString}";
            if (types.Contains(typeof(Trainee)) && customerQueryString.Count() == 0) res.AddRange(SqliteDataAccess.SearchPersonsByQueryString(new List<Type>() { typeof(Trainee) }, traineeSqlCondition));

            return res;
        }
    }
}

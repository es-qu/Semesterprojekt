using ContactManager.Entity;
using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ContactManager
{
    internal class Controller
    {
        public Boolean CreateEmployee(Employee employee, Form form, bool isUpdate = false, bool showSuccessMessage = true)
        {
            Employee e = new Employee
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Gender = employee.Gender,
                Salutation = employee.Salutation,
                Title = employee.Title,
                Address = employee.Address,
                PostalCode = employee.PostalCode,
                PlaceOfResidence = employee.PlaceOfResidence,
                Nationality = employee.Nationality,
                OasiNumber = employee.OasiNumber,
                DateOfBirth = employee.DateOfBirth,
                PrivatePhone = employee.PrivatePhone,
               BusinessPhone = employee.BusinessPhone,
                EmailAddress = employee.EmailAddress,
                BusinessAddress = employee.BusinessAddress,
                Note = employee.Note,
                EmployeeNumber = employee.EmployeeNumber,
                Role = employee.Role,
                Department = employee.Department,
                Active = employee.Active,
                DateOfJoining = employee.DateOfJoining,
                DateOfLeaving = employee.DateOfLeaving,
                CadreLevel = employee.CadreLevel,

            };

            SqliteDataAccess.SaveEmployee(e);

            if (showSuccessMessage)
            {
                string message = isUpdate
                ? $"Employee {e.FirstName} {e.LastName} has been updated."
                : $"Employee {e.FirstName} {e.LastName} has been created.";
                MessageBox.Show(message, "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return true;
        }

        public Boolean CreateTrainee(Trainee trainee, Form form, bool isUpdate = false, bool showSuccessMessage = true)
        {
            Trainee t = new Trainee
            {
                FirstName = trainee.FirstName,
                LastName = trainee.LastName,
                Gender = trainee.Gender,
                Salutation = trainee.Salutation,
                Title = trainee.Title,
                Address = trainee.Address,
                PostalCode = trainee.PostalCode,
                PlaceOfResidence = trainee.PlaceOfResidence,
                Nationality = trainee.Nationality,
                OasiNumber = trainee.OasiNumber,
                DateOfBirth = trainee.DateOfBirth,
                PrivatePhone = trainee.PrivatePhone,
                BusinessPhone = trainee.BusinessPhone,
                EmailAddress = trainee.EmailAddress,
                BusinessAddress = trainee.BusinessAddress,
                Note = trainee.Note,
                EmployeeNumber = trainee.EmployeeNumber,
                Role = trainee.Role,
                Department = trainee.Department,
                Active = trainee.Active,
                DateOfJoining = trainee.DateOfJoining,
                DateOfLeaving = trainee.DateOfLeaving,
                CadreLevel = trainee.CadreLevel,
                CurrentApprenticeshipYear = trainee.CurrentApprenticeshipYear,
                YearsOfApprenticeship = trainee.YearsOfApprenticeship

            };


            SqliteDataAccess.SaveTrainee(t);
            if (showSuccessMessage)
            {
                // Show confirmation message
                string message = isUpdate
                ? $"Trainee {t.FirstName} {t.LastName} has been updated."
                : $"Trainee {t.FirstName} {t.LastName} has been created.";
                MessageBox.Show(message, "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }




        public Boolean CreateCustomer(Customer customer, Form form, bool isUpdate = false, bool showSuccessMessage = true)
        {
            Customer c = new Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Gender = customer.Gender,
                Salutation = customer.Salutation,
                Title = customer.Title,
                Address = customer.Address,
                PostalCode = customer.PostalCode,
                PlaceOfResidence = customer.PlaceOfResidence,
                Nationality = customer.Nationality,
                OasiNumber = customer.OasiNumber,
                DateOfBirth = customer.DateOfBirth,
                PrivatePhone = customer.PrivatePhone,
                BusinessPhone = customer.BusinessPhone,
                EmailAddress = customer.EmailAddress,
                BusinessAddress = customer.BusinessAddress,
                Note = customer.Note,
                CustomerNumber = customer.CustomerNumber,
                CompanyName = customer.CompanyName,
                CustomerType = customer.CustomerType,
                CompanyContact = customer.CompanyContact

            };

            SqliteDataAccess.SaveCustomer(c);

            if (showSuccessMessage)
            {
                // Show confirmation message
                string message = isUpdate
             ? $"Customer {c.FirstName} {c.LastName} has been updated."
             : $"Customer {c.FirstName} {c.LastName} has been created.";
                MessageBox.Show(message, "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }



        public void Log(LogTable log)
        {
            log.OperationSuccessful = true;
            log.DeletionSuccessful = false;

            SqliteDataAccess.SaveLog(log);
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
                string.IsNullOrEmpty(filters.Address) &&
                string.IsNullOrEmpty(filters.PostalCode) &&
                string.IsNullOrEmpty(filters.PlaceOfResidence) &&
                string.IsNullOrEmpty(filters.Nationality) &&
                string.IsNullOrEmpty(filters.OasiNumber) &&
                string.IsNullOrEmpty(filters.DateOfBirth) &&
                string.IsNullOrEmpty(filters.EmailAddress) &&
                string.IsNullOrEmpty(filters.PrivatePhone) &&
                string.IsNullOrEmpty(filters.BusinessPhone) &&
                string.IsNullOrEmpty(filters.BusinessAddress) &&

                string.IsNullOrEmpty(filters.CustomerType) &&
                string.IsNullOrEmpty(filters.CompanyName) &&
                string.IsNullOrEmpty(filters.CompanyContact) &&

                string.IsNullOrEmpty(filters.Departement) &&
                string.IsNullOrEmpty(filters.Role) &&
                string.IsNullOrEmpty(filters.CadreLevel) &&
                string.IsNullOrEmpty(filters.DegreeOfEmployment) &&
                string.IsNullOrEmpty(filters.DateOfJoining) &&
                string.IsNullOrEmpty(filters.DateOfLeaving) &&

                string.IsNullOrEmpty(filters.CurrentApprenticeshipYear) &&
                string.IsNullOrEmpty(filters.YearsOfApprenticeship);

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
                $"FirstName LIKE '%{searchTerm}%' " +
                $"OR LastName LIKE '%{searchTerm}%' " +
                $"OR Address LIKE '%{searchTerm}%' " +
                $"OR PlaceOfResidence LIKE '%{searchTerm}%' " +
                $"OR DateOfBirth LIKE '%{searchTerm}%'";

            string inactiveCondition = (filters.SearchInactive) ? "(Active = 0 OR Active = 1)" : "Active = 1";

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
            if (!string.IsNullOrEmpty(filters.Title)) generic.Add($"Title LIKE '%{filters.Title}%'");
            if (!string.IsNullOrEmpty(filters.Gender)) generic.Add($"Gender LIKE '{filters.Gender}%'");
            if (!string.IsNullOrEmpty(filters.Salutation)) generic.Add($"Salutation LIKE '%{filters.Salutation}%'");
            if (!string.IsNullOrEmpty(filters.FirstName)) generic.Add($"FirstName LIKE '%{filters.FirstName}%'");
            if (!string.IsNullOrEmpty(filters.LastName)) generic.Add($"LastName LIKE '%{filters.LastName}%'");
            if (!string.IsNullOrEmpty(filters.Address)) generic.Add($"Address LIKE '%{filters.Address}%'");
            if (!string.IsNullOrEmpty(filters.PostalCode)) generic.Add($"PostalCode LIKE '%{filters.PostalCode}%'");
            if (!string.IsNullOrEmpty(filters.DateOfBirth)) generic.Add($"DateOfBirth LIKE '%{filters.DateOfBirth}%'");
            if (!string.IsNullOrEmpty(filters.PlaceOfResidence)) generic.Add($"PlaceOfResidence LIKE '%{filters.PlaceOfResidence}%'");
            if (!string.IsNullOrEmpty(filters.Nationality)) generic.Add($"Nationality LIKE '%{filters.Nationality}%'");
            if (!string.IsNullOrEmpty(filters.OasiNumber)) generic.Add($"OasiNumber LIKE '%{filters.OasiNumber}%'");
            if (!string.IsNullOrEmpty(filters.EmailAddress)) generic.Add($"EmailAddress LIKE '%{filters.EmailAddress}%'");
            if (!string.IsNullOrEmpty(filters.PrivatePhone)) generic.Add($"PrivatePhone LIKE '%{filters.PrivatePhone}%'");
            if (!string.IsNullOrEmpty(filters.BusinessPhone)) generic.Add($"BusinessPhone LIKE '%{filters.BusinessPhone}%'");
            if (!string.IsNullOrEmpty(filters.BusinessAddress)) generic.Add($"BusinessAddress LIKE '%{filters.BusinessAddress}%'");
            sqlConditions["generic"] = generic;

            // Customer Information
            List<string> customer = new List<string>();
            if (!string.IsNullOrEmpty(filters.Number)) customer.Add($"CustomerNumber LIKE '%{filters.Number}%'");
            if (!string.IsNullOrEmpty(filters.CustomerType)) customer.Add($"CustomerType LIKE '%{filters.CustomerType}%'");
            if (!string.IsNullOrEmpty(filters.CompanyName)) customer.Add($"CompanyName LIKE '%{filters.CompanyName}%'");
            if (!string.IsNullOrEmpty(filters.CompanyContact)) customer.Add($"CompanyContact LIKE '%{filters.CompanyContact}%'");
            sqlConditions["customer"] = customer;

            // Employee Information
            List<string> employee = new List<string>();
            if (!string.IsNullOrEmpty(filters.Number)) employee.Add($"EmployeeNumber LIKE '%{filters.Number}%'");
            if (!string.IsNullOrEmpty(filters.Departement)) employee.Add($"Departement LIKE '%{filters.Departement}%'");
            if (!string.IsNullOrEmpty(filters.Role)) employee.Add($"Role LIKE '%{filters.Role}%'");
            if (!string.IsNullOrEmpty(filters.CadreLevel)) employee.Add($"CadreLevel LIKE '%{filters.CadreLevel}%'");
            if (!string.IsNullOrEmpty(filters.DegreeOfEmployment)) employee.Add($"DegreeOfEmployment LIKE '%{filters.DegreeOfEmployment}%'");
            if (!string.IsNullOrEmpty(filters.DateOfJoining)) employee.Add($"DateOfJoining LIKE '%{filters.DateOfJoining}%'");
            if (!string.IsNullOrEmpty(filters.DateOfLeaving)) employee.Add($"DateOfLeaving LIKE '%{filters.DateOfLeaving}%'");
            sqlConditions["employee"] = employee;

            // Trainee Information
            List<string> trainee = new List<string>();
            if (!string.IsNullOrEmpty(filters.CurrentApprenticeshipYear)) trainee.Add($"CurrentApprenticeshipYear LIKE '%{filters.CurrentApprenticeshipYear}%'");
            if (!string.IsNullOrEmpty(filters.YearsOfApprenticeship)) trainee.Add($"YearsOfApprenticeship LIKE '%{filters.YearsOfApprenticeship}%'");
            sqlConditions["trainee"] = trainee;

            // Search Inactive Checkbox
            List<string> inactive = new List<string>();
            if (filters.SearchInactive) inactive.Add("(Active = 0 OR Active = 1)");
            else inactive.Add("Active = 1");
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


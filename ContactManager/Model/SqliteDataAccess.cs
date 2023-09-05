using ContactManager.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;

namespace ContactManager
{
    internal class SqliteDataAccess
    {
        public static void SaveCustomer(Customer customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Person (Active , Gender, Salutation, Title, FirstName, LastName, Address, PostalCode,PlaceOfResidence, Nationality, OasiNumber, DateOfBirth, PrivatePhone, BusinessAddress, BusinessPhone, EmailAddress, Note)  " +
                    " VALUES (@Active, @Gender, @Salutation, @Title, @FirstName, @LastName, @Address, @PostalCode,  @PlaceOfResidence, @Nationality, @OasiNumber, @DateOfBirth, @PrivatePhone,  @BusinessAddress, @BusinessPhone, @EmailAddress, @Note)",
                    new
                    {
                        customer.Active,
                        customer.Gender,
                        customer.Salutation,
                        customer.Title,
                        customer.FirstName,
                        customer.LastName,
                        customer.Address,
                        customer.PostalCode,
                        customer.PlaceOfResidence,
                        customer.Nationality,
                        customer.OasiNumber,
                        customer.DateOfBirth,
                        customer.PrivatePhone,
                        customer.EmailAddress,
                        customer.BusinessPhone,
                        customer.BusinessAddress,
                        customer.Note
                    });

                int lastId = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                cnn.Execute("INSERT INTO Customer (ID,CompanyName, CustomerType,CompanyContact,CustomerNumber) " +
                    "VALUES (@Id, @CompanyName, @CustomerType,@CompanyContact,@CustomerNumber)",
                new
                {
                    Id = lastId,
                    customer.CompanyName,
                    customer.CustomerType,
                    customer.CompanyContact,
                    customer.CustomerNumber
                });
            }

        }


        private static string LoadConnectionString(String id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void SaveTrainee(Trainee trainee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Insert into Person, Employee and Trainee tables
                var TraineeId = cnn.Query<int>("SELECT ID FROM Employee WHERE EmployeeNumber = @EmployeeNumber", new { EmployeeNumber = trainee.EmployeeNumber }).FirstOrDefault();
                if (TraineeId == 0)
                {
                    int rowsAffected = cnn.Execute(
                   "INSERT INTO Person (Active, Gender, Salutation, Title, FirstName, LastName, Address, PostalCode,PlaceOfResidence, Nationality, OasiNumber, DateOfBirth, PrivatePhone, BusinessAddress, BusinessPhone, EmailAddress, Note)  " +
                   " VALUES (@Active, @Gender, @Salutation, @Title, @FirstName, @LastName, @Address, @PostalCode,  @PlaceOfResidence, @Nationality, @OasiNumber, @DateOfBirth, @PrivatePhone,  @BusinessAddress, @BusinessPhone, @EmailAddress, @Note)",
                   new
                   {
                       trainee.Active,
                       trainee.Gender,
                       trainee.Salutation,
                       trainee.Title,
                       trainee.FirstName,
                       trainee.LastName,
                       trainee.Address,
                       trainee.PostalCode,
                       trainee.PlaceOfResidence,
                       trainee.Nationality,
                       trainee.OasiNumber,
                       trainee.DateOfBirth,
                       trainee.PrivatePhone,
                       trainee.BusinessAddress,
                       trainee.BusinessPhone,
                       trainee.EmailAddress,
                       trainee.Note
                   });
                    if (rowsAffected > 0)
                    {
                        int lastId = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                        cnn.Execute(
                            "INSERT INTO Employee (ID, Role, Department, DegreeOfEmployment, EmployeeNumber,DateOfJoining,DateOfLeaving,CadreLevel) VALUES (@Id, @Role, @Department, @DegreeOfEmployment, @EmployeeNumber,@DateOfJoining,@DateOfLeaving,@CadreLevel)",
                            new
                            {
                                Id = lastId,
                                trainee.Role,
                                trainee.Department,
                                trainee.DegreeOfEmployment,
                                trainee.EmployeeNumber,
                                trainee.DateOfJoining,
                                trainee.DateOfLeaving,
                                trainee.CadreLevel
                            });
                        cnn.Execute(
                            "INSERT INTO Trainee (ID, CurrentApprenticeshipYear, YearsOfApprenticeship) VALUES (@Id, @CurrentApprenticeshipYear, @YearsOfApprenticeship)",
                            new
                            {
                                Id = lastId,
                                trainee.CurrentApprenticeshipYear,
                                trainee.YearsOfApprenticeship
                            });
                    }

                }
                else
                {
                    // Only insert into Trainee table...
                    cnn.Execute(
                        "INSERT INTO Trainee (ID, CurrentApprenticeshipYear, YearsOfApprenticeship) VALUES (@Id, @CurrentApprenticeshipYear, @YearsOfApprenticeship)",
                        new
                        {
                            Id = TraineeId,
                            trainee.CurrentApprenticeshipYear,
                            trainee.YearsOfApprenticeship
                        });
                }
            }
        }



        public static void SaveEmployee(Employee employee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Person (Active , Gender, Salutation, Title, FirstName, LastName, Address, PostalCode,PlaceOfResidence, Nationality, OasiNumber, DateOfBirth, PrivatePhone, BusinessAddress, BusinessPhone, EmailAddress, Note)  " +
               " VALUES ( @Active, @Gender, @Salutation, @Title, @FirstName, @LastName, @Address, @PostalCode,  @PlaceOfResidence, @Nationality, @OasiNumber, @DateOfBirth, @PrivatePhone,  @BusinessAddress, @BusinessPhone, @EmailAddress, @Note)",
                new
                {

                    employee.Active,
                    employee.Gender,
                    employee.Salutation,
                    employee.Title,
                    employee.FirstName,
                    employee.LastName,
                    employee.Address,
                    employee.PostalCode,
                    employee.PlaceOfResidence,
                    employee.Nationality,
                    employee.OasiNumber,
                    employee.DateOfBirth,
                    employee.PrivatePhone,
                    employee.EmailAddress,
                    employee.BusinessPhone,
                    employee.BusinessAddress,
                    employee.Note
                });

                int lastId_e = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                cnn.Execute("INSERT INTO Employee (ID, Role, Department, DegreeOfEmployment, EmployeeNumber,DateOfJoining,DateOfLeaving,CadreLevel) VALUES (@Id, @Role, @Department, @DegreeOfEmployment, @EmployeeNumber,@DateOfJoining,@DateOfLeaving,@CadreLevel)",
                new
                {
                    Id = lastId_e,
                    employee.Role,
                    employee.Department,
                    employee.DegreeOfEmployment,
                    employee.EmployeeNumber,
                    employee.DateOfJoining,
                    employee.DateOfLeaving,
                    employee.CadreLevel
                });
            }
        }





        public static string GetNextNumber(string tableName, string columnName, string idType)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string prefix;
                int prefixLength;
                if (idType == "EMP")
                {
                    prefix = "EMP";
                    prefixLength = 3;
                }
                else if (idType == "CUST")
                {
                    prefix = "CUST";
                    prefixLength = 4;
                }
                else
                {
                    throw new ArgumentException("Invalid idType");
                }
                var defaultNumber = prefix + new string('0', prefixLength);
                var maxNumberStr = cnn.Query<string>($"SELECT IFNULL(MAX({columnName}), '{defaultNumber}') FROM {tableName}").FirstOrDefault();
                int maxNumberInt = int.Parse(maxNumberStr.Substring(prefixLength));
                if (maxNumberInt > 0)
                {
                    maxNumberInt++;
                }
                else
                {
                    maxNumberInt = 1;
                }
                return prefix + maxNumberInt.ToString("D" + prefixLength);
            }
        }


        public static bool DeleteEmployee(string employeeNumber)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // First, get the ID of the person associated with the employee
                var personId = cnn.Query<int>("SELECT ID FROM Employee WHERE EmployeeNumber = @EmployeeNumber", new { EmployeeNumber = employeeNumber }).FirstOrDefault();

                if (personId != 0) // If the employee is found
                {
                    // Check if the person is also a Trainee
                    var isTrainee = cnn.Query<int>("SELECT COUNT(*) FROM Trainee WHERE ID = @ID", new { ID = personId }).Single() > 0;

                    if (isTrainee)
                    {
                        // If the person is also a Trainee, just delete the Employee record
                        return cnn.Execute("DELETE FROM Employee WHERE EmployeeNumber = @EmployeeNumber", new { EmployeeNumber = employeeNumber }) > 0;

                    }
                    else
                    {
                        // If the person is not a Trainee, delete both the Employee and the Person record
                        var employeeDeleted = cnn.Execute("DELETE FROM Employee WHERE EmployeeNumber = @EmployeeNumber", new { EmployeeNumber = employeeNumber });

                        var personDeleted = cnn.Execute("DELETE FROM Person WHERE ID = @ID", new { ID = personId });

                        return employeeDeleted > 0 && personDeleted > 0;
                    }
                }

                return false; // If the employee was not found, return false
            }
        }


        public static bool DeleteCustomer(string customerNumber)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // First, get the ID of the person associated with the customer
                var personId = cnn.Query<int>("SELECT ID FROM Customer WHERE CustomerNumber = @CustomerNumber", new { CustomerNumber = customerNumber }).FirstOrDefault();

                if (personId != 0) // If the customer is found
                {
                    // Delete the customer
                    var customerDeleted = cnn.Execute("DELETE FROM Customer WHERE CustomerNumber = @CustomerNumber", new { CustomerNumber = customerNumber });

                    // Delete the person
                    var personDeleted = cnn.Execute("DELETE FROM Person WHERE ID = @ID", new { ID = personId });

                    // Return true if both deletions were successful (i.e., affected at least one row)
                    return customerDeleted > 0 && personDeleted > 0;
                }

                // If the customer was not found, return false
                return false;
            }
        }



        /// <summary>
        /// Search for contacts in db according to a list of the chosen types and a query string.
        /// Adds the data from multiple queries into one list to be returned.
        /// </summary>
        /// <param name="types">Selected types of Person</param>
        /// <param name="queryString">WHERE condition to filter results</param>
        /// <returns>Instances of objects inheriting from Person according to selected types</returns>
        public static List<object> SearchPersonsByQueryString(List<Type> types, string queryString)
        {
            List<object> results = new List<object>();

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                foreach (Type t in types)
                {
                    switch (t)
                    {
                        case Type type when type == typeof(Customer):
                            results.AddRange(SearchTableByQueryString<Customer>(conn, queryString));
                            break;

                        case Type type when type == typeof(Employee):
                            results.AddRange(SearchTableByQueryString<Employee>(conn, queryString));
                            break;

                        case Type type when type == typeof(Trainee):
                            results.AddRange(SearchTableByQueryString<Trainee>(conn, queryString));
                            break;

                        default:
                            break;
                    }
                }

                conn.Close();
            }

            return results;
        }

        /// <summary>
        /// The actual SQL SELECT gets done here.
        /// One type of Person at a time can be browsed.
        /// </summary>
        /// <typeparam name="Type">
        /// Accepts a Type that inherits from Person.
        /// This defines the Type of the response and the table to join.
        /// </typeparam>
        /// <param name="conn">SQL db connection</param>
        /// <param name="queryString">WHERE condition</param>
        /// <returns></returns>
        private static List<Type> SearchTableByQueryString<Type>(SQLiteConnection conn, string queryString) where Type : Person, new()
        {
            string joinTargetTableName = typeof(Type).Name;

            string query = (typeof(Type) != typeof(Trainee))
                ? $"SELECT * FROM Person INNER JOIN {joinTargetTableName} ON Person.id = {joinTargetTableName}.id WHERE NOT EXISTS (SELECT 1 FROM Trainee WHERE Trainee.id = {joinTargetTableName}.id) AND {queryString}"
                : $"SELECT * FROM Person INNER JOIN Employee ON Person.id = Employee.id INNER JOIN {joinTargetTableName} ON Person.id = {joinTargetTableName}.id WHERE {queryString}";


            return conn.Query<Type>(query).AsList();
        }
    }
}


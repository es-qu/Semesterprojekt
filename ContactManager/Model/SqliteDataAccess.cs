using ContactManager.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace ContactManager
{
    internal class SqliteDataAccess
    {
        //public static List<Person> LoadPeople(string SearchText)
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var output = cnn.Query<Person>("Select * from Person where firstName like @Name or lastName like @Name",
        //        new { Name = "%" + SearchText + "%" });
        //        return output.ToList();
        //    }
        //}

        public static void SaveCustomer(Customer customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                cnn.Execute("INSERT INTO Person (status , gender, Salutation, title, firstName, lastName, street, postalCode,placeOfResidence, nationality, socialSecurityNumber, dateOfBirth, phoneNumberPrivat, EmailBusiness, phoneNumberBusiness, email, Note)  " +
                    " VALUES (@status, @gender, @Salutation, @title, @firstName, @lastName, @street, @postalCode,  @placeOfResidence, @nationality, @socialSecurityNumber, @dateOfBirth, @phoneNumberPrivat,  @EmailBusiness, @phoneNumberBusiness, @email, @note)",
                    new
                    {

                        customer.status,
                        customer.gender,
                        customer.Salutation,
                        customer.title,
                        customer.firstName,
                        customer.lastName,
                        customer.street,
                        customer.postalCode,
                        customer.placeOfResidence,
                        customer.nationality,
                        customer.socialSecurityNumber,
                        customer.dateOfBirth,
                        customer.phoneNumberPrivat,
                        customer.email,
                        customer.phoneNumberBusiness,
                        customer.EmailBusiness,
                        customer.note
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

                int rowsAffected = cnn.Execute(
                        "INSERT INTO Person (status, gender, Salutation, title, firstName, lastName, street, postalCode,placeOfResidence, nationality, socialSecurityNumber, dateOfBirth, phoneNumberPrivat, EmailBusiness, phoneNumberBusiness, email, Note)  " +
                        " VALUES (@status, @gender, @Salutation, @title, @firstName, @lastName, @street, @postalCode,  @placeOfResidence, @nationality, @socialSecurityNumber, @dateOfBirth, @phoneNumberPrivat,  @EmailBusiness, @phoneNumberBusiness, @email, @note)",
                        new
                        {
                            trainee.status,
                            trainee.gender,
                            trainee.Salutation,
                            trainee.title,
                            trainee.firstName,
                            trainee.lastName,
                            trainee.street,
                            trainee.postalCode,
                            trainee.placeOfResidence,
                            trainee.nationality,
                            trainee.socialSecurityNumber,
                            trainee.dateOfBirth,
                            trainee.phoneNumberPrivat,
                            trainee.email,
                            trainee.phoneNumberBusiness,
                            trainee.EmailBusiness,
                            trainee.note
                        });
                if (rowsAffected > 0)
                {
                    int lastId = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                    cnn.Execute(
                        "INSERT INTO Employee (ID, Position, Department, EmployeeNumber,dateofjoining,dateofleaving,NumCadreLevel) VALUES (@Id, @Position, @Department, @EmployeeNumber,@dateofjoining,@dateofleaving,@NumCadreLevel)",
                        new
                        {
                            Id = lastId,
                            trainee.Position,
                            trainee.Department,
                            trainee.EmployeeNumber,
                            trainee.dateofjoining,
                            trainee.dateofleaving,
                            trainee.NumCadreLevel
                        });
                    cnn.Execute(
                        "INSERT INTO Trainee (ID, TrainingStartDate, TrainingEndDate) VALUES (@Id, @TrainingStartDate, @TrainingEndDate)",
                        new
                        {
                            Id = lastId,
                            trainee.TrainingStartDate,
                            trainee.TrainingEndDate
                        });
                }
            }
        }



        public static void SaveEmployee(Employee employee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Person (status , gender, Salutation, title, firstName, lastName, street, postalCode,placeOfResidence, nationality, socialSecurityNumber, dateOfBirth, phoneNumberPrivat, EmailBusiness, phoneNumberBusiness, email, Note)  " +
               " VALUES ( @status, @gender, @Salutation, @title, @firstName, @lastName, @street, @postalCode,  @placeOfResidence, @nationality, @socialSecurityNumber, @dateOfBirth, @phoneNumberPrivat,  @EmailBusiness, @phoneNumberBusiness, @email, @note)",
                new
                {

                    employee.status,
                    employee.gender,
                    employee.Salutation,
                    employee.title,
                    employee.firstName,
                    employee.lastName,
                    employee.street,
                    employee.postalCode,
                    employee.placeOfResidence,
                    employee.nationality,
                    employee.socialSecurityNumber,
                    employee.dateOfBirth,
                    employee.phoneNumberPrivat,
                    employee.email,
                    employee.phoneNumberBusiness,
                    employee.EmailBusiness,
                    employee.note
                });

                int lastId_e = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                cnn.Execute("INSERT INTO Employee (ID, Position, Department, EmployeeNumber,dateofjoining,dateofleaving,NumCadreLevel) VALUES (@Id, @Position, @Department, @EmployeeNumber,@dateofjoining,@dateofleaving,@NumCadreLevel)",
                new
                {
                    Id = lastId_e,
                    employee.Position,
                    employee.Department,
                    employee.EmployeeNumber,
                    employee.dateofjoining,
                    employee.dateofleaving,
                    employee.NumCadreLevel
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


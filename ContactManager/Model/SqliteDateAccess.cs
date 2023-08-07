using ContactManager.Model;
using Dapper;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text.RegularExpressions;

namespace ContactManager
{
    internal class SqliteDateAccess
    {
        // search text.
        public static List<Employee> LoadPeople(string SearchText)
        {
            // Establish a connection to the SQLite database.
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Execute a query to fetch the Employees, where any of firstName, lastName, or EmployeeNumber matches the search text.
                var output = cnn.Query<Employee>("SELECT * FROM Person JOIN Employee ON Person.ID = Employee.ID " +
                    "where firstName like @Name or lastName like @Name OR Employee.EmployeeNumber like @Name",
                new { Name = "%" + SearchText + "%" });
                return output.ToList();
            }
        }

        public static void SaveCustomer(Customer customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                int lastId = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Customer").Single();
                customer.Id = lastId + 1;
                cnn.Execute("INSERT INTO Customer(ID, FirstName, LastName, dateOfBirth, CompanyName, CustomerType, CompanyContact) values(@Id,@firstName,@lastName,@dateOfBirth, @CompanyName, @CustomerType, @CompanyContact)", customer);
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
                int lastId = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                trainee.Id = lastId + 1;
                cnn.Execute("INSERT INTO Person (ID,status , gender, Salutation, title, firstName, lastName, street,  postalCode,placeOfResidence, nationality, socialSecurityNumber, dateOfBirth, phoneNumberPrivat, phoneNumberBusiness, email, Note)  " +
                    " VALUES (@Id, @status, @gender, @Salutation, @title, @firstName, @lastName, @street, @postalCode,  @placeOfResidence, @nationality, @socialSecurityNumber, @dateOfBirth, @phoneNumberPrivat, @phoneNumberBusiness, @email, @note)",
                    new
                    {
                        trainee.Id,
                        status = trainee.status ? "true" : "false",
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
                        trainee.phoneNumberBusiness,
                        trainee.email,
                        trainee.note
                    });

                int lastId_e = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                cnn.Execute("INSERT INTO Employee (ID, Position, Department, EmployeeNumber,dateofjoining,dateofleaving,NumCadreLevel) VALUES (@Id, @Position, @Department, @EmployeeNumber,@dateofjoining,@dateofleaving,@NumCadreLevel)",
                new
                {
                    Id = lastId_e,
                    trainee.Position,
                    trainee.Department,
                    trainee.EmployeeNumber,
                    trainee.dateofjoining,
                    trainee.dateofleaving,
                    trainee.NumCadreLevel

                });

                int lastId_em = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                cnn.Execute("INSERT INTO Employee (ID, TrainingEndDate, TrainingStartDate) VALUES (@Id, @TrainingEndDate, @TrainingStartDate)",
                new
                {
                    Id = lastId_em,
                    trainee.TrainingEndDate,
                    trainee.TrainingStartDate

                });
            }
        }
        // This method saves an Employee object to the SQLite database.
        public static void SaveEmployee(Employee employee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //Fetch the maximum ID from the Person table and increment it by 1 to assign it to the new Employee.
                int lastId = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                employee.Id = lastId + 1;
                // Execute a query to insert the Employee object into the Person table.
                cnn.Execute("INSERT INTO Person (ID,status , gender, Salutation, title, firstName, lastName, street,  postalCode,placeOfResidence, nationality, socialSecurityNumber, dateOfBirth, phoneNumberPrivat, phoneNumberBusiness, email, Note)  " +
                    " VALUES (@Id, @status, @gender, @Salutation, @title, @firstName, @lastName, @street, @postalCode,  @placeOfResidence, @nationality, @socialSecurityNumber, @dateOfBirth, @phoneNumberPrivat, @phoneNumberBusiness, @email, @note)",
                    new
                    {
                        employee.Id,
                        status = employee.status ? "true" : "false",
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
                        employee.phoneNumberBusiness,
                        employee.email,
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
    }
}

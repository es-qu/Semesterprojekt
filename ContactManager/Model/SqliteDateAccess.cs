﻿using ContactManager.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace ContactManager
{
    internal class SqliteDateAccess
    {
        public static List<Person> LoadPeople(string SearchText)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Person>("Select * from Person where firstName like @Name or lastName like @Name",
                new { Name = "%" + SearchText + "%" });
                return output.ToList();
            }
        }

        public static void SaveCustomer(Customer customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                int lastId = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                customer.Id = lastId + 1;
                cnn.Execute("INSERT INTO Person (ID,status , gender, Salutation, title, firstName, lastName, street, postalCode,placeOfResidence, nationality, socialSecurityNumber, dateOfBirth, phoneNumberPrivat, phoneNumberMobile, phoneNumberBusiness, email, Note)  " +
                    " VALUES (@Id, @status, @gender, @Salutation, @title, @firstName, @lastName, @street, @postalCode,  @placeOfResidence, @nationality, @socialSecurityNumber, @dateOfBirth, @phoneNumberPrivat,  @phoneNumberMobile, @phoneNumberBusiness, @email, @note)",
                    new
                    {
                        customer.Id,
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
                        customer.phoneNumberMobile,
                        customer.phoneNumberBusiness,
                        customer.email,
                        customer.note
                    });
                int lastId_e = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                cnn.Execute("INSERT INTO Customer (ID, CompanyName, CustomerType,CompanyContact,CustomerNumber) VALUES (@Id, @CompanyName, @CustomerType,@CompanyContact,@CustomerNumber)",
                new
                {
                    Id = lastId_e,
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
                int lastId = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                trainee.Id = lastId + 1;
                cnn.Execute("INSERT INTO Person (ID,status , gender, Salutation, title, firstName, lastName, street, postalCode,placeOfResidence, nationality, socialSecurityNumber, dateOfBirth, phoneNumberPrivat, phoneNumberMobile, phoneNumberBusiness, email, Note)  " +
                    " VALUES (@Id, @status, @gender, @Salutation, @title, @firstName, @lastName, @street, @postalCode,  @placeOfResidence, @nationality, @socialSecurityNumber, @dateOfBirth, @phoneNumberPrivat,  @phoneNumberMobile, @phoneNumberBusiness, @email, @note)",
                    new
                    {
                        trainee.Id,
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
                        trainee.phoneNumberMobile,
                        trainee.phoneNumberBusiness,
                        trainee.email,
                        trainee.note
                    });
                int lastId_e = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                cnn.Execute("INSERT INTO Trainee (ID, TrainingStartDate, TrainingEndDate) VALUES (@Id, @TrainingStartDate, @TrainingEndDate)",
                new
                {
                    Id = lastId_e,
                    trainee.TrainingStartDate,
                    trainee.TrainingEndDate

                });
            }
        }

        public static void SaveEmployee(Employee employee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                int lastId = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                employee.Id = lastId + 1;
                cnn.Execute("INSERT INTO Person (ID,status , gender, Salutation, title, firstName, lastName, street, postalCode,placeOfResidence, nationality, socialSecurityNumber, dateOfBirth, phoneNumberPrivat, phoneNumberMobile, phoneNumberBusiness, email, Note)  " +
                    " VALUES (@Id, @status, @gender, @Salutation, @title, @firstName, @lastName, @street, @postalCode,  @placeOfResidence, @nationality, @socialSecurityNumber, @dateOfBirth, @phoneNumberPrivat,  @phoneNumberMobile, @phoneNumberBusiness, @email, @note)",
                    new
                    {
                        employee.Id,
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
                        employee.phoneNumberMobile,
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


        public static string GetNextNumber(string tableName, string columnName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var maxNumber = cnn.Query<string>($"SELECT IFNULL(MAX({columnName}), 0) FROM {tableName}").FirstOrDefault();
                return maxNumber + 1;
            }
=======
        public static List<Person> SearchPersonsByFullText(string searchTerm, bool searchInactive)
        {
            List<Person> results = new List<Person>();

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                results.AddRange(SearchTableByFullText<Person>(conn, searchTerm, searchInactive));
                conn.Close();
            }

            return results;
        }

        private static List<Type> SearchTableByFullText<Type>(SQLiteConnection conn, string searchTerm, bool searchInactive) where Type : Person, new()
        {
            string tableName = typeof(Type).Name;
            string query = $"SELECT * FROM {tableName} WHERE (firstName LIKE @searchTerm OR lastName LIKE @searchTerm) AND {((searchInactive) ? "(status = 0 OR status = 1)" : "status = 1")}";
            return conn.Query<Type>(query, new { searchTerm = $"%{searchTerm}%" }).AsList();
        }

        public static List<Person> SearchPersonsByQueryString(List<Type> types, string filters)
        {
            List<Person> results = new List<Person>();

            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                foreach (Type t in types)
                {
                    switch (t)
                    {
                        case Type type when type == typeof(Customer):
                            results.AddRange(SearchTableByQueryString<Customer>(conn, filters));
                            break;

                        case Type type when type == typeof(Employee):
                            results.AddRange(SearchTableByQueryString<Employee>(conn, filters));
                            break;

                        case Type type when type == typeof(Trainee):
                            results.AddRange(SearchTableByQueryString<Trainee>(conn, filters));
                            break;

                        default:
                            results.AddRange(SearchTableByQueryString<Person>(conn, filters));
                            break;
                    }
                }

                conn.Close();
            }

            return results;
        }

        private static List<Type> SearchTableByQueryString<Type>(SQLiteConnection conn, string queryString) where Type : Person, new()
        {
            string tableName = typeof(Type).Name;
            string query = $"SELECT * FROM {tableName} WHERE{queryString}";
            return conn.Query<Type>(query).AsList();
>>>>>>> 16a515ffcdf9e442d3c0f03eab654c28c433870e
        }
    }
}

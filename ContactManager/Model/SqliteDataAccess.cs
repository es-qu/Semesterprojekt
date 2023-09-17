using ContactManager.Entity;
using ContactManager.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace ContactManager
{
    internal class SqliteDataAccess
    {
        public static int InsertPerson(IDbConnection cnn, Person person)
        {
            string sqlQuery = "INSERT INTO Person (Active, Gender, Salutation, Title, FirstName, LastName, Address, PostalCode, PlaceOfResidence, Nationality, OasiNumber, DateOfBirth, PrivatePhone, BusinessAddress, BusinessPhone, EmailAddress, CommaSeparatedNoteIds) " +
                              "VALUES (@Active, @Gender, @Salutation, @Title, @FirstName, @LastName, @Address, @PostalCode,  @PlaceOfResidence, @Nationality, @OasiNumber, @DateOfBirth, @PrivatePhone,  @BusinessAddress, @BusinessPhone, @EmailAddress, @CommaSeparatedNoteIds)";
            cnn.Execute(sqlQuery, person);
            return cnn.Query<int>("SELECT last_insert_rowid()").Single();
        }

        public static void SaveCustomer(Customer customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                using (var transaction = cnn.BeginTransaction())
                {
                    try
                    {
                        int personId = InsertPerson(cnn, customer);
                        cnn.Execute("INSERT INTO Customer (ID,CompanyName, CustomerType,CompanyContact,CustomerNumber) VALUES (@Id, @CompanyName, @CustomerType,@CompanyContact,@CustomerNumber)",
                            new
                            {
                                Id = personId,
                                customer.CompanyName,
                                customer.CustomerType,
                                customer.CompanyContact,
                                customer.CustomerNumber
                            });

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
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
                cnn.Open();
                using (var transaction = cnn.BeginTransaction())
                {
                    try
                    {
                        var TraineeId = cnn.Query<int>("SELECT ID FROM Employee WHERE EmployeeNumber = @EmployeeNumber", new { EmployeeNumber = trainee.EmployeeNumber }).FirstOrDefault();
                        if (TraineeId == 0)
                        {
                            int lastId = InsertPerson(cnn, trainee);

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
                                "INSERT INTO Trainee (ID, YearsOfApprenticeship, CurrentApprenticeshipYear) VALUES (@Id, @YearsOfApprenticeship, @CurrentApprenticeshipYear)",
                                new
                                {
                                    Id = lastId,
                                    trainee.YearsOfApprenticeship,
                                    trainee.CurrentApprenticeshipYear
                                });
                        }
                        else
                        {
                            // Only insert into Trainee table...
                            cnn.Execute(
                                "INSERT INTO Trainee (ID, YearsOfApprenticeship, CurrentApprenticeshipYear) VALUES (@Id, @YearsOfApprenticeship, @CurrentApprenticeshipYear)",
                                new
                                {
                                    Id = TraineeId,
                                    trainee.YearsOfApprenticeship,
                                    trainee.CurrentApprenticeshipYear
                                });
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
            }
        }



        public static int SaveEmployee(Employee employee)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                int lastId_e = 0;
                cnn.Open();
                using (var transaction = cnn.BeginTransaction())
                {

                    try
                    {
                        lastId_e = InsertPerson(cnn, employee);
                        cnn.Execute("INSERT INTO Employee (ID, Role, Department, DegreeOfEmployment,EmployeeNumber, Dateofjoining, Dateofleaving, CadreLevel) VALUES (@Id, @Role, @Department,@DegreeOfEmployment, @EmployeeNumber, @DateOfJoining, @DateOfLeaving, @CadreLevel)",
                            new
                            {
                                Id = lastId_e,
                                employee.Role,
                                employee.Department,
                                employee.EmployeeNumber,
                                employee.DegreeOfEmployment,
                                employee.DateOfJoining,
                                employee.DateOfLeaving,
                                employee.CadreLevel
                            });

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }

                return lastId_e;
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
            try
            {
                string joinTargetTableName = typeof(Type).Name;

                string query = (typeof(Type) != typeof(Trainee))
                    ? $"SELECT * FROM Person INNER JOIN {joinTargetTableName} ON Person.id = {joinTargetTableName}.id WHERE NOT EXISTS (SELECT 1 FROM Trainee WHERE Trainee.id = {joinTargetTableName}.id) AND {queryString}"
                    : $"SELECT * FROM Person INNER JOIN Employee ON Person.id = Employee.id INNER JOIN {joinTargetTableName} ON Person.id = {joinTargetTableName}.id WHERE {queryString}";


                return conn.Query<Type>(query).AsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Type>();
            }
        }

        /// <summary>
        /// Get a note object
        /// </summary>
        /// <param name="id">ID of the note</param>
        /// <returns>Note object</returns>
        public static Note SearchNote(string id)
        {
            Note note;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    conn.Open();

                    note = (Note)conn.Query<Note>("SELECT * FROM Notes WHERE Id=@Id LIMIT 1", new { Id = id }).FirstOrDefault();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return note;
        }

        /// <summary>
        /// Saves a Note object into database
        /// </summary>
        /// <param name="associatedContact">Person that the note is added to</param>
        /// <param name="note">Note object</param>
        /// <returns>True if successfull, else false</returns>

        public static bool SaveNote(Person associatedContact, Note note)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    // Save note to Notes
                    string sql = "INSERT INTO Notes (Id, Content, CreateTimestamp, EditTimestamp) VALUES (@Id, @Content, @CreateTimestamp, @EditTimestamp)";
                    cnn.Execute(sql, note);

                    if (!string.IsNullOrEmpty(note.Id))
                    {
                        if (string.IsNullOrEmpty(associatedContact.CommaSeparatedNoteIds))
                        {
                            associatedContact.CommaSeparatedNoteIds = note.Id;
                        }
                        else
                        {
                            associatedContact.CommaSeparatedNoteIds += "," + note.Id;
                        }
                    }

                    // Save NoteId in the contact's CommaSeparatedNotes string
                    // --- Update contact

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Delete a note from db according to its ID
        /// </summary>
        /// <param name="associatedContact">Contact that the note is about</param>
        /// <param name="noteId">ID to identify the note</param>
        /// <returns>True if the operation was successful, else false</returns>
        public static bool DeleteNote(Person associatedContact, string noteId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    cnn.Open();
                    // Delete note from Notes table
                    cnn.Execute("DELETE FROM NOTES WHERE Id=@Id", new { Id = noteId });

                    // Delete note from contact's NoteIds
                    associatedContact.NoteIds.Remove(noteId);
                    //Update the Person with the new NoteIds
                    //cnn.Execute("UPDATE Person SET(CommaSeparatedNoteIds) VALUES(@CommaSeparatedNoteIds) WHERE Id=@Id", new { CommaSeparatedNoteIds = associatedContact.CommaSeparatedNoteIds });

                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Updates note informations (only Content may be updated, other informations 
        /// are readonly after creating the instance)
        /// </summary>
        /// <param name="note">Note object with new informations</param>
        /// <returns>True if successful, otherwise false</returns>
        public static bool UpdateNote(Note note)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                using (var transaction = cnn.BeginTransaction())
                {
                    try
                    {
                        cnn.Execute(
                            "UPDATE NOTES SET (Content, EditTimestamp) VALUES (@Content, @EditTimestamp) " +
                            "WHERE Id=@Id",
                            new
                            {
                                Content = note.Content,
                                EditTimestamp = note.EditTimestamp,
                                Id = note.Id
                            });

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}


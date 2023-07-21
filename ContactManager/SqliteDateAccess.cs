using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class SqliteDateAccess
    {
        public static List<Person> LoadPepole(string SearchText)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Person>("Select * from Person where firstName like @Name or lastName like @Name",
     new { Name = "%" + SearchText + "%" });
                return output.ToList();
            }
        }

        public static void SavePerson(Person person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                int lastId = cnn.Query<int>("SELECT IFNULL(MAX(ID), 0) FROM Person").Single();
                person.Id = lastId + 1;
                // Convert dateOfBirth to a string in the format 'yyyy-MM-dd'
                string dateOfBirth = person.dateOfBirth;
                cnn.Execute("INSERT INTO Person(ID, FirstName, LastName, dateOfBirth) values(@Id,@firstName,@lastName,@dateOfBirth)", person);
            }
        }

        internal static object LoadPeople(string text)
        {
            throw new NotImplementedException();
        }

        private static string LoadConnectionString(String id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

﻿using ContactManager.Model;
using System;
using System.Collections.Generic;
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
                gender = int.TryParse(gender, out int genderValue) ? genderValue : 0,
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

        SqliteDateAccess.SaveEmployee(e);

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
                gender = int.TryParse(gender, out int genderValue) ? genderValue : 0,
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

            SqliteDateAccess.SavePerson(t);
            // Show confirmation message
            MessageBox.Show($"Employee {t.firstName} {t.lastName} has been created.", "Confirmation", MessageBoxButtons.OK);
            form.Close();
        }

    
        public static List<Person> SearchContactsByFullText(string searchTerm, bool searchInactive)
        {
            return SqliteDateAccess.SearchPersonsByFullText(searchTerm, searchInactive);
        }

        public static List<Person> SearchContactsByFilters(List<Type> types, List<string> filters)
        {
            string queryString = string.Empty;

            for (int i = 0; i < filters.Count; i++)
            {
                var item = filters[i];

                if (i > 0)
                {
                    queryString += "AND";
                }

                queryString += $" {item} ";
            }

            return SqliteDateAccess.SearchPersonsByQueryString(types, queryString);
        }
    }
}

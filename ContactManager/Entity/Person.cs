using ContactManager.Entity;
using System;
using System.Collections.Generic;

namespace ContactManager
{
    public class Person
    {
        private int active = 1;
        private string title = string.Empty;
        private string gender = string.Empty;
        private string salutation = string.Empty;
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string address = string.Empty;
        private string postalCode = string.Empty;
        private string placeOfResidence = string.Empty;
        private string nationality = string.Empty;
        private string oasiNumber = string.Empty;
        private string dateOfBirth = string.Empty;
        private string emailAddress = string.Empty;
        private string privatePhone = string.Empty;
        private string businessPhone = string.Empty;
        private string businessAddress = string.Empty;
        private List<string> noteIds = new List<string>();
        public List<Note> Notes { get; set; }


        public Person() { }


        public int Active
        {
            get { return active; }
            set { active = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Salutation
        {
            get { return salutation; }
            set { salutation = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public string PlaceOfResidence
        {
            get { return placeOfResidence; }
            set { placeOfResidence = value; }
        }

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public string OasiNumber
        {
            get { return oasiNumber; }
            set { oasiNumber = value; }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public string PrivatePhone
        {
            get { return privatePhone; }
            set { privatePhone = value; }
        }

        public string BusinessPhone
        {
            get { return businessPhone; }
            set { businessPhone = value; }
        }

        public string BusinessAddress
        {
            get { return businessAddress; }
            set { businessAddress = value; }
        }

        // CommaSeparatedNoteIds is used for DB reads/writes, because SQLite can't handle arrays/lists
        //
        // => store NoteIds as comma separated values with getter and split them in
        // the setter for easier handling on the application side
        public string CommaSeparatedNoteIds
        {
            get { return string.Join(",", noteIds); }
            set { noteIds = new List<string>(value.Split(',')); }
        }

        public List<string> NoteIds
        {
            get { return noteIds; }
            set { noteIds = value; }
        }
    }
}

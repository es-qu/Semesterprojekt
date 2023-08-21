namespace ContactManager
{
    /// <summary>
    /// This class is to store states of all inputs in search and advanced search
    /// </summary>

    public class SearchFilters
    {
        // Fields

        // General informations
        private bool inactive = false;
        private bool typeCustomer = true;
        private bool typeEmployee = true;
        private bool typeTrainee = true;

        private string number = string.Empty;
        private string title = string.Empty;
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

        // Customer informations
        private string customerType = string.Empty;
        private string companyName = string.Empty;
        private string companyContact = string.Empty;

        // Employee informations
        private string departement = string.Empty;
        private string role = string.Empty;
        private string cadreLevel = string.Empty;
        private string degreeOfEmployment = string.Empty;
        private string dateOfJoining = string.Empty;
        private string dateOfLeaving = string.Empty;

        // Trainee informations
        private string currentApprenticeshipYear = string.Empty;
        private string yearsOfApprenticeship = string.Empty;


        // Constructor

        public SearchFilters() { }


        // Properties

        // General informations
        public bool Inactive
        {
            get { return inactive; }
            set { inactive = value; }
        }

        public bool TypeCustomer
        {
            get { return typeCustomer; }
            set { typeCustomer = value; }
        }

        public bool TypeEmployee
        {
            get { return typeEmployee; }
            set { typeEmployee = value; }
        }

        public bool TypeTrainee
        {
            get { return typeTrainee; }
            set { typeTrainee = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
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

        // Customer informations
        public string CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string CompanyContact
        {
            get { return companyContact; }
            set { companyContact = value; }
        }

        // Employee informations
        public string Departement
        {
            get { return departement; }
            set { departement = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public string CadreLevel
        {
            get { return cadreLevel; }
            set { cadreLevel = value; }
        }

        public string DegreeOfEmployment
        {
            get { return degreeOfEmployment; }
            set { degreeOfEmployment = value; }
        }

        public string DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }

        public string DateOfLeaving
        {
            get { return dateOfLeaving; }
            set { dateOfLeaving = value; }
        }

        // Trainee informations
        public string CurrentApprenticeshipYear
        {
            get { return currentApprenticeshipYear; }
            set { currentApprenticeshipYear = value; }
        }

        public string YearsOfApprenticeship
        {
            get { return yearsOfApprenticeship; }
            set { yearsOfApprenticeship = value; }
        }

        // Customer informations
        // Employee informations
        // Trainee informations
    }
}

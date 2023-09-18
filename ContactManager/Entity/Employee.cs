namespace ContactManager.Entity
{
    // this is a contact type class and inherits from class person
    public class Employee : Person
    {
        // fields
        private string department = string.Empty;
        private string role = string.Empty;
        private string cadreLevel = string.Empty;
        private string degreeOfEmployment = string.Empty;
        private string dateOfJoining = string.Empty;
        private string dateOfLeaving = string.Empty;
        private string employeeNumber = string.Empty;

        // constructor
        public Employee():base() { }

        // properties
        public string Department
        {
            get { return department; }
            set { department = value; }
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

        public string EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }
    }
}

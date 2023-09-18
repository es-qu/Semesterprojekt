namespace ContactManager.Entity
{
    // this class is used for the log database
    public class LogTable : Person
    {

        // Properties from Employee class
        public string Role { get; set; }
        public string Department { get; set; }
        public string EmployeeNumber { get; set; }
        public string DateOfJoining { get; set; }
        public string DateOfLeaving { get; set; }
        public string CadreLevel { get; set; }
        public string DegreeOfEmployment { get; set; }

        // Properties from Customer class
        public string CompanyName { get; set; }
        public string CustomerType { get; set; }
        public string CompanyContact { get; set; }
        public string CustomerNumber { get; set; }

        // Properties from Trainee class
        public string CurrentApprenticeshipYear { get; set; }
        public string YearsOfApprenticeship { get; set; }

        // Additional properties for logging
        public string EventType { get; set; }

    }
}

namespace ContactManager.Entity
{
    // this is a contact type class and inherits from class Employee
    public class Trainee : Employee
    {
        // fields
        private string currentApprenticeshipYear = string.Empty;
        private string yearsOfApprenticeship = string.Empty;

        // constructor
        public Trainee():base() { }

        // properties
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
    }
}

namespace ContactManager.Model
{
    public class Trainee : Employee
    {
        private string currentApprenticeshipYear = string.Empty;
        private string yearsOfApprenticeship = string.Empty;


        public Trainee():base() { }


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

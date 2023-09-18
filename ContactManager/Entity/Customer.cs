namespace ContactManager.Entity
{
    // this is a contact type class and inherits from class person
    public class Customer : Person
    {
        // fields
        private string companyName = string.Empty;
        private string customerType = string.Empty;
        private string companyContact = string.Empty;
        private string customerNumber = string.Empty;

        // constructor
        public Customer() : base() { }

        // properties
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }

        public string CompanyContact
        {
            get { return companyContact; }
            set { companyContact = value; }
        }

        public string CustomerNumber
        {
            get { return customerNumber; }
            set { customerNumber = value; }
        }
    }
}

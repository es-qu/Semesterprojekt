using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Entity
{
    public class LogTable : Person
    {

        // Properties from Employee class
        public string Position { get; set; }
        public string Department { get; set; }
        public string EmployeeNumber { get; set; }
        public string dateofjoining { get; set; }
        public string dateofleaving { get; set; }
        public string NumCadreLevel { get; set; }

        // Properties from Customer class
        public string CompanyName { get; set; }
        public string CustomerType { get; set; }
        public string CompanyContact { get; set; }
        public string CustomerNumber { get; set; }

        // Properties from Trainee class
        public string TrainingStartDate { get; set; }
        public string TrainingEndDate { get; set; }

        // Additional properties for logging
        public string EventType { get; set; }
        public bool OperationSuccessful { get; set; }
        public bool DeletionSuccessful { get; set; }
    }
}

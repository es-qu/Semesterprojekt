using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    public class Employee : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string EmployeeNumber { get; set; }
        public string dateofjoining { get; set; }
        public string dateofleaving { get; set; }
        public string NumCadreLevel { get; set; }
    }
}

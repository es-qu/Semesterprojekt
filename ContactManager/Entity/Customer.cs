using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Customer : Person
    {
        public string CompanyName { get; set; }
        public string CustomerType { get; set; }
        public string CompanyContact { get;  set; }
        public string CustomerNumber { get; set; }
    }
}

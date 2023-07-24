using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Customer:Person
    {
        public string CompanyName { get; private set; }
        public char CustomerType { get; private set; }
        public string CompanyContact { get; private set; }

        public Customer()
        {

        }
    }
}

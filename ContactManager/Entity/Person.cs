using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public class Person
    {
        public int Id { get; set; }
        public int status { get; set; }
        public int gender { get; set; }
        public string Salutation { get; set; }
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street { get; set; }
        public string postalCode { get; set; }
        public string placeOfResidence { get; set; }
        public string nationality { get; set; }
        public string socialSecurityNumber { get; set; }
        public string dateOfBirth { get; set; }
        public string phoneNumberPrivat { get; set; }
        public string phoneNumberMobile { get; set; }
        public string phoneNumberBusiness { get; set; }
        public string email { get; set; }
        public string note { get; set; }
    }
}

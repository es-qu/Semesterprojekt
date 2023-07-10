using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public class Person : FormMain
    {
        public string Salutation { get; set; }
        string firstName;
        string lastName;
        DateTime dateOfBirth;
        bool gender;
        string title;
        string socialSecurityNumber;
        string phoneNumberPrivat;
        string phoneNumberMobile;
        string phoneNumberBusiness;
        string email;
        bool status;
        string nationality;
        string street;
        string streetNumber;
        int zipCode;
        string place;

        public Person()
        {
            Salutation = TxtSalutation.Text; //haben es in FormMain.Designer.cs auf public gestellt

        }
    }
}

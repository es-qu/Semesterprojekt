using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    public class Trainee : Employee
    {
        public string TrainingStartDate { get; set; }
        public string TrainingEndDate { get; set; }
    }
}

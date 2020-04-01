using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_Fabriory
{
    class Employee
    {

            string Name { get; set; } = "Name";
            string Surname { get; set; }
            int Age { get; set; }
            decimal Salary { get; set; }

            public string ReturnString()
            {
                return Name;
            }
        
    }
}

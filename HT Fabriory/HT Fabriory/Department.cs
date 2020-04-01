using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_Fabriory
{
    class Department
    {
        readonly string Name;
        public Employee[] employees ;
        public Department(string name)
        {
            this.employees = new Employee[10];
            this.Name = name;
        }
        public string ReturnString()
        {
            return this.Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_Fabriory
{
    partial class Factory
    {
        string Name { get; set; }
        Department[] departments = new Department[1];

        partial  void SetAvgSalary();
        partial void SetTotalSalary();
    }
}

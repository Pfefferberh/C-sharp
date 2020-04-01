using System;
using System.Collections.Generic;
using System.Text;

namespace HT_Fabriory
{
    partial class Factory
    {
        int AvgSalary { get; set; }
        int TotalSalary { get; set; }
        Product[] product = new Product[15];
        public string ReturnString()
        {
            return Name;
        }

        partial void SetAvgSalary()
        {
            AvgSalary = 3500;
        }

        partial void SetTotalSalary()
        {
            this.TotalSalary = this.AvgSalary * departments.Length + 1;
        }
    }
}

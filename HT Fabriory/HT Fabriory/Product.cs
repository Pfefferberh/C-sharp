using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HT_Fabriory
{
    class Product
    {
        public string Name { get; set; } = "Product";
        public int Size { get; set; }
        public double Price { get; set; }

        public string ReturnString()
        {
            return Name;
        }
    }
}

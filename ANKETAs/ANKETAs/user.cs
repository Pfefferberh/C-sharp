using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANKETAs
{
    [Serializable]
    public class user
    {
        public string Name { get; set; }
        public string Genger { get; set; }
        public string Hobby { get; set; }
        public bool langvuage { get; set; }
        public DateTime date { get; set; }
        public List<string> Lang { get; set; }
        public override string ToString()
        {
            return $"{Genger} {date} {Lang}";

        }
    }
}

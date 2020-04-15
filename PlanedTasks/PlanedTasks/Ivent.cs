using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlanedTasks
{
    [Serializable]
    public class Ivent
    {
        public string name { get; set; }
        public string place { get; set; }
        public string impot { get; set; }
        public DateTime date { get; set; }
    }
}

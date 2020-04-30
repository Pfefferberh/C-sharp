using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCommand
{
    [Serializable]
    public class Wizard : Unit
    {
        public Wizard()
        {
            this.KindName = "Wizard";
        }
    }
}

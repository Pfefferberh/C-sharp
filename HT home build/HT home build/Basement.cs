using System;
using System.Collections.Generic;
using System.Text;

namespace HT_home_build
{
    class Basement:IParts
    {
        public uint PartsCount { get; set; }

        public Basement(uint PartsCount)
        {
            this.PartsCount = PartsCount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HT_home_build
{
    class Walls:IParts
    {
        public uint PartsCount { get; set; }

        public Walls(uint PartsCount)
        {
            this.PartsCount = PartsCount;
        }
    }
}

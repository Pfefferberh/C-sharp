using System;
using System.Collections.Generic;
using System.Text;

namespace HT_home_build
{
    class Door:IParts
    {
        public uint PartsCount { get; set; }

        public Door(uint PartsCount)
        {
            this.PartsCount = PartsCount;
        }
    }
}

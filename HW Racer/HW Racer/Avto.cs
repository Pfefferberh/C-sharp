using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Racer
{
    abstract class Avto
    {
        protected uint speed=0;
        public int way { get; set; }
        protected string name {  get; set; }
        protected Random troubles {  get; set; }
        protected Random random {  get; set; }
        public int chans {  get; protected set; }
        public int crash {  get; protected set; }
       // public event Action<int> trouble;

        public uint GetSpeed()
        {
            return speed;
        }

        protected void SetSpeed(uint value)
        {
            speed = value;
        }

        public abstract void AddSpeed();
        public abstract void ReSpeed();
        public abstract string Show();
        public abstract bool Chans();
    }
}

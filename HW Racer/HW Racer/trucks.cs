﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Racer
{
    class Trucks : Avto
    {
        public Trucks()
        {
            this.name = "Trucks";
            this.speed = 11;
        }
        public override void AddSpeed()
        {
            this.SetSpeed(this.GetSpeed() + 15);
        }

        public override void ReSpeed()
        {
            if (this.GetSpeed() <= 10)
            {
                this.SetSpeed(1);
            }
            else
            {
                this.SetSpeed(this.GetSpeed() - 10);
            }
        }
        public override string Show()
        {
            return this.name;
        }
        public override bool Chans()
        {
            this.troubles = new Random();
            this.random = new Random();
            this.chans = troubles.Next(1, 41);
            this.crash = random.Next(1, 101);
            if (this.chans <= this.crash && this.GetSpeed() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

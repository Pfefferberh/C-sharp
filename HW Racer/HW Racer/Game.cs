using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Racer
{
    class Game
    {
        Car car;
        SportCar sportCar;
        Trucks trucks;
        Buss buss;
        List<Avto> avto;

        public Game()
        {
            
            Random random = new Random();
            this.avto =new List<Avto>();
            for(uint i = 0; i < 4; i++)
            {
               int index= random.Next(1,5);
                switch (index)
                {
                    case 1:
                        this.car = new Car();
                        this.avto.Add(this.car);
                        break;
                    case 2:
                        this.sportCar = new SportCar();
                        this.avto.Add(this.sportCar);
                        break;
                    case 3:
                        this.trucks = new Trucks();
                        this.avto.Add(this.trucks);
                        break;
                    case 4:
                        this.buss = new Buss();
                        this.avto.Add(this.buss);
                        break;
                }
            }
        }
        public void ShowAll()
        {
            foreach(Avto am in this.avto)
            {
                Console.WriteLine(am.Show());
            }
        }
        public bool play(uint way)
        {
            for(uint hours=0; ; hours++)
            {
                Console.WriteLine($"--------Hour {hours}(h) on the way {way}(km)  -----------------");
                foreach (var am in this.avto)
                {
                    if (am.Chans()) {
                        am.AddSpeed();
                        am.way +=Convert.ToInt32(( am.GetSpeed() * hours));
                        // am.tro += stop;
                        Console.WriteLine($" {am.Show()}:\n Speed {am.GetSpeed()}km/h     Ways {am.way}km");
                    }
                    else
                    {
                       // am.tro += go;
                        am.Show();
                        am.ReSpeed();
                        am.way += Convert.ToInt32((am.GetSpeed() * hours));
                        Console.WriteLine($" {am.Show()}:\n Speed {am.GetSpeed()}km/h     Ways {am.way}km");
                    }
                    if (am.way > way)
                    {
                        Console.WriteLine($"{am.Show()}  Winner!!! Game over\n");
                        return true;
                    }
     
                }
                Console.WriteLine();
            }
            
        }
        // void stop(int avto)
        //{
        //    avto.ReSpeed();
        //}
        //void go(int avto)
        //{
        //    avto.AddSpeed();
        //}

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    class Cop
    {
        public void Calculation_total_amount(List<Stor> list)
        {
            double All_memory = 0;
            foreach (var item in list)
            {
                All_memory += item.Get_Memory();
            }
            Console.WriteLine("\n All memory :  {0}", All_memory);
        }

        public void Calculation_time(double copy_file_size)
        {
            float time_flash = (float)copy_file_size / 190;
            float time_dvd = (float)copy_file_size / (float)2.4;
            float time_hdd = (float)copy_file_size / 120;

            Console.WriteLine("\n Time FLASH :  {0} m", time_flash / 60);
            Console.WriteLine("\n Time DVD   :  {0} m", time_dvd / 60);
            Console.WriteLine("\n Time HDD   :  {0} m", time_hdd / 60);

        }

        public void Calculation(double size_disk, double copy_file_size)
        {
            double counter = copy_file_size / size_disk;
            double tmp = Math.Ceiling(counter);
            Console.WriteLine("\n Counter " + tmp);
        }
    }
}

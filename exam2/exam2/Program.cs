using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            var daynight = Console.ReadLine();
            var bus = 0.09 * km;
            var train = 0.06 * km;
            var taxinight = 0.7 + 0.90 * km;
            var taxiday = 0.7 + 0.79 * km;

            if (km >0 && km <= 5000 && km >=20 && km < 100 && daynight == "day")
            {
                Console.WriteLine(bus);
            }
            else if (km > 0 && km <= 5000 && km >= 20 && km < 100 && daynight == "night")
            {
                Console.WriteLine(bus);
            }

            else if (km > 0 && km <= 5000 && km >= 100 && daynight == "day")
            {
                Console.WriteLine(train);
            }
            else if (km > 0 && km <= 5000 && km >= 100 && daynight == "night")
            {
                Console.WriteLine(train);
            }
            else if (km > 0 && km <= 5000 && km < 20 && daynight == "day")
            {
                Console.WriteLine(taxiday);
            }
            else if (km > 0 && km <= 5000 && km < 20 && daynight == "night")
            {
                Console.WriteLine(taxinight);
            }
            else
            {
                Console.WriteLine("not in 1 ...5000");
            }
        }
    }
}

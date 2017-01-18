using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            nt obuwki = int.Parse(Console.ReadLine());
            int shokoladi = int.Parse(Console.ReadLine());

            if (obuwki < 10)
            {
                Console.WriteLine(":(");
            }
            else if (obuwki >= 10 && obuwki < 20)
            {
                Console.WriteLine(":|");
            }
            else if (obuwki > 20 && obuwki < 30)
            {
                Console.WriteLine(":)");
            }
            else if (obuwki > 30)
            {
                Console.WriteLine(":*");
            }
        }
        }
    }


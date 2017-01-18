using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            
            bool valid = number >= 100 && number <= 200 || number == 0;
            

            if (!valid)
            {
                Console.WriteLine("invalid");
            }
            

        }
    }
}

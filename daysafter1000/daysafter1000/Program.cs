using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysafter1000
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            // getting coeff

            double coeff1 = 1;
            double coeff2 = 1;

            switch (input)
            {
                case "USD": coeff1 = 1.79549; break;
                case "EUR": coeff1 = 1.95583; break;
                case "GBP": coeff1 = 2.53405; break;
                    
                default:
                    break;
            }

            switch (output)
            {
                case "USD": coeff2 = 1.79549; break;
                case "EUR": coeff2 = 1.95583; break;
                case "GBP": coeff2 = 2.53405; break;

                default:
                    break;
            }


            //Formula = amount*coeff1/ coeff2

            Console.WriteLine(Math.Round(amount*coeff1/coeff2 ,2));
        }
    }
}

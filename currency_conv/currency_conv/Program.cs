using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_conv
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            // getting the right coeff
            double coeff1 = 1;
            double coeff2 = 1;

            switch (input)
            {
                case "usd": coeff1 = 1.79549; break;
                case "eur": coeff1 = 1.79549; break;
                case "gbp": coeff1 = 2.53405; break;

                default:
                    break;
            }
            switch (output)
            {
                case "usd": coeff2 = 1.79549; break;
                case "eur": coeff2 = 1.79549; break;
                case "gbp": coeff2 = 2.53405; break;

                default:
                    break;
            }

            // formula = amount * coef1/coef2

            Console.WriteLine(Math.Round(amount*coeff1/coeff2, 2));
        }
    }
}


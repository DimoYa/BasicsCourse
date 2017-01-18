using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {

            var FrVeg = Console.ReadLine();

            bool Fruit = FrVeg == "banana" || FrVeg == "apple" || FrVeg == "kiwi" || FrVeg == "cherry" || FrVeg == "lemon" || FrVeg == "grapes";
            bool Vegetables = FrVeg == "tomato" || FrVeg == "cucumber" || FrVeg == "pepper" || FrVeg == "carrot";

            if (Fruit)
            {
                Console.WriteLine("fruit");
            }
            else if (Vegetables)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}

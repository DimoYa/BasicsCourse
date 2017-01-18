using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var skorost = int.Parse(Console.ReadLine());
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());


            var hours1 = Math.Round((decimal) time1/60,2);
            var hours2 = Math.Round((decimal)time2/60, 2);
            var hours3 = Math.Round((decimal)time3/60, 2);
            double skorost2 = skorost * 1.1;


            double first = hours1 * skorost;
            double second = hours2 * skorost2;
            double third = hours3 * skorost * 1.1;
            
            

            var total = first + second + third;

            Console.WriteLine("{0:0.00}",total);

            //Console.WriteLine(hours1); 

        }
    }
}

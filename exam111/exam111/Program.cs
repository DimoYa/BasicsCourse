using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam111
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = char.Parse(Console.ReadLine());
            var n2 = char.Parse(Console.ReadLine());
            var n3 = char.Parse(Console.ReadLine());
            var broi = 0;

            for (char first = n1; first <= n2; first++)
            {
                for (char second = n1; second <= n2; second++)
                {
                    for (char third = n1; third <= n2; third++)
                    {
                        
                        
                           if (!first.ToString().Contains(n3) && !second.ToString().Contains(n3) && !third.ToString().Contains(n3))
                        {

                            
                            Console.Write("{0}{1}{2} ", first, second, third);
                            broi++;

                        }
                        


                    }
                    
                }
               
            }
            //broi++;
           Console.Write(""+broi);
        }
        
    }
}

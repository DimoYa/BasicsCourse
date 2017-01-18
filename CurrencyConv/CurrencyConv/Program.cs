using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConv
{
    class Program
    {
        static void Main(string[] args)
        {
            // BGN, USD, EUR, GBP

            var USD = 1.79549;
            var EUR = 1.95583;
            var GBR = 2.53405;
            var amount = double.Parse(Console.ReadLine());
            var CurFROM = Console.ReadLine();
            var CurTO = Console.ReadLine();

                        
            //Input BG
            if (CurFROM == "BGN" && CurTO == "USD") Console.WriteLine(Math.Round((amount / USD), 2));
            if(CurFROM == "BGN" && CurTO == "EUR") Console.WriteLine(Math.Round((amount / EUR), 2));
            if(CurFROM == "BGN" && CurTO == "GBR") Console.WriteLine(Math.Round((amount / GBR), 2));

            //Input USD
            if (CurFROM == "USD" && CurTO == "BGN") Console.WriteLine(Math.Round((amount *USD), 2));
            if (CurFROM == "USD" && CurTO == "EUR") Console.WriteLine(Math.Round((amount* USD/EUR), 2));
            if (CurFROM == "USD" && CurTO == "GBR") Console.WriteLine(Math.Round((amount* USD/GBR), 2));

            //Input EUR
            if (CurFROM == "EUR" && CurTO == "BGN") Console.WriteLine(Math.Round((amount * EUR), 2));
            if (CurFROM == "EUR" && CurTO == "USD") Console.WriteLine(Math.Round((amount * EUR /USD), 2));
            if (CurFROM == "EUR" && CurTO == "GBR") Console.WriteLine(Math.Round((amount * EUR /GBR), 2));

            //Input GBR
            if (CurFROM == "GBR" && CurTO == "BGN") Console.WriteLine(Math.Round((amount * GBR), 2));
            if (CurFROM == "GBR" && CurTO == "USD") Console.WriteLine(Math.Round((amount * GBR / USD), 2));
            if (CurFROM == "GBR" && CurTO == "EUR") Console.WriteLine(Math.Round((amount * GBR / EUR), 2));

         }
    }
}

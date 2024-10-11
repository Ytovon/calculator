using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prvniCislo;
            double druheCislo;

            Console.WriteLine("Napište hodnotu prvniho čisla:");
            while (!double.TryParse(Console.ReadLine(), out prvniCislo))

            Console.WriteLine("Napište hodnotu druheho čisla:");
            while (!double.TryParse(Console.ReadLine(), out druheCislo));

            Kalkulacka kalkulacka = new Kalkulacka(prvniCislo, druheCislo);
           


          
            kalkulacka.Vydelit();
        }
    }
}

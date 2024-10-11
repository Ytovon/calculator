using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulacka
{
    internal class Kalkulacka
    {
        public int PrvniCislo { get; }
        public int DruhéCislo { get; }

        public int vysledek { get; set; }

        public Kalkulacka(int prvniCislo, int druheCislo) { 
            this.PrvniCislo = prvniCislo;
            this.DruhéCislo = druheCislo;
        }

        public void Secti()
        {
            this.vysledek = this.PrvniCislo + this.DruhéCislo;
        }


    }
}

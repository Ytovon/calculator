using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulacka
{
    internal class Kalkulacka
    {
        public double PrvniCislo { get; }
        public double DruhéCislo { get; }

        public double vysledek { get; private set; }

        public Kalkulacka(int prvniCislo, int druheCislo) { 
            this.PrvniCislo = prvniCislo;
            this.DruhéCislo = druheCislo;
        }

        public void Secti()
        {
            this.vysledek = this.PrvniCislo + this.DruhéCislo;
            VypisVysledek();
        }

        public void Odecti()
        {
            this.vysledek = this.PrvniCislo - this.DruhéCislo;
            VypisVysledek();
        }
        public void Vynasobit()
        {
            this.vysledek = this.PrvniCislo * this.DruhéCislo;
            VypisVysledek();
        }

        public void Vydelit()
        {
            this.vysledek = this.PrvniCislo / this.DruhéCislo;
            VypisVysledek();
        }

        private void VypisVysledek()
        {
            Console.WriteLine("Vysledek: " + this.vysledek);
        }


    }
}

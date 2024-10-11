using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulacka
{
    internal class Kalkulacka
    {
        private double prvniCislo;
        private double druhéCislo;

        public double vysledek { get; private set; }

        public double PrvniCislo
        {
            get
            {
                return prvniCislo;
            }
            set
            {
                if (value < double.MaxValue && value > double.MinValue)
                {
                    prvniCislo = value;
                }                
            }
        }
        public double DruhéCislo
        {
            get
            {
                return druhéCislo;
            }
            set
            {
                if (value < double.MaxValue && value > double.MinValue)
                {
                    druhéCislo = value;
                }
            }
        }

        public Kalkulacka(double prvniCislo, double druheCislo) { 
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

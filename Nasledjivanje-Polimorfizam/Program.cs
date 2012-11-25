using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledivanje_Polimorfizam
{
    class Racun
    {
        protected double stanje;
        public double primanja{get; set;}
        public virtual void Uplati(double a) 
            { stanje += a; }
    }

    class TekuciRacun : Racun
    {
        public override void Uplati(double dodatak)
        {
            double provizija = 0.05;
            stanje = stanje + dodatak - dodatak * primanja;
        }
    }

    class ZiroRacun : Racun
    {
        public override void Uplati(double dodatak)
        {
            double provizija = 0.6;
            stanje = stanje + dodatak - dodatak * primanja;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

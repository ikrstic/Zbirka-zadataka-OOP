using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje_Polimorfizam_Zadatak5Aparat
{
    public class Aparat
    {
        protected bool Ukljucen { get; set; }
        public void Ukljuci()
        {
            Ukljucen = true;
        }
        public void Iskljuci()
        {
            Ukljucen = false;
        }
        public Aparat(bool ukljucen)
        {
            Ukljucen = ukljucen;
        }
        public virtual void Ispisi()
        {
            if (Ukljucen) Console.WriteLine("Aparat je ukljucen");
            else Console.WriteLine("Aparat je iskljucen");
        }
    }

    public class Televizor : Aparat
    {
        private int program;
        public Televizor(bool ukljucen, int p):base(ukljucen)
        {
            if ((p < 1) || (p > 40))
            {
                program = 1;
            }
            else program = p;
        }

        public void PromeniProgramNavise()
        {
            if (program < 40) program++;
            else program = 1;
        }

        public void PromeniProgramNanize()
        {
            if (program > 1) program--;
            else program = 40;
        }

        public override void Ispisi()
        {
            base.Ispisi();//base je instanca bazne klase Aparat; poziva se njena metoda
            Console.WriteLine("Trenutno je pusten " +program+". program");
        }
    }

    public class Radio : Aparat
    {
        double frekvencija;
        public Radio (bool ukljucen, double f):base(ukljucen)
        {
            frekvencija = f;
        }
        new public void Ispisi()
        {
            base.Ispisi();//base je instanca bazne klase Aparat; poziva se njena metoda Aparat je ukljucen ili iskljucen
            Console.WriteLine("Frekvencija je " + frekvencija + " Mhz");
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Aparat k = new Aparat(false);
            k.Ukljuci();
            k.Ispisi();

            Televizor t = new Televizor(true, 33);
            t.Iskljuci();
            t.PromeniProgramNavise();
            t.Ispisi();

            Radio r = new Radio(false, 99.5);
            r.Ukljuci();
            r.Ispisi();

            Console.ReadKey();
        }
    }
}

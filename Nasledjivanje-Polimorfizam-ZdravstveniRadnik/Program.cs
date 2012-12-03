using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje_Polimorfizam_ZdravstveniRadnik
{
    class ZdravstveniRadnik
    {
        public string Ime;
        public string Prezime;
        protected double Plata;
        public int brojSati;

        public ZdravstveniRadnik(string ime, string prezime)
        {
            Ime=ime;
            Prezime=prezime;
        }
    
        public virtual double IzracunajPlatu(int brojSati)
        {
            return Plata=50*brojSati;   
        }

        public virtual void IspisiPodatke()
        {
            Console.WriteLine("Zaposleni: " + Ime + " " + Prezime);
            Console.WriteLine("Plata: " + Plata);
        }
    }

    class MedicinskaSestra : ZdravstveniRadnik
    {
        //private int brojSati;
        public MedicinskaSestra(string ime,string prezime):base(ime,prezime)
        {
            Ime = ime;
            Prezime = prezime;
            //if (brojSati >= 0) brojSati = brojsati;
        }

        public override double IzracunajPlatu(int brojSati)
        {
            return Plata=100*brojSati;
        }
    }

    class Doktor : ZdravstveniRadnik
    {
        //private int brojSati;
        public int brojOperacija = 0;

        public Doktor(string ime, string prezime, int brojoperacija):base(ime,prezime)
        {
            Ime = ime;
            Prezime = prezime;
            //if (brojSati >= 0) brojSati=brojsati;
            if (brojOperacija >= 0) brojOperacija = brojoperacija;
        }
        public override double IzracunajPlatu(int brojSati)
        {
            return Plata=1000*brojSati;
        }

        public override void IspisiPodatke()
        {
            Console.WriteLine("Zaposleni: " + Ime + " " + Prezime + " " + brojOperacija + ". operacija");
            Console.WriteLine("Plata: " + Plata);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MedicinskaSestra sestra1 = new MedicinskaSestra("Milica", "Milić");
            sestra1.IspisiPodatke();
            sestra1.IzracunajPlatu(200);

            Doktor doktor1 = new Doktor("Petar", "Petrović", 20);
            doktor1.IspisiPodatke();
            doktor1.IzracunajPlatu(250);
            Console.ReadKey();
        }
    }
}

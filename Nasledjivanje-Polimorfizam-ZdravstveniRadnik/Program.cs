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
    
        public virtual double IzracunajPlatu()
        {
            return Plata=50*brojSati;   
        }

        public virtual void IspisiPodatke()
        {
            Console.WriteLine("Zaposleni: " + Ime + " " + Prezime);
        }
    }

    class MedicinskaSestra : ZdravstveniRadnik
    {
        //private int brojSati;
        public MedicinskaSestra(string ime,string prezime):base(ime,prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public override double IzracunajPlatu()
        {
            return Plata=100*brojSati;
        }
    }

    class Doktor : ZdravstveniRadnik
    {
        //private int brojSati;
        private int brojOperacija { get; set; }

        public Doktor(string ime, string prezime, int brojoperacija):base(ime,prezime)
        {
            Ime = ime;
            Prezime = prezime;
            brojOperacija = 0;
            if (brojOperacija > 0) brojOperacija = brojoperacija;
        }
        public override double IzracunajPlatu()
        {
            return Plata=1000*brojSati;
        }

        public override void IspisiPodatke()
        {
            Console.WriteLine("Zaposleni: " + Ime + " " + Prezime + " " + brojOperacija + ". operacija");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MedicinskaSestra sestra1 = new MedicinskaSestra("Milica", "Milić");
            sestra1.IspisiPodatke();
            Doktor doktor1 = new Doktor("Petar", "Petrović", 20);
            doktor1.IspisiPodatke();
            Console.ReadKey();
        }
    }
}

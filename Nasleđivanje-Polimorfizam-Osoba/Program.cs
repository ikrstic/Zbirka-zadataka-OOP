using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasleđivanje_Polimorfizam_Osoba
{
    class Osoba
    {
        public string Ime = "n";
        public string Prezime = "n";
        public string Jmbg = "123";

        public Osoba (string ime, string prezime, string jmbg)
        {
            if (ime != null) Ime = ime;
            if (prezime != null) Prezime = prezime;
            if (jmbg != null) Jmbg = jmbg;
        }
        public virtual void Ispisi()
        {
            Console.WriteLine("Osoba: " + Ime + " " + Prezime + " JMBG: " + Jmbg + " ");
        }
    }

    class Djak : Osoba
    {//Svojstvo Stipendija
        public double Stipendija { get; set; }

      //parametrizovani konstruktor
        public Djak(string ime, string prezime, string jmbg, double stipendija) : base(ime,prezime,jmbg)
        {
            if(stipendija>1000 && stipendija<16000) Stipendija = stipendija;
        }
      //redfinisana metoda
        public override void Ispisi()
        {
            Console.WriteLine("Djak: " + Ime + " " + Prezime + " JMBG: " + Jmbg + " Stipendija: " + Stipendija + "din");
        }
    }

    class Penzioner : Osoba
    {//svojstvo Penzija
        public double Penzija { get; set; }

      //parametrizovani konstruktor
        public Penzioner(string ime, string prezime, string jmbg, double penzija) : base(ime,prezime,jmbg)
        {
            if (penzija > 0) Penzija = penzija;
        }

      //redfinisana metoda
        public override void Ispisi()
        {
            Console.WriteLine("Penzioner: " + Ime + " " + Prezime + " JMBG:" + Jmbg + " Penzija: " + Penzija + "din");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Pera", "Perić", "0808988100200");
            o.Ispisi();

            Djak dj = new Djak("Mika", "Mikić", "0707997100200", 17000.00);
            dj.Ispisi();

            Penzioner p = new Penzioner("Laza","Lazić","0505945100200",23400.00);
            p.Ispisi();

            Console.ReadKey();
        }
    }
}

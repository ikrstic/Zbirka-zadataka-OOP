using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasleđivanje_Polimorfizam_Zaposleni
{
    public class Zaposleni
    {
        public string ime;
      //Osnovica je definisana kao protected tako da joj se može pristupiti samo iz ove i izvedenih klasa
        protected decimal osnovica;
      //Konstruktor postavlja vrednosti za ime i osnovicu
        public Zaposleni (string ime, decimal osnovica)
        {
            this. ime = ime;
            this. osnovica = osnovica;
        }
      //Metoda koa može biti predefinisana
        public virtual decimal IzračunajPlatu()
        {
            return osnovica;
        }
    }
  //Izvedena klasa
    public class Prodavac : Zaposleni
    {
      //polje koje utice na osnovicu
        private decimal bonus;
      //inicijalizuje bonus
        public Prodavac (string ime, decimal osnovica, decimal bonus) : base(ime, osnovica)
        {
            this.bonus = bonus;
        }
      //Override-uje metodu kako bi se izračunao bonus
        public override decimal IzračunajPlatu()
        {
            return osnovica + bonus;
        }
    }
    
    class Test
    {
        static void Main()
        {
          //kreiramo zaposlenog
            Prodavac prodavac1 = new Prodavac("Marko", 1000, 500);
            Zaposleni zaposleni1 = new Zaposleni("Pera", 1200);
            Console.WriteLine("Prodavac " + prodavac1.ime + " je zaradio: " + prodavac1.IzračunajPlatu());
            Console.WriteLine("Zaposleni " + zaposleni1.ime + " je zaradio: " + zaposleni1.IzračunajPlatu());
            Console.ReadKey();
        }
    }
}

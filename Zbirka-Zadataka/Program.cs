using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbirka_Zadataka
{
    class Kupac
    {
        public double p1;
        public string p2;
        public int p3;

        public Kupac(double p1, string p2, int p3)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        /*
        public double UkupnaKupovina {get; set;}
        public string Ime {get; set;}
        public int IdKupac {get; set;}*/

        //Dodatne metode, događaji
      /*  public Customer(double kupovina, string ime, int ID)
            {
                UkupnaKupovina = kupovina;
                Ime = ime;
                IdKupac = ID;
            }
            public string GetContactInfo() {return "ContactInfo";}
            public string GetTransactionHistory() {return "History";}*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Inicijalizacija novog objekta
            Kupac cust1 = new Kupac(4987.63, "Pera Perić",90108);

            //Izmena svojstva
            //cust1.p1 += 499.99;
            Console.WriteLine("Dodajte iznos na kupovinu");
            cust1.p1 += Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ukupan iznos kupovne {0}",cust1.p1);
            Console.ReadKey();
        }
    }
}

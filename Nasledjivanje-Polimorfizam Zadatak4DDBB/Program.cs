using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledivanje_Polimorfizam_Zadatak4DDBB
{
    public class A
    {
        public virtual void Ispis()
        { Console.WriteLine("A"); }
    }

    public class B : A
    {
        public override void Ispis()
        { Console.WriteLine("B");}
    }

    public class C : B
    {
        new public virtual void Ispis()
        { Console.WriteLine("C");}
    }

    public class D : C
    {
        public override void Ispis()
        { Console.WriteLine("D");}
    }

    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            C c = d;
            B b = c;
            A a = b;

            d.Ispis();
            c.Ispis();
            b.Ispis();
            a.Ispis();

            Console.ReadKey();
        }
    }
}

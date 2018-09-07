using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] a = new IDbFunktioner[4];
            a[0] = new Hund { Navn = "Niels" };
            a[1] = new Ubåd { Nummer = 1, Tubine = 2 };
            a[2] = new Hund { Navn = "HundSød" };
            a[3] = new Ubåd { Nummer = 3, Tubine = 4 };

            foreach (var item in a)
            {
                item.Gem();
            }

            Console.ReadKey();
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }

    class Hund:IDbFunktioner
    {

        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund..");
        }
    }

    class Ubåd:IDbFunktioner
    {

        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd..");
        }
    }
}

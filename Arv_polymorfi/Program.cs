using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund { Navn = "Henning" };
            Kat k = new Kat { Navn = "Kathrine" };

            h.SigNoget();
            k.SigNoget();


            for (int i = 0; i < 20; i++)
            {
                Dyr.TilfældigtDyr().SigNoget();
            }



            Console.ReadKey();

        }
    }

    abstract class Dyr
    {
        static Random rnd = new Random();
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dy og heder " + Navn);
        }

        public static Dyr TilfældigtDyr()
        {
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);

            int i = rnd.Next(0, navne.Length);

            if (i % 2 == 0)
                return new Hund { Navn = navne[i] };
            else
                return new Kat { Navn = navne[i] };

        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg eren hund og hedder " + Navn);
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + Navn);
        }
    }
}

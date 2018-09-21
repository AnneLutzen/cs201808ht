using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;

namespace Anonyme_objekter
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic a = new { navn = "a", alder = 10 };

            Console.WriteLine(@"Person hedder " + a.navn + " og er " + a.alder + " år gammel.");


            SkrivPerson(a);

            dynamic o = new ExpandoObject();
            o.navn = "b";
            o.alder = 20;

            Console.WriteLine(@"Person hedder " + o.navn + " og er " + o.alder + " år gammel.");

            SkrivPerson(o);

            // Keep console open when debugging
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static void SkrivPerson(dynamic a)
        {
            Console.WriteLine(@"Person hedder " + a.navn + " og er " + a.alder + " år gammel.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Fornavn = "Bjarke", Efternavn = "Nielsen" };

            Console.WriteLine(p.FuldtNavn());



            Elev e = new Elev { Fornavn = "Anne", Efternavn = "Lützen", Klasselokale = "Pas.." };

            Instruktør i = new Instruktør { Fornavn = "Marianne", Efternavn = "Kjeldberg", NøgleId = 123 };

            Console.WriteLine(e.FuldtNavn());

            Console.WriteLine(i.FuldtNavn());


            Console.ReadKey();


        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}

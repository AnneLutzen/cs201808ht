using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOpgave
{
      class Program
    {
        static void Main(string[] args)
        {
            FilTyper ft = FilTyper.cvs;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);


            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            Console.ReadKey();
        }
    }

    struct Person
    {
        public int Id;
        public string Navn;
    }

    public enum FilTyper
    {
        cvs = 1,
        pdf = 2,
        txt = 3
    }
}

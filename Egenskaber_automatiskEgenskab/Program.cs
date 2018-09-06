using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber_automatiskEgenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Anne";
            p.Efternavn = "Lützen";

            Console.WriteLine(p.FuldtNavn());

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        private string _efternavn;

        public string Efternavn
        {
            get { return _efternavn; }
            set
            {
                if (value.Length < 3)
                    _efternavn = value;
                else
                    _efternavn = "";
            }
        }
        public string FuldtNavn()
        {
          return  Fornavn + " " + Efternavn;
        }
    }
}

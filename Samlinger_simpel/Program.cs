using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();
            var p1 = new Person();
            p1.Navn = "Marianne";

            var p2 = new Person();
            p2.Navn = "Bjarke";

            var p3 = new Person();
            p3.Navn = "Anne";


            listPerson.Add(p1);
            listPerson.Add(p2);
            listPerson.Add(p3);

            foreach (var item in listPerson)
            {
                Console.WriteLine(item.Navn);
            }




            Dictionary<int, Person> dicPerson = new Dictionary<int, Person>();
            dicPerson.Add(1, p1);
            dicPerson.Add(2, p2);
            dicPerson.Add(3, p3);

            for (int i = 1; i <= dicPerson.Count; i++)
            {
                Console.WriteLine(dicPerson[i].Navn);
            }

            Console.ReadKey();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}

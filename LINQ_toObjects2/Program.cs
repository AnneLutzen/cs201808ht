using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_toObjects2
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people1 = r.GetPeople(10).OrderBy(i => i.Name);
            foreach (var person in people1)
                Console.WriteLine(person.Name);

            var people2 = r.GetPeople(10).OrderBy(i => i.Gender).ThenBy(i => i.Name);
            foreach (var person in people2)
                Console.WriteLine(person.Name);

            var people3 = r.GetPeople(10).OrderBy(i => i.Gender).ThenBy(i => i.Name);
            foreach (var person in people3)
                Console.WriteLine(person.Name + " " + person.Gender);

            var people4 = r.GetPeople(10).Where(i => i.Height <170);
            foreach (var person in people4)
                Console.WriteLine(person.Name + " " + person.Height);

            var people5 = r.GetPeople(10).Where(i => i.Height < 170 && i.IsHealthy);
            foreach (var person in people5)
                Console.WriteLine(person.Name + " " + person.Height + " " + person.IsHealthy);

            var people6 = r.GetPeople(10).GroupBy(i => i.Gender);
            foreach (var group in people6)
            {
                Console.WriteLine(group.Key);
                foreach (var person in group)
                    Console.WriteLine("  => " + person.Name + " " + person.Gender);

                Console.WriteLine();
               
            }

            var people7 = r.GetPeople(10).OrderBy(i => i.Name).Select(i => new { Name = i.Name, Height = i.Height });
            foreach (var person in people7)
            {
                Console.WriteLine(person.Name + " " + person.Height);
            }

            Console.WriteLine();
            int[] range = { 160, 170, 180, 190, 200, 210, 220 };
            var res7 = r.GetPeople(10).OrderBy(i => i.Height).GroupBy(i => range.FirstOrDefault(x => x > i.Height));
            foreach (var group in res7)
            {
                Console.WriteLine(group.Key);
                foreach (var person in group)
                {
                    Console.WriteLine("  => " + person.Name + " " + person.Height);
                }
            }
        }
    }
}

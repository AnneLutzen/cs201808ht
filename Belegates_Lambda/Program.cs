using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belegates_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            int i = a.FindIndex(FindVærdi);
            Console.WriteLine(i);

            int j = a.FindIndex(g => g == 51);
            Console.WriteLine(j);

            a.ForEach(g => Console.WriteLine(g));

            a.ForEach(ListVærdi);


        }

        public static bool FindVærdi(int a)
        {
            return a == 51;
        }

        public static void ListVærdi(int a)
        {
            Console.WriteLine(a);
        }
    }
}

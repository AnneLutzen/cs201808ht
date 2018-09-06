using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_Statisk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beregninger hej = new Beregninger();

            int tal1;
            tal1 = Beregninger.LægSammen(1, 2);

            int tal2;
            tal2 = Beregninger.TrækFra(1, 2);

            Console.WriteLine(tal1);
            Console.WriteLine(tal2);

            Console.ReadKey();
        }
    }

    static class Beregninger
    {
        public static int LægSammen(int a, int b)
        {
            return a + b;
        }

        public static int TrækFra(int a, int b)
        {
            return a - b;
        }
    }
}

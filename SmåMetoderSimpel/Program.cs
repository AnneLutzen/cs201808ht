using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmåMetoderSimpel
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res);
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);
            Udskriv("Dette er en test!");

            Console.ReadKey();
        }

        public static int LægSammen(int a, int b)
        {
            return a + b;
        }

        public static  double BeregnAreal(int radius)
        {
            return radius * radius * Math.PI;
        }

        public static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}

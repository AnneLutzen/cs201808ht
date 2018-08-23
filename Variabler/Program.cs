using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int _nummer;
            int Nummer;
            int nummer;
            int AntalMånederPrÅr;

            //
            int antalMaanederPrAar = 0;
            //antalMaanederPrAar = 0;
            antalMaanederPrAar = antalMaanederPrAar + 1;

            int a = 1, b = 2, c = 3;

            System.Int32 a1 = 1;
            int a2 = 1;

            //byte w = 300;

            Console.WriteLine(a1);
            Console.WriteLine("a1 = " + a1);
            Console.WriteLine($"a1 = {a1}");


            int y = 10;

            // instans medlem
            Console.WriteLine(y.ToString());
            // statisk medlem
            Console.WriteLine(int.MaxValue);

            float q = 232.3F;

            int u = 10;
            u = u - 1;
            u = u + 1;
            u = 10;
            int res = u % 2;
            Console.WriteLine(res);

            u += 5;

            double tal = 23456678.4678;
            Console.WriteLine(tal);
            Console.WriteLine(tal.ToString());
            Console.WriteLine(tal.ToString("N2"));
            Console.WriteLine(tal.ToString("N5"));
            Console.WriteLine(tal.ToString("F2"));

            System.Boolean b1 = true;
            






            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            int sum = 0;

            for (int i= 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
                Console.WriteLine(månedsløn[i]);
            }

            double gennemsnit = sum / månedsløn.Length;
            Console.WriteLine("Gennemsnit " + gennemsnit.ToString("N2"));

            Console.ReadKey();
        }
    }
}

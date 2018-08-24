using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatoOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            DateTime d2;
            d2 = new DateTime(2018, 06, 21, 03, 00, 00);
            DateTime d3;
            d3 = new DateTime(2020, 12, 24, 08, 09, 02);
            Console.WriteLine(d3.Subtract(d2).TotalDays);

            TimeSpan t2;
            t2 = new TimeSpan(16, 00, 00);
            Console.WriteLine(t2);

            TimeSpan t3;
            t3 = new TimeSpan(00, 30, 00);
            Console.WriteLine(t3);

            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine(t4);

            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine(t5);


            Console.ReadKey();
        }
    }
}

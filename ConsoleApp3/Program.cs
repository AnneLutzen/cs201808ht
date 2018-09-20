using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public delegate void voidString(string t);
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*");
            //voidString f1 = new voidString(Console.WriteLine);
            //f1.Invoke("*");

            voidString f1 = Console.WriteLine;
            f1 += MinSkriv;
            f1("*");

            f1 -= MinSkriv;
            f1 -= Console.WriteLine;


        }

        static void MinSkriv(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}

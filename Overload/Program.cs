using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1,2));
            Console.WriteLine(Beregn(1,2,3));
            Console.WriteLine(Beregn(1,2,4,5));

            Console.ReadKey();
        }

        static int Beregn (int tal1, int tal2)
        {
            return tal1 + tal2;
        }

        static int Beregn(int tal1, int tal2, int tal3)
        {
            return Beregn(tal1, tal2) + tal3;
        }

        static int Beregn(int tal1, int tal2, int tal3, int tal4)
        {
            return Beregn(tal1, tal2, tal3) + tal4;
        }

        //static int Beregn(int tal1, int tal2, int tal3)
        //{
        //    return tal1 + tal2 + tal3;
        //}

        //static int Beregn(int tal1, int tal2, int tal3,int tal4)
        //{
        //    return tal1 + tal2 + tal3 + tal4;
        //}
    }
}

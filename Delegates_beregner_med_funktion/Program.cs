using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Beregner
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> s = Plus;

            int res = Beregner(1, 1, s); // lægger sammen
            Console.WriteLine(res);

            int res1 = Beregner(1, 1, Plus); // lægger sammen
            Console.WriteLine(res1);

            Func<int, int, int> s1 = Divider;

            int res2 = Beregner(4, 2, s1);    // trækker fra
            Console.WriteLine(res2);


            var f = FindTilfældigFunktion();
            int res4 = f(5, 5);
            Console.WriteLine(res4);

        }

        public static int Plus(int a, int b) => a + b;
        public static int Minus(int a, int b) => a - b;

        public static int Divider(int a, int b) => a / b;

        public static int Gange(int a, int b) => a * b;

        public static int Beregner(int a, int b, Func<int, int, int> funktion) => funktion(a, b);

        public static Func<int, int, int> FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;

            return Divider;
        }

    }


}

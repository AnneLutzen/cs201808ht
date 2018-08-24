using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            p.TællerTil(1, 10);
            //TællerTil(1, 10);
            Console.ReadKey();

        }

        //static void TællerTil(int start, int stop)
        void TællerTil(int start, int stop)
        {
            Console.WriteLine(start);
            if (start == stop)
                return;
            start++;
            TællerTil(start, stop);
        }
    }
}

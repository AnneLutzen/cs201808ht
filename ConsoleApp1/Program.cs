using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_udvidSystemRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool()); // true eller false

            Console.ReadKey();
        }
    }

    public class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            if (Next(1, 1002) <= 500)
            {
                return true;
            }
            else
                return false;
        }
    }
}

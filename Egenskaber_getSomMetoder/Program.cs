using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber_getSomMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(1,2);

            Console.WriteLine(t.Areal());

            Console.ReadKey();

        }
    }
    class Trekant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }
      
        public Trekant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }

        public double Areal()
        {
            return Grundlinje * Højde * 0.5;
        }


    }
}

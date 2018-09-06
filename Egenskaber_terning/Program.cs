using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber_terning
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set {
                if (value > 0 || value < 7)
                    værdi = value;
                else
                    værdi = 1;
            }
        }

    }
}

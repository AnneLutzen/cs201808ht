using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

             Console.ReadKey();
        }
    }

    class Terning
    {
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();

        public void Skriv()
        {
            Console.WriteLine(værdi);
        }
        /// <summary>
        /// sætter værdi til en tilfældig værdi mellem 1-6.  Dette skal dog kun ske hvis snyd = false. Hvis snyd = true så skal værdi sættes til 6.
        /// </summary>
        public void Ryst()
        {
            if (!snyd)
                værdi = rnd.Next(1, 7);
            else
                værdi = 6;
        }

        /// <summary>
        /// default constructor der sætte værdi til 1 og snyd til false
        /// </summary>
        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }
        /// <summary>
        /// custom constructor med en bool argument, der sætter værdi til en 1 og snyd til den givne værdi
        /// </summary>
        /// <param name="snyd"></param>
        public Terning (bool snyd) 
        {
            this.værdi = 1;
            this.snyd = snyd;
        }
    }
}

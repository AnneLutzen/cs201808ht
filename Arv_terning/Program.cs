using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            LudoTerning lt = new LudoTerning();
            Terning t = new Terning();

            for (int i = 0; i < 40; i++)
            {
                lt.Ryst();
                lt.Skriv();

                //t.Ryst();
                //t.Skriv();
            }



            Console.ReadKey();
        }
    }
    public class Terning
    {
        private static System.Random rnd;
        private int værdi;

        public int Værdi
        {
            get
            {
                //Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                //Console.WriteLine("Terning tildeles " + value);
                this.værdi = value;
            }
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public Terning()
        {
            this.Ryst();
        }
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
        static Terning()
        {
            rnd = new Random();
        }
    }

    public class LudoTerning : Terning
    {

        public bool ErGlobus()
        {
            return Værdi==3;
        }

        public bool ErStjerne()
        {
            return Værdi == 5;
        }

        public LudoTerning() : base()
        { }

        public LudoTerning(int værdi) : base(værdi)
        { }

        public override void Skriv()
        {
            if (ErGlobus())
                Console.WriteLine("[G]");
            else if (ErStjerne())
                Console.WriteLine("[S]");
            else
                Console.WriteLine("[" + this.Værdi + "]");
        }
    }
}

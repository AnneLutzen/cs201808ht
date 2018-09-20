using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_KreditMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() {Navn = "Bjarke", KreditMax = -500 };
            k.KreditOverskredet += (s, e) => {Console.WriteLine("Kredit overskredet");};
            k.Køb(100);
            k.Køb(600);
        }
    }

    public class Kunde
    {
        public EventHandler KreditOverskredet;
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                if(KreditOverskredet != null)
                  KreditOverskredet(this, new EventArgs());
            }
        }
    }
}

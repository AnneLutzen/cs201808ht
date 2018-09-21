using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOFile_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = Directory.Exists(@"C:\temp");
            Console.WriteLine(b);

            if (b)
            {
                var alleFiler = Directory.GetFiles(@"C:\temp");
                foreach (string fil in alleFiler)
                {
                    Console.WriteLine(fil);
                }
            }

            bool b2 = File.Exists(@"C:\Temt\Data.txt");
            Console.WriteLine(b2);

            try
            {
                File.WriteAllText(@"C:\Temt\Data.txt", "xxx");
                File.AppendAllText(@"C:\Temt\Data.txt", "yyy");
                var s = File.ReadAllText(@"C:\Temt\Data.txt");
                Console.WriteLine(s);
                File.Delete(@"C:\Temt\Data.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Virker ikke");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Changed += (s, e) => Console.WriteLine("Filen " + e.FullPath + " er rettet.");
            do { } while (true);


        }
    }
}

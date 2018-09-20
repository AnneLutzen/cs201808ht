using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace interface_using
{
    class Program : IDisposable
    {
        static void Main(string[] args)
        {
            using (StreamReader stream = System.IO.File.OpenText(@"X:\dyrenavne.txt"))
            while (stream.Peek() != -1)
            {
                string navn = stream.ReadLine();
                Console.WriteLine(navn);
            }
        }

        

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

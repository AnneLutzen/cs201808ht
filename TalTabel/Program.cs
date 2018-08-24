using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalTabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    int k = i * j;
                    if (k<54)
                        Console.ForegroundColor = ConsoleColor.White;
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;
                   Console.Write(k.ToString().PadLeft(5));

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}

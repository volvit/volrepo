using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor prevColor = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();

        }
    }
}

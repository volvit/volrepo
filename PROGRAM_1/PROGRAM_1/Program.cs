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
            Console.SetBufferSize(100,50);

            Horisontal line = new Horisontal(5, 10, 8, '*');
            line.Drow();

            Console.ReadLine();
        }
    }
}

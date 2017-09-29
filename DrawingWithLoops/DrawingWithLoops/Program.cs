using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var x = 1; x <= 10; x++)
            {
                Console.WriteLine(new string('*', 10));
            }

        }
    }
}

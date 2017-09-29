using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (var start = 1; start <= n - 2; start++)
                Console.Write("- ");
            Console.WriteLine("+");

            for (var x = 1; x <= n - 2; x++)
            {
                Console.Write("|");

                for (var y = 1; y <= n - 2; y++)
                    Console.Write(" -");


                Console.WriteLine(" |");

            }

            Console.Write("+ ");
            for (var end = 1; end <= n - 2; end++)
                Console.Write("- ");
            Console.WriteLine("+");


        }
    }
}

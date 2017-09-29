using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var x = 1; x <= n; x++)
            {
                Console.Write("*");
                for (var y = 1; y < n; y++)
                    Console.Write(" *");
                Console.WriteLine();
            }


        }
    }
}

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
            var N = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', N));
            for (int x = 1; x <= N - 2; x++)
            {
                Console.WriteLine('*' + new string(' ', N - 2) + '*');

            }
            Console.WriteLine(new string('*', N));
        }
    }
}

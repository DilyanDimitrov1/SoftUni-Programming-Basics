using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (var x = 0; x <= n; x += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }

        }
    }
}

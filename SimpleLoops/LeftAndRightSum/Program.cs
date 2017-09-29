using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = 0;
            var b = 0;
            for (var x = 0; x < n; x++)
            {
                {
                    var num = int.Parse(Console.ReadLine());
                    a = num + a;
                }
            }
            for (var x = 0; x < n; x++)
            {
                var num1 = int.Parse(Console.ReadLine());
                b = num1 + b;
            }
            var c = Math.Abs(a - b);
            if (a == b)
            {
                Console.WriteLine($"Yes,sum = {a}");
            }
            else
            {
                Console.WriteLine($"No diff, {c}");
            }

        }
    }
}

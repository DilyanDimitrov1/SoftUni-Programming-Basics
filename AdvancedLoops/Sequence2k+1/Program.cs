using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (var x = 1; x <= n; x++)
            {
                Console.WriteLine(num);
                num = (num * 2) + 1;
                if (num > n)
                {
                    break;
                }
            }

        }
    }
}

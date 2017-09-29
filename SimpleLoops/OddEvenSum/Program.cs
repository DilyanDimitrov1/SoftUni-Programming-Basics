using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0;
            var oddSum = 0;
            for (var x = 1; x <= n; x++)
            {
                var num = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    evenSum = evenSum + num;
                }
                else if (x % 2 != 0)
                {
                    oddSum = oddSum + num;
                }
            }
            var diff = Math.Abs(evenSum - oddSum);
            if (diff == 0)
            {
                Console.WriteLine($"Yes Sum = {evenSum}");
            }
            else if (diff != 0)
            {
                Console.WriteLine($"No Diff = {diff} ");
            }

        }
    }
}

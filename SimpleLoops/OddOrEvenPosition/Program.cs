using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var currentSum = 0;
            var prevSum = 0;
            var diff = 0;
            var maxDiff = 0;

            for (var x = 0; x < n; x++)
            {
                prevSum = currentSum;
                currentSum = 0;
                currentSum += int.Parse(Console.ReadLine());
                currentSum += int.Parse(Console.ReadLine());

                if (x != 0)
                {
                    diff = Math.Abs(currentSum - prevSum);
                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }

            }
            if (prevSum == currentSum || n == 1)
            {
                Console.WriteLine($"Yes, value={currentSum }");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff} ");
            }

        }
    }
}

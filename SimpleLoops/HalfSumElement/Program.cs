using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = int.MinValue;
            var restSum = 0;
            for (var x = 0; x < n; x++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;

                max = Math.Max(max, num);
                restSum = Math.Abs(sum - max);


            }
            if (max == restSum)
            {
                Console.WriteLine($"Yes, sum {max}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(max - restSum)}");
            }


        }
    }
}

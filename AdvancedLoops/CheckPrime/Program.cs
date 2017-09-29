using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var isPrime = true;

            if (n <= 2)
            {
                Console.WriteLine("Not prime");
                return;
            }

            for (var x = 2; x <= Math.Sqrt(n); x++)
            {
                if (n % x == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine("Prime");
            }
            else if (isPrime == false)
            {
                Console.WriteLine("Not prime");
            }

        }
    }
}

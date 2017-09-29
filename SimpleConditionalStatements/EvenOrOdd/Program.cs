using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var even = (num % 2 == 0);
            var odd = (num % 2 != 0);
            if (even == true)
            {
                Console.WriteLine("even");
            }
            else { Console.WriteLine("Odd"); }


        }
    }
}

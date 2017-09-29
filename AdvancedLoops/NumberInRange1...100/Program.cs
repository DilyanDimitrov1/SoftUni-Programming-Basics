using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange1._._._100
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());



            while (true)
            {
                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine($"The numer is: {n}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number. Please enter a number in the range:");
                    n = int.Parse(Console.ReadLine());
                }
            }




        }
    }
}

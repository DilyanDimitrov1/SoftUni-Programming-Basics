using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USD: ");
            var USD = decimal.Parse(Console.ReadLine());

            var BGN = 1.79549m * USD;

            Console.WriteLine(Math.Round(BGN, 2) + " BGN");

        }
    }
}

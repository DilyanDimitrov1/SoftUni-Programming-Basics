using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //F= C *1,8 + 32 
            Console.WriteLine("Celsius: ");
            var C = double.Parse(Console.ReadLine());

            var F = C * 1.8 + 32;

            Console.WriteLine($"Fahrenheit: {F:F2}");

        }
    }
}

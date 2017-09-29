using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            var outputNumber = 0.00;
            var realOutputNumber = 0.00;
            var m = "m";
            var cm = "cm";
            var mm = "mm";
            var mi = "mi";
            var i = "in";
            var km = "km";
            var ft = "ft";
            var yd = "yd";

            if (input == cm) { outputNumber = amount / 100; }
            else if (input == m) { outputNumber = amount / 1; }
            else if (input == mm) { outputNumber = amount / 1000; }
            else if (input == mi) { outputNumber = amount / 0.000621371192; }
            else if (input == i) { outputNumber = amount / 39.3700787; }
            else if (input == km) { outputNumber = amount / 0.001; }
            else if (input == ft) { outputNumber = amount / 3.2808399; }
            else if (input == yd) { outputNumber = amount / 1.0936133; }

            if (output == m) { realOutputNumber = outputNumber * 1; }
            if (output == cm) { realOutputNumber = outputNumber * 100; }
            else if (output == mm) { realOutputNumber = outputNumber * 1000; }
            else if (output == mi) { realOutputNumber = outputNumber * 0.000621371192; }
            else if (output == i) { realOutputNumber = outputNumber * 39.3700787; }
            else if (output == km) { realOutputNumber = outputNumber * 0.001; }
            else if (output == ft) { realOutputNumber = outputNumber * 3.2808399; }
            else if (output == yd) { realOutputNumber = outputNumber * 1.0936133; }

            Console.WriteLine(realOutputNumber);

        }
    }
}

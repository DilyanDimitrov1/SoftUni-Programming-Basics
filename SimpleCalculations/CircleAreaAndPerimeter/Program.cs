using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("r= ");
            var r = double.Parse(Console.ReadLine());

            var Area = Math.PI * r * r;
            var Perimeter = 2 * Math.PI * r;

            Console.WriteLine($"Area = {Area}");
            Console.WriteLine($"Perimeter= {Perimeter}");


        }
    }
}

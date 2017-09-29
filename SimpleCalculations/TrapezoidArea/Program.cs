using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Console.Write("b1: ");
            double b1 = double.Parse(Console.ReadLine());
            //Console.Write("b2: ");
            double b2 = double.Parse(Console.ReadLine());
            //Console.Write("h: ");
            double h = double.Parse(Console.ReadLine());
            double Area = (b1 + b2) * h / 2;
            Console.WriteLine($"The area is: {Area}");
        }
    }
}

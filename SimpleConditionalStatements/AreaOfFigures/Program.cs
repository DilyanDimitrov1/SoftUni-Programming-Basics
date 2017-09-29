using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var square = "square";
            var rectangle = "rectangle";
            var circle = "circle";
            var triangle = "triangle";
            if (figure == square)
            {
                var squareSide = double.Parse(Console.ReadLine());
                Console.WriteLine(squareSide * squareSide);
            }
            else if (figure == rectangle)
            {
                var rectangleSideA = double.Parse(Console.ReadLine());
                var rectangleSideB = double.Parse(Console.ReadLine());
                Console.WriteLine(rectangleSideA * rectangleSideB);
            }
            else if (figure == circle)
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * radius * radius:F3}");
            }
            else if (figure == triangle)
            {
                var triangleSide = double.Parse(Console.ReadLine());
                var triangleHeight = double.Parse(Console.ReadLine());
                Console.WriteLine((triangleHeight * triangleSide) / 2);
            }


        }
    }
}

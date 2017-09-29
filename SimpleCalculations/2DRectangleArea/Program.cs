using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            //Math.Max i Math.Min proverqvat po-golqma i po-malka stoinost. Razgledai gi. 
            double shirina = Math.Max(x1, y1) - Math.Min(x1, y1);
            double visochina = Math.Max(x2, y2) - Math.Min(x2, y2);

            Console.WriteLine($"Area= {shirina * visochina} ");
            var perimeter = (2 * shirina + 2 * visochina);
            Console.WriteLine($"Perimetyryt e: {perimeter}");

        }
    }
}

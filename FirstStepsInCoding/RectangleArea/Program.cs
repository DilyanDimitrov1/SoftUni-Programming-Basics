using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The length of side 'a' is");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The length of side 'b'is");
            var b = decimal.Parse(Console.ReadLine());
            if (a > 0 && b > 0)
            {
                var area = (a * b);
                Console.Write("Total area is:");
                Console.WriteLine(area);
            }
        }
    }
}

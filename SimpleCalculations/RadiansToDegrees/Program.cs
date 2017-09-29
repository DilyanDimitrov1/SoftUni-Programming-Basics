using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko gradusa? : ");
            var rad = double.Parse(Console.ReadLine());
            var degrees = (rad * 180 / Math.PI);
            Console.WriteLine(Math.Round(degrees));

        }
    }
}

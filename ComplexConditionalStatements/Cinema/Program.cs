using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var lines = int.Parse(Console.ReadLine());
            var rows = int.Parse(Console.ReadLine());
            switch (type)
            {
                case "Premiere":
                    Console.WriteLine($"{lines * rows * 12.00:f2}");
                    break;
                case "Normal":
                    Console.WriteLine($"{lines * rows * 7.50:f2}");
                    break;
                case "Discount":
                    Console.WriteLine($"{lines * rows * 5.00:f2}");
                    break;
            }

        }
    }
}

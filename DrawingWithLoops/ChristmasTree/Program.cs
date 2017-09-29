using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int spaces = n - 1;
            int stars = 1;

            Console.Write(new string(' ', n + 1));
            Console.WriteLine('|');
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                { Console.Write(' '); }
                for (int col = 1; col <= row; col++)
                { Console.Write("*"); }
                Console.Write(" | ");
                for (int col = 1; col <= row; col++)
                { Console.Write("*"); }
                for (int col = 1; col <= n - row; col++)
                { Console.Write(' '); }
                Console.WriteLine();
            }

        }
    }
}

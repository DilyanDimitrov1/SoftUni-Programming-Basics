using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 1000; x++)
            {
                if (x % 10 == 7)
                {
                    Console.WriteLine(x);
                }

            }
        }
}

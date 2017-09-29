using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            for (int x = 0; x < n - 1; x++)
            {

                int input = int.Parse(Console.ReadLine());

                if (num < input)
                {
                    num = input;

                }
            }
            Console.WriteLine(num);

        }
    }
}

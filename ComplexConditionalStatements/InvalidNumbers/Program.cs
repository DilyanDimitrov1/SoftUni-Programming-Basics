﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var range = (num >= 100 && num <= 200) || num == 0;
            {
                if (!range)
                {
                    Console.WriteLine("invalid");
                }
            }

        }
    }
}

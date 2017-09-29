using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = int.Parse(Console.ReadLine());
            var bonus = 0.0;
            if (points <= 100)
            {
                bonus = 5;
            }
            else if (points > 100 && points < 1000)
            {
                bonus = (points * 0.20);
            }
            else if (points > 1000)
            {
                bonus = (points * 0.10);
            }
            if (points % 2 == 0)
            {
                bonus += 1;
            }
            else if (points % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(points + bonus);


        }
    }
}

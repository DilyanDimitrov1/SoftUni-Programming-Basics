using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine();
            //p = holidays except weekends
            var p = double.Parse(Console.ReadLine());
            //h = weekends that he travels home 
            var h = double.Parse(Console.ReadLine());
            var satSofiaGames = (48 - h) * 3 / 4;
            var holiSofiaGames = p * 2 / 3;
            var games = satSofiaGames + holiSofiaGames + h;


            if (yearType == "normal")
            {
                Console.WriteLine(Math.Truncate(games));
            }
            else if (yearType == "leap")
            {
                var leapGamess = games + (games * 0.15);
                Console.WriteLine(Math.Truncate(leapGamess));
            }


        }
    }
}

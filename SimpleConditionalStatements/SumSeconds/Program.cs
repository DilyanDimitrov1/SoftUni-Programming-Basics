using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("seconds: ");
            var secs1 = int.Parse(Console.ReadLine());
            var secs2 = int.Parse(Console.ReadLine());
            var secs3 = int.Parse(Console.ReadLine());
            var seconds = secs1 + secs2 + secs3;
            if (seconds >= 00 && seconds <= 59)
            {
                if (seconds > 10)
                    Console.WriteLine($"0:{seconds}");
                if (seconds < 10) { Console.WriteLine($"0:0{seconds}"); }

            }
            if (seconds >= 60 && seconds <= 119)
            {
                var seconds1 = seconds - 60;
                if (seconds1 >= 10)
                    Console.WriteLine($"1:{seconds1}");
                if (seconds1 < 10) { Console.WriteLine($"1:0{seconds - 60}"); }
            }
            if (seconds >= 120 && seconds <= 179)
            {
                var seconds2 = seconds - 120;
                if (seconds2 >= 10)
                    Console.WriteLine($"2:{seconds2}");
                if (seconds2 < 10) { Console.WriteLine($"2:0{seconds - 120}"); }
            }



        }
    }
}

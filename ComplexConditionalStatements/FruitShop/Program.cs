using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var price = 0.0;

            bool weekday =
                day == "Monday" ||
                day == "Tuesday" ||
                day == "Wednesday" ||
                day == "Thursday" ||
                day == "Friday";
            bool weekend =
                day == "Saturday" ||
                day == "Sunday";


            if (fruit == "banana")
            {
                if (weekday)
                {
                    price = 2.50;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (weekend)
                {
                    price = 2.70;
                    Console.WriteLine($"{price * quantity:F2}");

                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (fruit == "apple")
            {
                if (weekday)
                {
                    price = 1.20;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (weekend)
                {
                    price = 1.25;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "orange")
            {
                if (weekday)
                {
                    price = 0.85;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (weekend)
                {
                    price = 0.90;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "grapefruit")
            {
                if (weekday)
                {
                    price = 1.45;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (weekend)
                {
                    price = 1.60;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "kiwi")
            {
                if (weekday)
                {
                    price = 2.70;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (weekend)
                {
                    price = 3.00;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "pineapple")
            {
                if (weekday)
                {
                    price = 5.50;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (weekend)
                {
                    price = 5.60;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "grapes")
            {
                if (weekday)
                {
                    price = 3.85;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else if (weekend)
                {
                    price = 4.20;
                    Console.WriteLine($"{price * quantity:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}

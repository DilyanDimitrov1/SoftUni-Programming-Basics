using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());

            switch (city)
            {
                case "Sofia":
                    if (0 <= sales && sales <= 500)
                    {
                        Console.WriteLine($"{0.05 * sales:f2}");
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        Console.WriteLine($"{0.07 * sales:f2}");
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        Console.WriteLine($"{0.08 * sales:f2}");
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine($"{0.12 * sales:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Varna":
                    if (0 <= sales && sales <= 500)
                    {
                        Console.WriteLine(0.045 * sales);
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        Console.WriteLine(0.075 * sales);
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        Console.WriteLine(0.1 * sales);
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine(0.13 * sales);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        Console.WriteLine($"{0.055 * sales:f2}");
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        Console.WriteLine($"{0.08 * sales:f2}");
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        Console.WriteLine($"{ 0.12 * sales:f2}");
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine($"{ 0.145 * sales}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}

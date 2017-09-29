using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount:");
            var inputAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Currency you'd like to convert:");
            var inputCurrency = Console.ReadLine();
            Console.WriteLine("Currency to convert to:");
            var outputCurrency = Console.ReadLine();
            var BGN = "BGN";
            var USD = "USD";
            var EUR = "EUR";
            var GBP = "GBP";
            if (inputCurrency == BGN && outputCurrency == USD)
            {
                Console.WriteLine($"{inputAmount / 1.79549:F2} USD");
            }
            else if (inputCurrency == USD && outputCurrency == BGN)
            {
                Console.WriteLine($"{1.79549 * inputAmount:F2} BGN");
            }
            else if (inputCurrency == BGN && outputCurrency == EUR)
            {
                Console.WriteLine($"{inputAmount / 1.95583:F2} EUR");
            }
            else if (inputCurrency == EUR && outputCurrency == BGN)
            {
                Console.WriteLine($"{1.95583 * inputAmount:F2} BGN");
            }
            else if (inputCurrency == BGN && outputCurrency == GBP)
            {
                Console.WriteLine($"{inputAmount / 2.53405:F2} GBP");
            }
            else if (inputCurrency == GBP && outputCurrency == BGN)
            {
                Console.WriteLine($"{2.53405 * inputAmount:F2} BGN");
            }
            //BGN done. 
            else if (inputCurrency == USD && outputCurrency == EUR)
            {
                Console.WriteLine($"{(inputAmount * 1.79549) / 1.95583:F2} EUR");
            }
            else if (inputCurrency == EUR && outputCurrency == USD)
            {
                Console.WriteLine($"{(inputAmount * 1.95583) / 1.79549:F2} USD");
            }
            else if (inputCurrency == USD && outputCurrency == GBP)
            {
                Console.WriteLine($"{(inputAmount * 1.79549) / 2.53405:F2} EUR");
            }
            else if (inputCurrency == GBP && outputCurrency == USD)
            {
                Console.WriteLine($"{(inputAmount * 2.53405) / 1.79549:F2} USD");
            }
            else if (inputCurrency == EUR && outputCurrency == GBP)
            {
                Console.WriteLine($"{(inputAmount * 1.95583) / 2.53405:F2} GBP");
            }
            else if (inputCurrency == GBP && outputCurrency == EUR)
            {
                Console.WriteLine($"{(inputAmount * 2.53405) / 1.95583:F2} EUR");
            }

        }
    }
}

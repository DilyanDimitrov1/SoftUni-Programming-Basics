using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDate = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var outputDate = DateTime.ParseExact(inputDate, format, System.Globalization.CultureInfo.InvariantCulture);
            outputDate = outputDate.AddDays(999);
            Console.WriteLine(outputDate.ToString(format));

        }
    }
}

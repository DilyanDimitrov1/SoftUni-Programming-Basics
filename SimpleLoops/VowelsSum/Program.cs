using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var sumLetters = 0;
            for (var x = 0; x <= word.Length - 1; x++)
            {
                var letter = word[x];
                switch (letter)
                {
                    case 'a':
                        sumLetters += 1;
                        break;
                    case 'e':
                        sumLetters += 2;
                        break;
                    case 'i':
                        sumLetters += 3;
                        break;
                    case 'o':
                        sumLetters += 4;
                        break;
                    case 'u':
                        sumLetters += 5;
                        break;


                }
            }
            Console.WriteLine(sumLetters);

        }
    }
}

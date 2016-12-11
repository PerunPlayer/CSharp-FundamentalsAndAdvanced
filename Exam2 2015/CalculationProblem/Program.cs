using System;
using System.Linq;

namespace CalculationProblem
{
    class Program
    {
        static int MeowToDec(string meow)
        {
            int result = 0;

            foreach (char digit in meow)
            {
                result = (digit - 'a') + result * 23;
            }

            return result;
        }

        static string DecToMeow(int dec)
        {
            var result = string.Empty;

            while (dec > 0)
            {
                char digit = (char)('a' + (dec % 23));
                result = digit + result;
                dec /= 23;

            }

            return result;
        }
        static void Main()
        {
            var sum = Console.ReadLine().Split(' ').Select(MeowToDec).ToArray().Sum();

            var answer = DecToMeow(sum) + " = " + sum;

            Console.WriteLine(answer);
        }
    }
}

using System;

namespace EnglishDigit
{
    class Program
    {
        static string EnglishDigit(int number)
        {
            switch (number % 10)
            {
                default: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(EnglishDigit(number));
        }
    }
}

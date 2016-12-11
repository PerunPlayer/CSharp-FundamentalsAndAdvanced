using System;

namespace ReverseNumber
{
    class Program
    {
        static string ReverseNumber(string number)
        {
            string newNumber = String.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                newNumber += number[i];
            }
            return newNumber;
        }
        static void Main()
        {
            string number = Console.ReadLine();

            Console.WriteLine(ReverseNumber(number));
        }
    }
}

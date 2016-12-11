using System;

namespace NumberOfPages
{
    class Program
    {
        static void Main()
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int numberOfDigits = 0;

            int[] number = new int[numberOfPages];
            for (int i = 1; i <= number.Length; i++)
            {
                if (1 <= i && i <= 9)
                {
                    numberOfDigits += 1;
                }
                else if (10 <= i && i <= 99)
                {
                    numberOfDigits += 2;
                }
                else if (100 <= i && i <= 999)
                {
                    numberOfDigits += 3;
                }
                else if (1000 <= i && i <= 9999)
                {
                    numberOfDigits += 4;
                }
                else if (10000 <= i && i <= 99999)
                {
                    numberOfDigits += 5;
                }
                else if (100000 <= i && i <= 999999)
                {
                    numberOfDigits += 6;
                }
                else
                {
                    numberOfDigits += 7;
                }
            }

            Console.WriteLine(numberOfDigits);
        }
    }
}
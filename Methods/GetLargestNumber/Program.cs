using System;
using System.Linq;

namespace GetLargestNumber
{
    class Program
    {
        static int GetMax(int first, int second)
        {
            int max = first;
            if (second > max)
            {
                max = second;
            }
            return max;
        }
        static void Main()
        {
            int[] numbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int first = numbersArr[0];
            int second = numbersArr[1];
            int third = numbersArr[2];

            int maxOfAll = GetMax(numbersArr[0], GetMax(numbersArr[1], numbersArr[2]));
            Console.WriteLine(maxOfAll);
        }
    }
}

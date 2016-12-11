using System;
using System.Linq;

namespace AppearanceCount
{
    class Program
    {
        static int RepeatedNumber(int[] array, int repeatedNumber)
        {
            int counter = 0;
            foreach (int i in array)
            {
                if (i == repeatedNumber)
                {
                    counter++;
                }
            }

            return counter;
        }
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int repeatedNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatedNumber(array, repeatedNumber));
        }
    }
}

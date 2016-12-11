using System;
using System.Linq;

namespace LargerThanNeighbours
{
    class Program
    {
        static int Larger(int[] array)
        {
            int couter = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    couter++;
                }
            }
            return couter;
        }
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(Larger(array));
        }
    }
}

using System;
using System.Linq;

namespace FirstLargerThanNeighbours
{
    class Program
    {
        static int First(int[] array)
        {
            int index = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(First(array));
        }
    }
}

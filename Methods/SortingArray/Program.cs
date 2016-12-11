using System;
using System.Linq;

namespace SortingArray
{
    class Program
    {
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(array);

            Console.WriteLine(string.Join(" ", array));
        }
    }
}

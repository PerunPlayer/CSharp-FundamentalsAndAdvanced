using System;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr1 = new int[N];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int X = int.Parse(Console.ReadLine());

            Array.Sort(arr1);
            Array.BinarySearch(arr1, X);

            Console.WriteLine(arr1[]);
        }
    }
}

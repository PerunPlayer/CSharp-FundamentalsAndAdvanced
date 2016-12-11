using System;

namespace Busses
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
        }
    }
}
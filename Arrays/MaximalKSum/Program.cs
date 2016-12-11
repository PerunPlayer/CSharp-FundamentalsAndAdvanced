using System;

namespace MaximalKSum
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] arr1 = new int[N];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int MaximalKSum = 0;

            Array.Sort(arr1);
            Array.Reverse(arr1);

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}

            for (int i = 0; i < K; i++)
            {
                MaximalKSum += arr1[i];
            }

            Console.WriteLine(MaximalKSum);
        }
    }
}

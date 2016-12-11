using System;

namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int MaximalSum = int.MinValue;
            int[] arr1 = new int[N];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());

                currentSum += arr1[i];

                if (currentSum < arr1[i])
                {
                    currentSum = arr1[i];
                }

                if (currentSum > MaximalSum)
                {
                    MaximalSum = currentSum;
                }
            }

            Console.WriteLine(MaximalSum);
        }
    }
}
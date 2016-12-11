using System;

namespace maximalSequence
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
            int currentSequence = 1;
            int maxSequence = 1;

            for (int i = 0; i < arr1.Length - 1; i++)
            {
                if (arr1[i] == arr1[i + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
            }


            Console.WriteLine(maxSequence);
        }
    }
}

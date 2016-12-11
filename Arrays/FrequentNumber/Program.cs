using System;

namespace FrequentNumber
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
            int frequent = 0;
            int howManyTimes = 0;
            int count = 1;

            Array.Sort(arr1);

            for (int i = 0; i < arr1.Length - 1; i++)
            {
                if (arr1[i] == arr1[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > howManyTimes)
                    {
                        howManyTimes = count;
                        frequent = arr1[i];
                    }
                    count = 1;
                }
            }

            if (count > howManyTimes)
            {
                howManyTimes = count;
                frequent = arr1[arr1.Length - 1];
            }

            Console.WriteLine("{0} ({1} times)", frequent, howManyTimes);
        }
    }
}

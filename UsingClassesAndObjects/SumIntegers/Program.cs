using System;

namespace SumIntegers
{
    class Program
    {
        static void Main()
        {
            string[] integers = Console.ReadLine().Split(' ');
            int sum = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                sum += int.Parse(integers[i]);
            }
            Console.WriteLine(sum);
        }
    }
}

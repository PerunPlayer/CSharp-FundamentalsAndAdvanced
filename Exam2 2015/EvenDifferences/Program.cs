using System;
using System.Linq;

namespace EvenDifferences
{
    class Program
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long sum = 0;
            int i = 1;

            while (i < sequence.Length)
            {
                long absoluteDifference = Math.Abs(sequence[i] - sequence[i - 1]);

                if (absoluteDifference % 2 == 0)
                {
                    sum += absoluteDifference;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

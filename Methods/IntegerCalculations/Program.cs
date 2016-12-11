using System;
using System.Linq;

namespace IntegerCalculations
{
    class Program
    {
        static int Min(int[] sequence)
        {
            int minNumber = sequence[0];
            for (int i = 0; i < sequence.Length; i++)
            {

                if (minNumber > sequence[i])
                {
                    minNumber = sequence[i];
                }
            }

            return minNumber;
        }

        static int Max(int[] sequence)
        {
            int maxNumber = sequence[0];

            for (int i = 0; i < sequence.Length; i++)
            {
                if (maxNumber < sequence[i])
                {
                    maxNumber = sequence[i];
                }
            }

            return maxNumber;
        }

        static decimal Average(int[] sequence)
        {
            long sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }

            decimal average = (decimal)sum / sequence.Length;
            return average;
        }

        static long Sum(int[] sequence)
        {
            long sum = 0;
            foreach (var number in sequence)
            {
                sum += number;
            }

            return sum;
        }

        static long Product(int[] sequence)
        {
            long product = 1;
            foreach (var number in sequence)
            {
                product *= number;
            }

            return product;
        }
        static void Main()
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(Min(sequence));
            Console.WriteLine(Max(sequence));
            Console.WriteLine("{0:F2}", Average(sequence));
            Console.WriteLine(Sum(sequence));
            Console.WriteLine(Product(sequence));
        }
    }
}

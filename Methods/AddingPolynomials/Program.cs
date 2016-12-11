using System;
using System.Collections.Generic;
using System.Linq;

namespace AddingPolynomials
{
    class Program
    {
        static int[] Addition(int[] first, int[] second)
        {
            if (first.Length < second.Length)
            {
                return Addition(second, first);
            }

            int[] polynomialSum = new int[first.Length];

            for (int i = 0; i < second.Length; i++)
            {
                polynomialSum[i] = first[i] + second[i];
            }

            for (int i = second.Length; i < first.Length; i++)
            {
                polynomialSum[i] = first[i];
            }

            return polynomialSum;
        }
        static void Main()
        {
            Console.ReadLine();
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sum = Addition(first, second);

            var list = new List<int>();
            for (int i = 0; i < sum.Length; i++)
            {
                list.Add(sum[i]);
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}

using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static BigInteger Factorial(int[] array)
        {
            BigInteger result = 1;
            for (int i = 0; i < array.Length; i++)
            {
                result *= array[i];
            }

            return result;
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            Console.WriteLine(Factorial(array));
        }
    }
}

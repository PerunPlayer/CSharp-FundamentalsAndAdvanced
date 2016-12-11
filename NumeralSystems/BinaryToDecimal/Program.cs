using System;
using System.Numerics;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            string binaryNumber = Console.ReadLine();

            BigInteger decimalNumber = 0;
            int fromSystem = 2;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                decimalNumber += (BigInteger)Math.Pow(fromSystem, i) *
                   int.Parse(binaryNumber[binaryNumber.Length - 1 - i].ToString());
            }

            Console.WriteLine(decimalNumber);
        }
    }
}

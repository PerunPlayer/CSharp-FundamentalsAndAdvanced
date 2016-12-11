using System;
using System.Numerics;

namespace DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            string binaryNumber = "";
            int system = 2;

            while (number > 0)
            {
                binaryNumber = (number % system).ToString() + binaryNumber;
                number /= system;
            }
            Console.WriteLine(binaryNumber);
        }
    }
}

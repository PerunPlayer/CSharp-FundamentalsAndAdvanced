using System;
using System.Numerics;

namespace DecToHex
{
    class Program
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            string hexNumber = "";
            string[] hex = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

            int toBase = 16;

            while (number > 0)
            {
                hexNumber = hex[(int)(number % toBase)]
                          + hexNumber;
                
                number /= toBase;
            }

            Console.WriteLine(hexNumber);
        }
    }
}

using System;
using System.Numerics;

namespace HexToDec
{
    class Program
    {
        static void Main()
        {
            string hexNumber = Console.ReadLine().ToUpper();
            
            string[] hex = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

            int fromSystem = 16;

            BigInteger number = 0;

            for (int i = 0; i < hexNumber.Length; i++)
            {
                number += (BigInteger)Math.Pow(fromSystem, i) * Array.IndexOf(hex,
                             hexNumber[hexNumber.Length - 1 - i].ToString());
            }
            
            Console.WriteLine(number.ToString());
        }
    }
}

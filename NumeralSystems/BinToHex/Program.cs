using System;
using System.Numerics;

namespace BinToHex
{
    class Program
    {
        static void Main()
        {
            string binNumber = Console.ReadLine();
            string hexNumber = "";
            string[] hex = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');
            int fromBase = 2;

            string binSection = "";
            int hexIndex = 0;

            while (binNumber.Length > 0)
            {
                if (binNumber.Length >= 4)
                {
                    binSection = binNumber.Substring(binNumber.Length - 4, 4);
                    binNumber = binNumber.Remove(binNumber.Length - 4, 4);
                }
                else
                {
                    binSection = binNumber;
                    binNumber = "";
                }
                
                hexIndex = 0;

                for (int i = 0; i < binSection.Length; i++)
                {
                    hexIndex += (int)Math.Pow(fromBase, i)
                                * int.Parse(binSection[binSection.Length - 1 - i].ToString());
                }

                hexNumber = hex[hexIndex] + hexNumber;
            }

            Console.WriteLine(hexNumber);
        }
    }
}

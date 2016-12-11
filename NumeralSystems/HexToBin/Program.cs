using System;
using System.Numerics;

namespace HexToBin
{
    class Program
    {
        static void Main()
        {
            string hexNumber = Console.ReadLine();
            
            string[] HexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

            string binNumber = "";
            string tempBinNumb = "";

            int toSystem = 2;

            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                var digit = Array.IndexOf(HexKey, hexNumber[i].ToString());

                while (digit > 0)
                {
                    tempBinNumb = (digit % toSystem).ToString() + tempBinNumb;
                    digit /= toSystem;
                }

                tempBinNumb = tempBinNumb.PadLeft(4, '0');

                binNumber = tempBinNumb + binNumber;

                tempBinNumb = "";
            }
            
            Console.WriteLine(binNumber.TrimStart('0'));
        }
    }
}

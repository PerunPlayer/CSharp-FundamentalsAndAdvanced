using System;

namespace ShortBinary
{
    class Program
    {
        static void Main()
        {
            short number = short.Parse(Console.ReadLine());
            string binary = "";
            string[] BinKey = "0 1".Split(' ');

            for (int i = 0; i < 16; i++)
            {
                binary = BinKey[(number & 1)] + binary;
                number >>= 1;
            }

            Console.WriteLine(binary.PadLeft(16, '0'));
        }
    }
}

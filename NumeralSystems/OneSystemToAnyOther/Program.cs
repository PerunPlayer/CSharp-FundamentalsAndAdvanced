using System;
using System.Text;
using System.Numerics;

namespace OneSystemToAnyOther
{
    class Program
    {
        static string HexKey = "0123456789ABCDEF";

        static void Main()
        {
            var fromSystem = int.Parse(Console.ReadLine());
            var toConvert = Console.ReadLine();
            var toSystem = int.Parse(Console.ReadLine());

            var toPrint = "";

            toPrint = toDec(toConvert, fromSystem);
            toPrint = DecToAny(toPrint, toSystem);

            Console.WriteLine(toPrint);
        }

        static string toDec(string toConvert, int fromSystem)
        {
            BigInteger result = 0;

            foreach (var digit in toConvert)
            {
                result = (BigInteger)
                    (HexKey.IndexOf(digit.ToString()) + result * fromSystem);
            }

            return result.ToString();
        }

        static string DecToAny(string toConvert, int toSystem)
        {
            var result = new StringBuilder();

            var decNumber = BigInteger.Parse(toConvert);

            while (decNumber > 0)
            {
                var Digit = decNumber % toSystem;

                result.Insert(0, HexKey[(int)Digit]);

                decNumber /= toSystem;
            }

            return result.ToString();
        }
    }
}
using System;

namespace EnterNumbers
{
    class Program
    {
        static void Main()
        {
            int[] input = new int[12];

            input[0] = 1;
            input[11] = 100;

            for (int i = 1; i < input.Length - 1; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 9; i++)
            {
                if (ReadNumber(input[i], input[i + 1]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Exception");
                    return;
                }
            }

            Console.WriteLine(string.Join(" < ", input));
        }

        private static bool ReadNumber(int start, int end)
        {
            if (start < end)
            {
                return true;
            }

            return false;
        }
    }
}

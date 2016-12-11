using System;
using System.Text;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder answer = new StringBuilder();

            answer.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    answer.Append(input[i]);
                }
            }
            Console.WriteLine(answer.ToString());
        }
    }
}

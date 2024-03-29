﻿using System;
using System.Text;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder answer = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                answer.AppendFormat("\\u{0:X4}", (int)input[i]);
            }

            Console.WriteLine(answer);
        }
    }
}

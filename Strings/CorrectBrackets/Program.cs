using System;

namespace CorrectBrackets
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool isCorrect = true;
            int nextOpenBracket = input.IndexOf('(');
            int nextCloseBracket = input.IndexOf(')');
            while (nextCloseBracket != -1 && nextOpenBracket != -1)
            {
                if (nextOpenBracket < nextCloseBracket)
                {
                    nextOpenBracket = input.IndexOf('(', nextOpenBracket + 1);
                    nextCloseBracket = input.IndexOf(')', nextCloseBracket + 1);
                }
                else
                {
                    isCorrect = false;
                    break;
                }
            }
            if (nextCloseBracket != -1 || nextOpenBracket != -1)
            {
                isCorrect = false;
            }
            Console.WriteLine(isCorrect ? "Correct" : "Incorrect");
        }
    }
}

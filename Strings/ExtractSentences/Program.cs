using System;
using System.Linq;

namespace ExtractSentences
{
    class Program
    {
        private static char[] FindSymbols(string text)
        {
            char[] symbols = text.Where(ch => !char.IsLetter(ch)).Distinct().ToArray();

            return symbols;
        }
        static void Main()
        {
            string repeatedWord = Console.ReadLine().Trim();
            string text = Console.ReadLine();

            string[] sentences = text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            char[] separators = FindSymbols(text);

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    if (word.Trim() == repeatedWord)
                    {
                        Console.Write(sentence.Trim() + ". ");
                        break;
                    }
                }
            }
        }
    }
}

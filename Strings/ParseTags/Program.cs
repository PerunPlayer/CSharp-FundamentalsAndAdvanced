using System;
using System.Text;

namespace ParseTags
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string StartTag = "<upcase>";
            string EndTag = "</upcase>";

            StringBuilder parsed = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (i + StartTag.Length < text.Length && text.Substring(i, StartTag.Length).Equals(StartTag))
                {
                    string add = text.Substring(i + StartTag.Length, 
                        text.IndexOf(EndTag, i + StartTag.Length) - i - EndTag.Length + 1);
                    parsed.Append(add.ToUpper());
                    i = text.IndexOf(EndTag, i + StartTag.Length) + EndTag.Length - 1;
                }
                else
                {
                    parsed.Append(text[i]);
                }
            }

            Console.WriteLine(parsed);
        }
    }
}

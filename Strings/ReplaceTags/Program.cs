using System;
using System.Text;

namespace ReplaceTags
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder answer = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<' && input[i + 1] == 'a')
                {
                    var begin = ExtractBeginOuterHtml(input, i);
                    var url = ExtractUrl(begin);
                    var innerText = ExtractInnerText(begin);
                    answer.AppendFormat("[{0}]({1})", innerText, url);
                    i += begin.Length - 1;
                    continue;
                }

                answer.Append(input[i]);
            }

            Console.WriteLine(answer);
        }

        static string ExtractInnerText(string begin)
        {
            int indexOfFirstClosingBracket = begin.IndexOf(">", 1);
            int indexOfSecondOpeningBracket = begin.IndexOf("<", indexOfFirstClosingBracket);
            var innerText = begin.Substring(indexOfFirstClosingBracket + 1, indexOfSecondOpeningBracket - indexOfFirstClosingBracket - 1);
            return innerText;
        }

        static string ExtractUrl(string begin)
        {
            int firstIndexOfDoubleQuote = begin.IndexOf("\"");
            int lastIndexOfDoubleQuote = begin.LastIndexOf("\"");
            var url = begin.Substring(firstIndexOfDoubleQuote + 1, lastIndexOfDoubleQuote - firstIndexOfDoubleQuote - 1);
            return url;
        }

        static string ExtractBeginOuterHtml(string text, int i)
        {
            int indexOfClosingAnchorTag = text.IndexOf("</a>", i);
            var begin = text.Substring(i, indexOfClosingAnchorTag + 4 - i);
            return begin;
        }
    }
}

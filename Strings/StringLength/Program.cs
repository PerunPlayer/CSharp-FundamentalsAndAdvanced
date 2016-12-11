using System;

namespace StringLength
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            text = text.Replace(@"\", string.Empty);
            string result = text.PadRight(20, '*');

            Console.WriteLine(result);
        }
    }
}

using System;

namespace Sub_StringInText
{
    class Program
    {
        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int counter = 0;
            int index = 0;

            while (1==1)
            {
                int foundIndex = text.IndexOf(pattern, index);
                if (foundIndex < 0)
                {
                    break;
                }

                counter++;
                index = foundIndex + 1;
            }

            Console.WriteLine(counter);
        }
    }
}

using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            string String = Console.ReadLine();


            int[] array = new int[26];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 'a' + i;
            }


            for (int i = 0; i < String.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (String[i] == array[j])
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }

        }
    }
}

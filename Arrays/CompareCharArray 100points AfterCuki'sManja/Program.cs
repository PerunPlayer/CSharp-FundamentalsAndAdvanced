using System;

class Program
{
    static void Main()
    {
        char[] FirstCharArray = (Console.ReadLine()).ToCharArray();
        char[] SecondCharArray = (Console.ReadLine()).ToCharArray();
        int shorterLength = 0;
        if (FirstCharArray.Length > SecondCharArray.Length)
        {
            shorterLength = SecondCharArray.Length;
        }
        else
        {
            shorterLength = FirstCharArray.Length;
        }
        for (int i = 0; i < shorterLength; i++)
        {
            if (FirstCharArray[i] > SecondCharArray[i])
            {
                Console.WriteLine('>'); Environment.Exit(0);
            }
            else if (FirstCharArray[i] < SecondCharArray[i])
            {
                Console.WriteLine('<'); Environment.Exit(0);
            }
        }
        if (FirstCharArray.Length > SecondCharArray.Length)
        {
            Console.WriteLine('>');
        }
        else if (FirstCharArray.Length < SecondCharArray.Length)
        {
            Console.WriteLine('<');
        }
        else
        {
            Console.WriteLine('=');
        }
    }
}
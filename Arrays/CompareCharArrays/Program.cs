using System;

class Program
{
    static void Main()
    {
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();
        int count = 0;

        char[] firstArr = firstString.ToCharArray();
        char[] secondArr = secondString.ToCharArray();

        if (firstArr.Length > secondArr.Length)
        {
            Console.WriteLine('>');
        }
        else if (firstArr.Length < secondArr.Length)
        {
            Console.WriteLine('<');
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
                else if (firstArr[i] < secondArr[i])
                {
                    Console.WriteLine('<');
                    break;
                }
                else if (firstArr[i] > secondArr[i])
                {
                    Console.WriteLine('>');
                    break;
                }
            }
            if (count == firstArr.Length)
            {
                Console.WriteLine('=');
            }
        }
    }
}
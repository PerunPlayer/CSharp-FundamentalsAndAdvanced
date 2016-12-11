using System;

class Program
{
    static void Main()
    {
        //input
        int module = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        int result = 0;

        //logic
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (ch == '@')
            {
                break;
            }
            else if ('0' <= ch && ch <= '9')
            {
                result *= (ch - '0');
            }
            else if ('a' <= ch && ch <= 'z')
            {
                result += (ch - 'a');
            }
            else if ('A' <= ch && ch <= 'Z')
            {
                result += (ch - 'A');
            }
            else
            {
                result = result % module;
            }
        }

        //result
        Console.WriteLine(result);
    }
}

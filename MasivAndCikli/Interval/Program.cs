using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = N + 1; i < M; i++)
        {
            if (i % 5 == 0)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}

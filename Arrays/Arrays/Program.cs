using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        for (int i = 0; i < N ; i++)
        {
            int result = (i * 5);
            Console.WriteLine(result);
        }
    }
}
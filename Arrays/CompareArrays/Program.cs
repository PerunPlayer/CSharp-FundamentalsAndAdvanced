using System;


class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        bool result = false;
        int[] arr1 = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        int[] arr2 = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < N; i++)
        {
            if (arr1[i] == arr2[i])
            {
                result = true;
            }
            else
            {
                result = false;
                break;
            }
        }
        if (result)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}
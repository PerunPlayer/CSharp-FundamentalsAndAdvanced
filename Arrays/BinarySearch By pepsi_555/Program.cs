using System;

class BinarySearch
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr1 = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        int element = int.Parse(Console.ReadLine());
        
        Array.Sort(arr1);

        int leftRange = 0;
        int rightRange = arr1.Length - 1;
        int middle = 0;
        int index = -1;

        while (leftRange <= rightRange)
        {
            middle = (leftRange + rightRange) / 2;
            if (arr1[middle] < element)
            {
                leftRange = middle + 1;
            }
            else if (arr1[middle] > element)
            {
                rightRange = middle - 1;
            }
            else
            {
                index = middle;
                break;
            }
        }

        Console.WriteLine(index);

    }
}
using System;

class MergeSortAlgorithm
{
    static int[] arr1;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        arr1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        MergeSort(0, arr1.Length - 1);

        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine(arr1[i]);
        }
    }

    static void MergeSort(int start, int end)
    {
        if (start >= end) return;

        int middle = (start + end) / 2;

        MergeSort(start, middle);
        MergeSort(middle + 1, end);

        CompareAndSort(start, middle, end);
    }

    static void CompareAndSort(int start, int middle, int end)
    {
        int[] sortedArr = new int[arr1.Length];

        int leftLocalArr = start;
        int leftArrStart = start;
        int middleArrStart = middle + 1;

        while (leftArrStart <= middle && middleArrStart <= end)
        {
            if (arr1[leftArrStart] > arr1[middleArrStart])
            {
                sortedArr[leftLocalArr++] = arr1[middleArrStart++];
            }
            else
            {
                sortedArr[leftLocalArr++] = arr1[leftArrStart++];
            }
        }
        
        while (leftArrStart <= middle)
        {
            sortedArr[leftLocalArr++] = arr1[leftArrStart++];
        }

        while (middleArrStart <= end)
        {
            sortedArr[leftLocalArr++] = arr1[middleArrStart++];
        }

        for (int i = start; i <= end; i++)
        {
            arr1[i] = sortedArr[i];
        }
    }

}
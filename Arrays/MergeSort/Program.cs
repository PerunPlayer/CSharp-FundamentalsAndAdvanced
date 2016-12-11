using System;

namespace MergeSort
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arrayNums = new int[N];
            for (int i = 0; i < arrayNums.Length; i++)
            {
                arrayNums[i] = int.Parse(Console.ReadLine());
            }

            MergeSort(0, arrayNums.Length - 1);

            for (int i = 0; i < arrayNums.Length; i++)
            {
                Console.WriteLine(arrayNums[i]);
            }
        }

        static void MergeSort(int start, int end)
        {
            // Array with 1 element
            if (start >= end) return;

            // Define a middle of the array
            int middle = (start + end) / 2;

            MergeSort(start, middle);
            MergeSort(middle + 1, end);

            CompareAndSort(start, middle, end);
        }

        static void CompareAndSort(int start, int middle, int end)
        {
            int[] sortedArr = new int[arrayNums.Length];

            int leftLocalArr = start; // for saving the values of the local array, which always starts from start
            int leftArrStart = start; // for the beginning of the left array
            int middleArrStart = middle + 1; // where starts the right sub-array <=> the left range ot the right sub-array

            //inserting the smaller numbers
            while (leftArrStart <= middle && middleArrStart <= end)
            {
                if (arrayNums[leftArrStart] > arrayNums[middleArrStart])
                {
                    sortedArr[leftLocalArr++] = arrayNums[middleArrStart++];
                }
                else
                {
                    sortedArr[leftLocalArr++] = arrayNums[leftArrStart++];
                }
            }


            while (leftArrStart <= middle)
            {
                sortedArr[leftLocalArr++] = arrayNums[leftArrStart++];
            }

            while (middleArrStart <= end)
            {
                sortedArr[leftLocalArr++] = arrayNums[middleArrStart++];
            }

            for (int i = start; i <= end; i++)
            {
                arrayNums[i] = sortedArr[i];
            }
        }

    }
}
    }
}

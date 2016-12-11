using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrayNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }

        int currentLength = 1;
        int maxLength = 0;

        for (int i = 0; i < arrayNums.Length - 1; i++)
        {
            if (arrayNums[i] < arrayNums[i + 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
                currentLength = 1;
            }
        }
        
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
        }

        Console.WriteLine(maxLength);
    }
}
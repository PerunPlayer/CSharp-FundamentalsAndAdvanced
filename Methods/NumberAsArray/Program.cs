using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberAsArray
{
    class Program
    {
        static string SumOfArrays(int[] firstArray, int[] secondArray)
        {
            List<int> maxArray = new List<int>();
            List<int> minArray = new List<int>();

            if (firstArray.Length > secondArray.Length)
            {
                maxArray.AddRange(firstArray);
                minArray.AddRange(secondArray);
            }
            else
            {
                maxArray.AddRange(secondArray);
                minArray.AddRange(firstArray);
            }

            int minLength = minArray.Count;
            int maxLength = maxArray.Count;
            int addition = 0;
            int sum = 0;
            var result = new StringBuilder();

            for (int i = 0; i < minLength; i++)
            {
                sum = minArray[i] + maxArray[i] + addition;
                if (sum >= 10)
                {
                    addition = 1;
                    sum = sum % 10;
                    result.Append(sum);
                }
                else
                {
                    result.Append(sum);
                    addition = 0;
                }
            }

            for (int j = minLength; j < maxLength; j++)
            {
                sum = maxArray[j] + addition;
                if (sum >= 10)
                {
                    addition = 1;
                    sum = sum % 10;
                    result.Append(sum);
                }
                else
                {
                    result.Append(sum);
                    addition = 0;
                }
            }

            if (addition == 1)
            {
                result.Append(1);
            }

            char[] reversed = (result.ToString()).ToCharArray();
            result.Clear();

            for (int i = 0; i < reversed.Length; i++)
            {
                result.Append(reversed[i]);
                result.Append(" ");
            }

            return result.ToString();
        }
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number1 = input[0];
            int number2 = input[1];
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string result = SumOfArrays(firstArray, secondArray);
            Console.WriteLine(result);
        }
    }
}

using System;

namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            string[] sizeString = Console.ReadLine().Split(' ');
            short[][] search = new short
                [int.Parse(sizeString[0])][];

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < cols; column++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, column);
                    matrix[row, column] = int.Parse(Console.ReadLine());
                }
            }

            int SearchSize = 3;

            short curMaxSum = short.MinValue; 
            short curSum = 0;

            for (int row = 0;
                     row < search.GetLength(0)
                           - (SearchSize - 1);
                     row++)
            {
                for (int col = 0;
                         col < search[0].GetLength(0)
                               - (SearchSize - 1);
                         col++)
                {
                    curSum = 0;

                    for (int curRow = row;
                             curRow < row + SearchSize;
                             curRow++)
                    {
                        for (int curCol = col;
                                 curCol < col + SearchSize;
                                 curCol++)
                        {
                            curSum += search[curRow][curCol];
                        }
                    }
                    if (curSum > curMaxSum)
                    {
                        curMaxSum = curSum;
                    }
                }
            }
            Console.WriteLine(curMaxSum);
        }
    }
}
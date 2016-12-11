using System;
using System.Linq;

namespace LoverOf3
{
    class Program
    {
        static bool IsInside(int row, int col, )
        {
            bool rowIsInField = 0 <= row + deltaRow && row + deltaRow < field.GetLength(0);
            bool colIsInField = 0 <= col + deltaCol && col + deltaCol < field.GetLength(1);
        }
        static void Main()
        {
            var fieldSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var rowsCount = fieldSize[0];
            var colsCount = fieldSize[1];
            var field = new bool[rowsCount, colsCount];

            var n = int.Parse(Console.ReadLine());
            long result = 0;

            int row = rowsCount - 1;
            int col = 0;

            for (int i = 0; i < n; i++)
            {
                var move = Console.ReadLine().Split(' ');
                var direction = move[0];
                var repeats = int.Parse(move[1]);

                var deltaRow = direction.Contains("U") ? -1 : 1;
                var deltaCol = direction.Contains("L") ? -1 : 1;

                // could also be from 0 to repeats - 1
                for (int j = 1; j < repeats; j++)
                {
                    if (IsInside(row + deltaRow, col + deltaCol, ))
                    {
                        row += deltaRow;
                        col += deltaCol;

                        if (!field[row, col])
                        {
                            result += col * 3 + (rowsCount)
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}

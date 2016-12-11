using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] Array_2d = new int[size, size];
            int[] Array = new int[size * size];
            char version = char.Parse(Console.ReadLine());

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = i + 1;
            }

            switch (version)
            {
                case 'a':
                    FillTheMatrix1(Array_2d, Array);
                    Print(Array_2d);
                    break;
                case 'b':
                    FillTheMatrix2(Array_2d, Array);
                    Print(Array_2d);
                    break;
                case 'c':
                    FillTheMatrix3(Array_2d, Array);
                    Print(Array_2d);
                    break;
                case 'd':
                    FillTheMatrix4(Array_2d);
                    Print(Array_2d);
                    break;
                default:
                    break;
            }
        }
        static void FillTheMatrix1(int[,] Array_2d, int[] Array)
        {
            int index = 0;
            for (int i = 0; i < Array_2d.GetLength(0); i++)
            {
                for (int j = 0; j < Array_2d.GetLength(1); j++)
                {
                    Array_2d[j, i] = Array[index];
                    index++;
                }
            }
        }
        static void FillTheMatrix2(int[,] Array_2d, int[] Array)
        {
            int index = 0;
            for (int i = 0; i < Array_2d.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < Array_2d.GetLength(1); j++)
                    {
                        Array_2d[j, i] = Array[index];
                        index++;
                    }
                }
                else
                {
                    for (int j = Array_2d.GetLength(1) - 1; j >= 0; j--)
                    {
                        Array_2d[j, i] = Array[index];
                        index++;
                    }
                }
            }
        }
        static void FillTheMatrix3(int[,] Array_2d, int[] Array)
        {
            int index = 0;
            int row = 0;
            int col = 0;

            BeforeDiagonal(Array_2d, row, col, ref index, Array);
            AfterDiagonal(Array_2d, row, col, ref index, Array);
        }
        static void BeforeDiagonal(int[,] Array_2d, int row, int col, ref int index, int[] Array)
        {
            for (int i = Array_2d.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < Array_2d.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        row = i;
                        col = j;
                    }

                    Array_2d[row, col] = Array[index];
                    index++;
                    if (row == Array_2d.GetLength(0) - 1)
                    {
                        break;
                    }
                    row++;
                    col++;
                }

            }
        }
        static void AfterDiagonal(int[,] Array_2d, int row, int col, ref int index, int[] Array)
        {
            for (int i = 1; i < Array_2d.GetLength(0); i++)
            {
                for (int j = 0; j < Array_2d.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        col = i;
                        row = j;
                    }

                    Array_2d[row, col] = Array[index];
                    index++;
                    if (col == Array_2d.GetLength(1) - 1)
                    {
                        break;
                    }
                    row++;
                    col++;
                }
            }
    }
        static void FillTheMatrix4(int[,] Array_2d)
        {
            int row = 0;
            int col = 0;
            int way = 0;
            int side = Array_2d.GetLength(0);
            int[,] navigator = {
                                { 1, 0 },
                                { 0, 1 },
                                { -1, 0 },
                                { 0, -1 }
                                };
            for (int i = 1; i <= side * side; i++)
            {
                Array_2d[col, row] = i;
                int nextX = col + navigator[way, 0];
                int nextY = row + navigator[way, 1];
                if (nextX == side ||
                    nextX == -1 ||
                    nextY == side ||
                    nextY == -1 ||
                    Array_2d[nextX, nextY] != 0)
                {
                    way++;
                    way %= 4;
                }
                col += navigator[way, 0];
                row += navigator[way, 1];
            }
        }
        static void Print(int[,] Array_2d)
        {
            for (int i = 0; i < Array_2d.GetLength(0); i++)
            {
                for (int j = 0; j < Array_2d.GetLength(1); j++)
                {
                    if (j == Array_2d.GetLength(1) - 1)
                    {
                        Console.Write("{0}", Array_2d[i, j]);
                        continue;
                    }
                    Console.Write("{0} ", Array_2d[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace Batman
{
    class Program
    {
        static void Main()
        {
            int size = 7; //int.Parse(Console.ReadLine());
            char c = '#'; //char.Parse(Console.ReadLine());
            int field = 3 * size + 1;
            char space = ' ';
            int mid = size / 2;

            for (int row = 0; row < field; row++)
            {
                for (int col = 0; col < field; col++)
                {
                    if (row == 0 && col <= size - 1 ||
                        row == 0 && col >= 2 * size ||
                        row - col <= 0 && row <= mid && col <= size - 1 ||
                        row + col <= field - 1 && row <= mid && col >= 2 * size ||
                        row == size / 2 && col >= size / 3 + 1 && col <= field - mid - 1 ||
                        row == mid - 1 && col == size + (mid / 2) + 1 ||
                        row == mid - 1 && col == field - size - mid - 1 ||
                        size / 2 <= row && row <= size - mid && size / mid + 1 <= col && col <= field - mid - 1 ||
                        col - row == size / 2 && row <= size ||
                        col + row <= 2 * size + mid && size - mid <= row && row <= field - 2 * size - 1)
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write(space);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

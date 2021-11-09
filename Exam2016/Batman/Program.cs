using System;

namespace Batman
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int field = 3 * size + 1;
            char space = ' ';
            int mid = size / 2;

            for (int row = 0; row < field; row++)
            {
                for (int col = 0; col < field; col++)
                {
                    if (row == 0 && col <= size - 1 ||
                        row == 0 && col >= 2 * size && col < field - 1 ||
                        row - col <= 0 && row <= mid && col <= size - 1 ||
                        row + col <= field - 2 && row <= mid && col >= 2 * size ||
                        row == mid - 1 && col == size + (mid - 1) ||
                        row == mid - 1 && col == size + mid + 1 ||
                        row >= mid && row <= mid + mid - 2 && size / 2 <= col && col <= field - mid - 2 ||
                        row >= 2 * mid - 1 && row < 3 * mid - 1 && col - row >= 3 && col + row <= 2 * size + (size - 4))
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

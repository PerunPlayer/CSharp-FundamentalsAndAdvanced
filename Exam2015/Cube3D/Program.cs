using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int field = N * 2 - 1;
        char colon = ':';
        char vertical = '|';
        char bottom = '-';
        char space = ' ';
        int mid = N - 1;

        for (int row = 0; row < field; row++)
        {
            for (int col = 0; col < field; col++)
            {
                if (row == 0 && col <= mid ||
                    row == N && col <= mid ||
                    row == (field - 1) && col >= mid ||
                    row <= mid && col == 0 ||
                    row <= mid && col == mid ||
                    col - row == mid ||
                    row >= mid && col == (field - 1) ||
                    row - col == mid + 1 ||
                    col - row == 0 && col > mid)
                {
                    Console.Write(colon);
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

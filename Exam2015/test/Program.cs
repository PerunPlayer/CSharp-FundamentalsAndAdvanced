using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
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
                    if (row - col == 0
                        )
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
}

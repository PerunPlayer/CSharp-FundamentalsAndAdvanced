using System;

namespace ScoreBonus
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;

            if (1 <= number && number <= 3)
            {
                result = number * 10;
                Console.WriteLine(result);
            }
            else if (4 <= number && number <= 6)
            {
                result = number * 100;
                Console.WriteLine(result);
            }
            else if (7 <= number && number <= 9)
            {
                result = number * 1000;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}

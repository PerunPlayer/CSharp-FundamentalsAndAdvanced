using System;

namespace Exam2016
{
    class Program
    {
        static void Main()
        {
            int birds = int.Parse(Console.ReadLine());
            double feathers = double.Parse(Console.ReadLine());
            double forEven = 123123123123;
            double forOdd = 317;
            double result = 0;

            double result1 = (feathers / birds);
            if (birds % 2 == 0)
            {
                result = result1 * forEven;
            }
            else
            {
                result = result1 / forOdd;
            }

            Console.WriteLine("{0:F4}", result);
        }
    }
}
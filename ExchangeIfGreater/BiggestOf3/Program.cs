using System;

namespace BiggestOf3
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double max1 = Math.Max(a, b);
            double max = Math.Max(max1, c);

            Console.WriteLine(max);
        }
    }
}

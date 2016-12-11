using System;

namespace BiggestOf5
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(Math.Max(Math.Max(a, b), c), d), e));
        }
    }
}

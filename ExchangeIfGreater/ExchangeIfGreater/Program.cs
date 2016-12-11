using System;

namespace ExchangeIfGreater
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double c = Math.Max(a, b);
            double d = Math.Min(a, b);

            Console.WriteLine("{0} {1}", d, c);
        }
    }
}

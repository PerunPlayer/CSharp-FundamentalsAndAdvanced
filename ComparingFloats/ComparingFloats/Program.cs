using System;


class Program
{
    static void Main()
    {
        double firstDouble = double.Parse(Console.ReadLine());
        double secondDouble = double.Parse(Console.ReadLine());
        double tolerance = 0.000001;

        if (Math.Abs(firstDouble - secondDouble) < tolerance)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

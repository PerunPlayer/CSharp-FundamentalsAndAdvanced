using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1;
        double x2;
        double D = (b * b) - (4 * a * c);

        if (D < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (D == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("{0:F2}", x1);
        }
        else
        {
            x1 = (-b + (Math.Sqrt (D))) / (2.0 * a);
            x2 = (-b - (Math.Sqrt (D))) / (2.0 * a);

            double Max = Math.Max(x1, x2);
            double Min = Math.Min(x1, x2);
            Console.WriteLine("{0:F2}", Min);
            Console.WriteLine("{0:F2}", Max);
        }
    }
}

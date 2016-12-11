using System;

class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * (Math.PI) * radius;
        double area = (Math.PI) * (radius * radius);

        Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
    }
}

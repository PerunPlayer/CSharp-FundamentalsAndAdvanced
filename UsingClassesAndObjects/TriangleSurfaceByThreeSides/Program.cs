using System;

namespace TriangleSurfaceByThreeSides
{
    class Program
    {
        static void Main()
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double side3 = double.Parse(Console.ReadLine());

            double halfperimeter = (side1 + side2 + side3) / 2;
            double surface = Math.Sqrt(halfperimeter * (halfperimeter - side1) * (halfperimeter - side2) * (halfperimeter - side3));

            Console.WriteLine("{0:F2}", surface);
        }
    }
}

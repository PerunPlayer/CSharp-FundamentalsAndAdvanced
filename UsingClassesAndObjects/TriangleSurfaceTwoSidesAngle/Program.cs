using System;

namespace TriangleSurfaceTwoSidesAngle
{
    class Program
    {
        static void Main()
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            double surface = TriangleSurfaceTwoSidesAngle(side1, side2, angle);

            Console.WriteLine("{0:F2}", surface);
        }

        static double TriangleSurfaceTwoSidesAngle(double side1, double side2, double angle)
        {
            double surface = (side1 * side2 * Math.Sin(angle * Math.PI / 180)) / 2;

            return surface;
        }
    }
}

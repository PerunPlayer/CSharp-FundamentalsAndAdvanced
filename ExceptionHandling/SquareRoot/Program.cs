using System;

namespace SquareRoot
{
    class Program
    {
        static void Main()
        {
            try
            {
                double num = double.Parse(Console.ReadLine());

                if (num < 0)
                {
                    throw new FormatException();
                }

                Console.WriteLine("{0:F3}", Math.Sqrt(num));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}

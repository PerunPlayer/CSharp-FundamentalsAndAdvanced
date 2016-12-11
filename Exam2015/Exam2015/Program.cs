using System;


class Program
{
    static void Main()
    {
        //input
        double realm = 400;
        double number = double.Parse(Console.ReadLine());
        double sheet = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double result = 0;

        //logic
        result = ((number * sheet) / realm) * price;

        //result
        Console.WriteLine("{0:F3}", result);
    }
}

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double number1 = 0;
        double number2 = 1;

        if (n == 1)
        {
            Console.WriteLine("0");
        }
        else if (n == 2)
        {
            Console.WriteLine("0, 1");
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(i < n - 1 ? "{0}, " : "{0}", number1);
            number1 += number2;
            number2 = number1 - number2;
        }
    }
}
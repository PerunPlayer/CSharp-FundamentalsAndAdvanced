using System;

class Program
{
    static void Main()
    {
        string format = Console.ReadLine();

        switch (format)
        {
            case "integer":
                {
                    int value = int.Parse(Console.ReadLine());
                    Console.WriteLine(value + 1);
                    break;
                }
            case "real":
                {
                    double value = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", (value + 1));
                    break;
                }
            case "text":
                {
                    string nqkakavtekst = Console.ReadLine();
                    Console.WriteLine("{0} - mazno kazano", nqkakavtekst);
                    break;
                }
            default:
                break;
        }
    }
}

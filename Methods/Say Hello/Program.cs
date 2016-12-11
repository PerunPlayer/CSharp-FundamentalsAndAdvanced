using System;

namespace Say_Hello
{
    class Program
    {
        static string Name(string name)
        {
            string hello = string.Format("Hello, {0}!", name);
            return hello;
        }
        static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine(Name(name));
        }
    }
}

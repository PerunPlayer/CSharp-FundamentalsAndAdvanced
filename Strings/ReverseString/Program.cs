using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();

            StringBuilder strb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                strb.Append(str[i]);
            }
            strb.ToString();

            Console.WriteLine(strb);
        }
    }
}

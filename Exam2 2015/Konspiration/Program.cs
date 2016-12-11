using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konspiration
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var lines = new string[n];
            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                if (lines[i].Contains(" static "))
                {
                    var name = lines[i].Split(new[] { ' ', '(' } StringSplitOptions.RemoveEmptyEntries);

                    i += 2;
                    var openBrackets = 1;

                    while (openBrackets > 0)
                    {
                        var splitByRoundBr = lines[i].Split
                    }
                }
            }
        }
    }
}

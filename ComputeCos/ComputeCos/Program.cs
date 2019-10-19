using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeCos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.15; //input variable
            double epsilon = 0.0001; // accuracy of computations
            int counter = 1;

            double sum;
            double term;
            short sign;

            term = 1;
            sum = term;
            sign = (short)-1;

            do
            {
                term = sign * term * x * x / (2 * counter * (2 * counter - 1));
                sum += term;

                //next iteration
                counter++;
                sign = (short)-sign;
                term = term >= 0 ? term : -term;
            } while (term > epsilon);

            Console.WriteLine("Accuracy: {0}", epsilon);
            Console.WriteLine("Aproximate cos({0}) = {1}", x, sum);
            Console.WriteLine("Aproximate cos({0}) = {1}", x, Math.Cos(x));

        }
    }
}

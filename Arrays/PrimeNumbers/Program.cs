using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main()
        {
            long N = long.Parse(Console.ReadLine());

            bool[] primes = new bool[N + 1];
            
            for (int i = 2; i < Math.Sqrt(primes.Length); i++)
            {
                if (primes[i] == false)
                {
                    for (int j = i * i; j < primes.Length; j += i)
                    {
                        primes[j] = true;
                    }
                }
            }

            for (int i = primes.Length - 1; i >= 2; i--)
            {
                if (!primes[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}

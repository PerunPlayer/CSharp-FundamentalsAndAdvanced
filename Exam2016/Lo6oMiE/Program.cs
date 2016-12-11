using System;


namespace Busses
{
    class Program
    {
        static void Main()
        {
            int numberOfBusses = int.Parse(Console.ReadLine());
            int minSpeed = 0;
            int group = 0;
            int lastspeed = 0;

            for (int i = 0; i < numberOfBusses; i++)
            {
                int speed = int.Parse(Console.ReadLine());
                if (speed <= minSpeed)
                {
                    group++;
                }
                else
                {
                    continue;
                }
                lastspeed = speed;
                minSpeed = Math.Min(lastspeed, minSpeed);
               
            }
            Console.WriteLine(group);
        }
    }
}
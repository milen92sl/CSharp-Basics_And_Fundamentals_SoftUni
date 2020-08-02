using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            double halfInitialPower = power / 2 ;
            int pokes = 0;

            while (power >= distance)
            {
                power -= distance;
                pokes++;
                if (power == halfInitialPower)
                {
                    if (exhaustionFactor != 0)
                    {
                        power /= exhaustionFactor;
                    }
                    
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(pokes);


        }

    }
}

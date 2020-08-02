using System;

namespace _04._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (Input != "stop")
            {
                int current = int.Parse(Input);
                if (current < 0)
                {
                    Console.WriteLine("Number is negative.");
                    Input = Console.ReadLine();
                    continue;

                }
                bool isNonPrime = false;

                int m = current / 2;
                for (int i = 2; i <= m ; i++)
                {
                    if (current % i == 0 )
                    {
                        isNonPrime = true;
                        break;
                    }
                }
                if (isNonPrime)
                {
                    sumNonPrime += current;

                }
                else
                {
                    sumPrime += current;
                }
                Input = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}

using System;

namespace _04._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int depositCount = int.Parse(Console.ReadLine());
            int currentCount = 0;
            double Total = 0;

            while (currentCount < depositCount)
            {
                double deposit = double.Parse(Console.ReadLine());

                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;

                }

                Console.WriteLine($"Increase: {deposit:f2}");
                

                Total += deposit;
                currentCount++;
            }

            Console.WriteLine($"Total: {Total:f2}");
        }
    }
}

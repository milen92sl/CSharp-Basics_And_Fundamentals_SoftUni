using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string toyName = Console.ReadLine();

            while (toyName != "Stop")
            {
                int toyPrice = 0;

                for (int i = 0; i < toyName.Length; i++)
                {
                    toyPrice += (int)toyName[i];
                }
                if (budget >= toyPrice)
                {
                    Console.WriteLine("Item successfully purchased!");
                    budget -= toyPrice;

                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    return;
                }
                toyName = Console.ReadLine();
            }
            Console.WriteLine($"Money left: {budget}");
        }
    }
}

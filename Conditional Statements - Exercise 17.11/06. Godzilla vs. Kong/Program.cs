using System;

namespace GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int stats = int.Parse(Console.ReadLine());
            double pricePerStat = double.Parse(Console.ReadLine());

            double decor = 0.10 * budget;
            if (stats > 150)
            {
                pricePerStat = pricePerStat - 0.10 * pricePerStat;

            }
            double priceClothes = stats * pricePerStat;
            double expences = decor + priceClothes;
            if (expences > budget)
            {
                double needMoney = expences - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }
            else
            {
                double leftmoney = budget - expences;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftmoney:f2} leva left.");
            }
        }
    }
}
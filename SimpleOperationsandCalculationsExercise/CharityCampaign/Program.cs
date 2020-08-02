using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfWaffles = int.Parse(Console.ReadLine());
            int numOfPancakes = int.Parse(Console.ReadLine());

            int cakesProfit = numOfCakes * 45;
            double wafflesProfit = numOfWaffles * 5.80;
            double pancakesProfit = numOfPancakes * 3.20;

            double totalProfitFor1Day = (cakesProfit + wafflesProfit + pancakesProfit) * bakers;
            double total = days * totalProfitFor1Day;
            total = total - total * 1 / 8;

            Console.WriteLine($"{total:F2}");
        }
    }
}

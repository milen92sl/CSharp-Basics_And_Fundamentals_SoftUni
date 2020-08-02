using System;

namespace _08ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripCost = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int TeddyBearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int Trucks = int.Parse(Console.ReadLine());

            double puzzleTotalPrice = puzzleCount * 2.6;
            double dollTotalPrice = dollCount * 3;
            double TeddyBearsTotalPrice = TeddyBearsCount * 4.1;
            double minionsTotalPrice = minionsCount * 8.2;
            double TrucksTotalPrice = Trucks * 2;

            int AllCounts = puzzleCount + dollCount + TeddyBearsCount + minionsCount + Trucks;
            double TOtalPrice = puzzleTotalPrice + dollTotalPrice + TeddyBearsTotalPrice + minionsTotalPrice + TrucksTotalPrice;

            if (AllCounts >= 50)
            {
                double discount = TOtalPrice * 0.25;
                TOtalPrice = TOtalPrice - discount;

            }

            double taxPaynment = TOtalPrice * 0.1;
            TOtalPrice = TOtalPrice - taxPaynment;

            if (TOtalPrice >= tripCost)
            {
                double difference = TOtalPrice - tripCost;
                Console.WriteLine($"Yes! { difference:F2} lv left.");
            }
            else
            {
                double difference = tripCost - TOtalPrice;
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }

        }
    }
}

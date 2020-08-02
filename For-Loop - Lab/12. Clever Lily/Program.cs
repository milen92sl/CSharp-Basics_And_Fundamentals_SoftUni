using System;

namespace _12._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfLaundry = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double savings = 0;
            int moneyPresent = 0;
            for (int i = 1; i <= age ; i++)
            {
                if (i % 2 == 0 )
                {
                    moneyPresent += 10;
                    savings += moneyPresent;
                    savings -= 1;

                }
                else
                {
                    savings += toyPrice;
                }
            }
            if (savings >= priceOfLaundry)
            {
                double remaining = savings - priceOfLaundry;
                Console.WriteLine($"Yes! {remaining:f2}");
            }
            else
            {
                double remaining = priceOfLaundry - savings;
                Console.WriteLine($"No! {remaining:f2}");
            }
        }
    }
}

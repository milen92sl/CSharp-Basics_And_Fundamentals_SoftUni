using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneySaved= double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int totalDays = 0;

            while (moneySaved < moneyNeeded)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                totalDays++;

                if (action == "spend")
                {
                    spendCounter++;
                    if (spendCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{totalDays}");
                        break;
                    }
                    if (money > moneySaved)
                    {    
                        moneySaved = 0;
                    }
                    else
                    {
                        moneySaved -= money;
                    }

                }
                else if (action == "save")
                {
                    spendCounter = 0;
                    moneySaved += money;
                }
            }

            if (moneySaved >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
        }

    }
}

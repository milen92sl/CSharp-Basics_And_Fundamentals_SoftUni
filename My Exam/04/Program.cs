using System;

namespace _04._Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string itemName = Console.ReadLine();

            double itemPrice = 0;
            double itemSum = 0;
            bool hasNoMoreBuget = false;
            int itemCounter = 0;
            double lastItemPrice = 0;

            while (itemName != "Finish")
            {
                switch (itemName)
                {
                    case "Star":
                    itemCounter++;
                        itemPrice = 5.69;
                        if (itemCounter % 3 == 0)
                        {
                            itemPrice *= 0.7;
                        }
                        itemSum += itemPrice;
                        break;
                    case "Angel":
                        itemCounter++;
                        itemPrice = 8.49;
                        if (itemCounter % 3 == 0)
                        {
                            itemPrice *= 0.7;
                        }
                        itemSum += itemPrice;
                        break;
                    case "Lights":
                        itemCounter++;
                        itemPrice = 11.2;
                        if (itemCounter % 3 == 0)
                        {
                            itemPrice *= 0.7;
                        }
                        itemSum += itemPrice;
                        break;
                    case "Wreath":
                        itemCounter++;
                        itemPrice = 15.5;
                        if (itemCounter % 3 == 0)
                        {
                            itemPrice *= 0.7;
                        }
                        itemSum += itemPrice;
                        break;
                    case "Candle":
                        itemCounter++;
                        itemPrice = 3.59;
                        if (itemCounter % 3 == 0)
                        {
                            itemPrice *= 0.7;
                        }
                        itemSum += itemPrice;
                        break;
                }
                if (budget < itemSum)
                {
                    hasNoMoreBuget = true;
                    lastItemPrice = itemPrice;
                    break;
                }
                itemName = Console.ReadLine();
            }
            if (hasNoMoreBuget)
            {
                Console.WriteLine($"Not enough money! You need {itemSum - budget:f2}lv more.");
                Console.WriteLine($"{itemCounter - 1} items -> {itemSum- lastItemPrice:f2}lv spent.");
            }
            else
            {
                Console.WriteLine("Congratulations! You bought everything!");
                Console.WriteLine($"{itemCounter} items -> {itemSum - lastItemPrice:f2}lv spent.");
            }
        }
    }
}
using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string TypeSushi = Console.ReadLine();
            string NameOfRestaurant = Console.ReadLine();
            double numberOfPlates = double.Parse(Console.ReadLine());
            char order = char.Parse(Console.ReadLine());

            double totalPrice = 0;
            double currentPrice = 0;
            double priceOf1PlateSushi = 0;

            if (NameOfRestaurant == "Sushi Zone")
            {
                if (TypeSushi == "sashimi")
                {
                    priceOf1PlateSushi = 4.99;
                    
                }
                else if (TypeSushi == "maki")
                {
                    priceOf1PlateSushi = 5.29;
                }
                else if (TypeSushi == "uramaki")
                {
                    priceOf1PlateSushi = 5.99;
                }
                else if (TypeSushi == "temaki")
                {
                    priceOf1PlateSushi = 4.29;
                }
            }
            else if (NameOfRestaurant == "Sushi Time")
            {
                if (TypeSushi == "sashimi")
                {
                    priceOf1PlateSushi = 5.49;
                }
                else if (TypeSushi == "maki")
                {
                    priceOf1PlateSushi = 4.69;
                }
                else if (TypeSushi == "uramaki")
                {
                    priceOf1PlateSushi = 4.49;
                }
                else if (TypeSushi == "temaki")
                {
                    priceOf1PlateSushi = 5.19;
                }
            }
            else if (NameOfRestaurant == "Sushi Bar")
            {
                if (TypeSushi == "sashimi")
                {
                    priceOf1PlateSushi = 5.25;
                }
                else if (TypeSushi == "maki")
                {
                    priceOf1PlateSushi = 5.55;
                }
                else if (TypeSushi == "uramaki")
                {
                    priceOf1PlateSushi = 6.25;
                }
                else if (TypeSushi == "temaki")
                {
                    priceOf1PlateSushi = 4.75;
                }
            }
            else if (NameOfRestaurant == "Asian Pub")
            {
                if (TypeSushi == "sashimi")
                {
                    priceOf1PlateSushi = 4.50;
                }
                else if (TypeSushi == "maki")
                {
                    priceOf1PlateSushi = 4.80;
                }
                else if (TypeSushi == "uramaki")
                {
                    priceOf1PlateSushi = 5.50;
                }
                else if (TypeSushi == "temaki")
                {
                    priceOf1PlateSushi = 5.50;
                }
            }
            else if (NameOfRestaurant != "Sushi Time" || NameOfRestaurant != "Sushi Zone" || NameOfRestaurant != "Shushi Bar" || NameOfRestaurant != "Asian Pub")
            {
                Console.WriteLine($"{NameOfRestaurant} is invalid restaurant!");
                return;
            }

            currentPrice = priceOf1PlateSushi * numberOfPlates;

            
            

            

            if (order == 'Y')
            {
                double PriceForDelivery = currentPrice * 0.2;
                totalPrice = currentPrice + PriceForDelivery;
                totalPrice = Math.Ceiling(totalPrice);
                Console.WriteLine($"Total price: {totalPrice} lv.");
            }
            else
            {
                currentPrice = Math.Ceiling(currentPrice);

                Console.WriteLine($"Total price: {currentPrice} lv.");
            }
        }
    }
}

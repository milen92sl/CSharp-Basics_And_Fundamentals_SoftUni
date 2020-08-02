using System;

namespace _04._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (product == "coffee")
            {
                if (town == "Sofia")
                {
                    price = 0.50;
                }
                else if (town == "Plovdiv")
                {
                    price = 0.40;
                }
                else if (town == "Varna")
                {
                    price = 0.45;
                }
            }
            else if (product == "water")
            {
                if (town == "Sofia")
                {
                    price = 0.80;
                }
                else if (town == "Plovdiv")
                {
                    price = 0.70;
                }
                else if (town == "Varna")
                {
                    price = 0.70;
                }
            }
            else if (product == "beer")
            {
                if (town == "Sofia")
                {
                    price = 1.20;
                }
                else if (town == "Plovdiv")
                {
                    price = 1.15;
                }
                else if (town == "Varna")
                {
                    price = 1.10;
                }
            }
            else if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    price = 1.45;
                }
                else if (town == "Plovdiv")
                {
                    price = 1.30;
                }
                else if (town == "Varna")
                {
                    price = 1.35;
                }
            }
            else if (product == "peanuts")
            {
                if (town == "Sofia")
                {
                    price = 1.60;
                }
                else if (town == "Plovdiv")
                {
                    price = 1.50;
                }
                else if (town == "Varna")
                {
                    price = 1.55;
                }
            }
                Console.WriteLine(price * quantity);
            }
    }
}
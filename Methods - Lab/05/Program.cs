using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double numberOfProduct = double.Parse(Console.ReadLine());
            double result = 0;
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    result = FinalPrice(numberOfProduct, price);
                    break;
                case "water":
                    price = 1.00;
                    result = FinalPrice(numberOfProduct, price);
                    break;
                case "coke":
                    price = 1.40;
                    result = FinalPrice(numberOfProduct, price);
                    break;
                case "snacks":
                    price = 2.00;
                    result = FinalPrice(numberOfProduct, price);
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }

        private static double FinalPrice(double numberOfProduct, double price)
        {
            return numberOfProduct * price;
        }

    }
}

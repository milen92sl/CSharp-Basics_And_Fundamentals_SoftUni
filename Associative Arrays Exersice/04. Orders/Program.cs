using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrices = new Dictionary<string, decimal>();

            Dictionary<string, decimal> productQtys = new Dictionary<string, decimal>();

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = productArgs[0];
                decimal price = decimal.Parse(productArgs[1]);
                int qty = int.Parse(productArgs[2]);
                

                if (!productQtys.ContainsKey(name))
                {
                    productQtys[name] = 0;
                    productPrices[name] = 0;

                }
                productQtys[name] += qty;
                productPrices[name] = price;

            }
            foreach (var kvp in productPrices)
            {
                string name = kvp.Key;
                decimal price = kvp.Value;
                decimal qty = productQtys[name];
                decimal totalPrice = price * qty;

                Console.WriteLine($"{name} -> {totalPrice:f2}");
            }
        }
    }
}

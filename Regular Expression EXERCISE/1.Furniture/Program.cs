using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furnitures = new List<string>();

            decimal totalMoneySpent = 0.0m;
            string pattern =
                @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    long quantity = long.Parse(match.Groups["quantity"].Value);

                    if (quantity!= 0)
                    {
                        furnitures.Add(name);
                        totalMoneySpent += price * quantity;
                    }
                    
                }

            }
            Console.WriteLine("Bought furniture:");
            foreach (var name in furnitures)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"Total money spend: {totalMoneySpent:f2}");
        }
    }
}

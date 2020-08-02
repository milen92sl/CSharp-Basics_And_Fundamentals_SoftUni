using System;

namespace _3._Gaming_store
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double spend = 0;
            string game = string.Empty;

            while (game != "Game Time")
            {
                game = Console.ReadLine();

                double price = 0;

                switch (game)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;

                 
                }
                if (game != "OutFall 4" && game != "CS: OG" && game != "Zplinter Zell" && game != "Honored 2" && game != "RoverWatch" && game != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not found");
                }

                if (price > money)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                money -= price;
                spend += price;
                Console.WriteLine($"Bought {game}");

                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${money:f2}");
        }
    }
}
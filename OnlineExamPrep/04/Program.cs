using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int performerCost = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double totalguests = 0;
            double income = 0;


            while (input != "The restaurant is full")
            {


                int currentGuests = int.Parse(input);
                totalguests += currentGuests;
                input = Console.ReadLine();

                if (currentGuests >= 5)
                {
                    income += currentGuests * 70;

                }
                else
                {
                    income += currentGuests * 100;
                }
            }


            if (income >= performerCost)
            {
                double diff = income - performerCost;
                Console.WriteLine($"You have {totalguests} guests and {diff} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalguests} guests and {income} leva income, but no singer.");
            }


        }
    }
}

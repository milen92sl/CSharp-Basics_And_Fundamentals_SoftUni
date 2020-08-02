using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeOfVacation = "";
            double moneyPaid = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    moneyPaid = budget * 0.30;
                    typeOfVacation = "Camp";
                }
                else if (season == "winter")
                {
                    moneyPaid = budget * 0.70;
                    typeOfVacation = "Hotel";
                }
            }
            else if (budget <= 1000 && budget> 100)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    moneyPaid = budget * 0.40;
                    typeOfVacation = "Camp";
                }
                else if (season == "winter")
                {
                    moneyPaid = budget * 0.80; 
                    typeOfVacation = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                if (season == "summer" || season == "winter")
                {
                    moneyPaid = budget * 0.90;
                    typeOfVacation = "Hotel";
                }
                
                
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} - {moneyPaid:f2}");
        }
    }
}

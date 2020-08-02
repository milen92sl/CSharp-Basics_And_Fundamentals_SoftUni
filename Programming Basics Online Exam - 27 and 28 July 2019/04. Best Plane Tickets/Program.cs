using System;

namespace _04._Best_Plane_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberTicket = Console.ReadLine();
            string currentMinNumberTicket = numberTicket;
            double price = double.Parse(Console.ReadLine());
            double currentMinPrice = price;
            int waitingTimeInMunites = int.Parse(Console.ReadLine());
            int currentMinWaitnigTime = waitingTimeInMunites;

            while (numberTicket != "End")
            {
                numberTicket = Console.ReadLine();
                if (numberTicket == "End")
                {
                    break;
                }
                price = double.Parse(Console.ReadLine());
                waitingTimeInMunites = int.Parse(Console.ReadLine());
                if (waitingTimeInMunites < currentMinWaitnigTime)
                {
                    currentMinNumberTicket = numberTicket;
                    currentMinPrice = price;
                    currentMinWaitnigTime = waitingTimeInMunites;
                }
            }

            int hoursWaiting = currentMinWaitnigTime / 60;
            int minutesWaiting = currentMinWaitnigTime % 60;
            Console.WriteLine($"Ticket found for flight {currentMinNumberTicket} costs {currentMinPrice * 1.96:f2} leva with {hoursWaiting}h {minutesWaiting}m stay");
        }
    }
}

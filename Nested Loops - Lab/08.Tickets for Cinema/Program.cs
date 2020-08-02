using System;

namespace _08.Tickets_for_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int standartTicketCount = 0;
            int studentTicketCount = 0;
            int kidsTicketCount = 0;
            
            int totalTicketCount = 0;
           

            while (movieName != "Finish")
            {

                int seatCount = int.Parse(Console.ReadLine());
                int ticketCount = 0;
                for (int i = 0; i < seatCount; i++)
                {
                    string ticketType = Console.ReadLine();

                    switch (ticketType)
                    {
                        case "standard":
                            standartTicketCount++;
                            ticketCount++;
                            break;
                        case "student":
                            studentTicketCount++;
                            ticketCount++;
                            break;
                        case "kid":
                            kidsTicketCount++;
                            ticketCount++;
                            break;
                        

                    }
                    if (ticketType == "End")
                    {
                        break;
                    }
                }
                double percentFilled = ((double)ticketCount / seatCount) * 100;
                Console.WriteLine($"{movieName} - {percentFilled:f2}% full.");
                totalTicketCount += ticketCount;
                movieName = Console.ReadLine();

            }

            double studentTicketPercentFilled = ((double)studentTicketCount / totalTicketCount) * 100;
            double standartTicketPercentFilled = ((double)standartTicketCount / totalTicketCount) * 100;
            double kidTicketPercentFilled = ((double)kidsTicketCount / totalTicketCount) * 100;
            Console.WriteLine($"Total tickets: {totalTicketCount}");
            Console.WriteLine("{0:f2}% student tickets.", studentTicketPercentFilled);
            Console.WriteLine("{0:f2}% standard tickets.", standartTicketPercentFilled);
            Console.WriteLine("{0:f2}% kids tickets.", kidTicketPercentFilled);

        }
    }
}

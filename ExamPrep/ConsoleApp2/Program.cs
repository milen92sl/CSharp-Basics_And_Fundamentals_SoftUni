using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());
            char withPhoto = char.Parse(Console.ReadLine());
            double ticketprice = 0;

            if (typeTicket == "Standard")
            {
                if (stage == "Quarter final")
                {
                    ticketprice = 55.5;
                }
                else if (stage == "Semi final")
                {
                    ticketprice = 75.88;
                }
                else if (stage == "Final")
                {
                    ticketprice = 110.1;
                }
            }
            else if (typeTicket == "Premium")
            {
                if (stage == "Quarter final")
                {
                    ticketprice = 105.2;
                }
                else if (stage == "Semi final")
                {
                    ticketprice = 125.22;
                }
                else if (stage == "Final")
                {
                    ticketprice = 160.66;
                }
            }
            else if (typeTicket == "VIP")
            {
                if (stage == "Quarter final")
                {
                    ticketprice = 118.9;
                }
                else if (stage == "Semi final")
                {
                    ticketprice = 300.4;
                }
                else if (stage == "Final")
                {
                    ticketprice = 400;
                }
            }

            double totalprice = ticketprice * ticketCount;



            if (totalprice > 2500 && totalprice <= 4000)
            {
                totalprice *= 0.9;
                
                if (withPhoto == 'Y')
                {
                    totalprice += 40 * ticketCount;
                }
                else if (withPhoto != 'Y')
                {
                    totalprice = totalprice * 1;
                } 

            }
            else if (totalprice > 4000)
            {
                totalprice *= 0.75;

            }
            else
            {
                if (withPhoto == 'Y')
                {
                    totalprice += 40 * ticketCount;
                }
                else if (withPhoto != 'Y')
                {
                    totalprice = totalprice * 1;
                }

            }

            Console.WriteLine($"{totalprice:f2}");
        }
    }
}

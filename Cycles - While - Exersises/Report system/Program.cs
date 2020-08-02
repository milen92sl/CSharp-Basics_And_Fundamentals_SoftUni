using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumNeeded = double.Parse(Console.ReadLine());

            double totalCurrentSum = 0;
            double currentSumByCard = 0;
            double currentSumCash = 0;
            int numOfPayment = 0;
            int numOfPaymentCash = 0;
            int numOfPaymentCard = 0;

            string payment = Console.ReadLine();

            while (payment != "End")
            {
                double product = double.Parse(payment);
                numOfPayment++;


                if (numOfPayment % 2 != 0)
                {
                    if (product > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        currentSumCash += product;
                        numOfPaymentCard++;
                    }
                }
                else
                {
                    if (product < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        currentSumByCard += product;
                        numOfPaymentCash++;
                    }
                }
                totalCurrentSum = currentSumByCard + currentSumCash;

                if (sumNeeded <= totalCurrentSum)
                {
                    Console.WriteLine($"Average CS: {currentSumCash / numOfPaymentCash:f2}");
                    Console.WriteLine($"Average CC: {currentSumByCard / numOfPaymentCard:f2}");
                    break;
                }
                payment = Console.ReadLine();

            }
            if (payment == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
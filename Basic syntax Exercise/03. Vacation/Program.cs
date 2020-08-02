using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            decimal pricePerPerson = 0;
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 8.45M;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.8M;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46M;
                            break;

                    } 
                    break;

                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 10.9M;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.6M;
                            break;
                        case "Sunday":
                            pricePerPerson = 16M;
                            break;

                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 15M;
                            break;
                        case "Saturday":
                            pricePerPerson = 20M;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.5M;
                            break;

                    }
                    break;
            }
            decimal totalPrice = pricePerPerson * peopleCount;

            if (type == "Students" && peopleCount >= 30)
            {
                totalPrice *= 0.85M;
            }
            else if (type == "Business" && peopleCount >= 100)
            {
                totalPrice -= pricePerPerson * 10;
            }
            else if (type == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                totalPrice *= 0.95M;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }

    }
}

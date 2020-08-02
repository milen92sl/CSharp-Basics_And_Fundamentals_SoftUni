using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;

            if (type == "Roses")
            {
                if (numberFlowers <= 80)
                {
                    price = numberFlowers * 5.00;
                }
                else
                {
                    discount = 0.10 * (numberFlowers * 5);
                    price = numberFlowers * 5 - discount;
                }
            }

            else if (type == "Dahlias")
            {
                if (numberFlowers <= 90)
                {
                    price = numberFlowers * 3.80;
                }
                else
                {
                    discount = 0.15 * (numberFlowers * 3.80);
                    price = numberFlowers * 3.80 - discount;
                }
            }

            else if (type == "Tulips")
            {
                if (numberFlowers <= 80)
                {
                    price = numberFlowers * 2.80;
                }
                else
                {
                    discount = 0.15 * (numberFlowers * 2.80);
                    price = (numberFlowers * 2.80) - discount;
                }
            }

            else if (type == "Narcissus")
            {
                if (numberFlowers >= 120)
                {
                    price = numberFlowers * 3.00;
                }
                else
                {
                    discount = 0.15 * (numberFlowers * 3.00);
                    price = numberFlowers * 3.00 + discount;
                }
            }

            else if (type == "Gladiolus")
            {
                if (numberFlowers >= 80)
                {
                    price = numberFlowers * 2.50;
                }
                else
                {
                    discount = 0.20 * (numberFlowers * 2.50);
                    price = numberFlowers * 2.50 + discount;
                }
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {type} and {budget - price:F2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
            }
        }
    }
}


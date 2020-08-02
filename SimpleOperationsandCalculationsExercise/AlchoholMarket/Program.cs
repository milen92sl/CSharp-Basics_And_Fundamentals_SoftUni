using System;

namespace AlchoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Цена на уискито в лева – реално число в интервала [0.00 … 10000.00]
            //2.Количество на бирата в литри – реално число в интервала[0.00 … 1 0000.00]
            //3.Количество на виното в литри – реално число в интервала[0.00 … 10000.00]
            //4.Количество на ракията в литри – реално число в интервала[0.00 … 10000.00]
            //5.Количество на уискито в литри – реално число в интервала[0.00 … 10000.00]

            double priceOfWhiskey = double.Parse(Console.ReadLine());
            double amountOfBeer = double.Parse(Console.ReadLine());
            double amountOfWine = double.Parse(Console.ReadLine());
            double amountOfRakia = double.Parse(Console.ReadLine());
            double amountOfWhiskey = double.Parse(Console.ReadLine());

            //•	цената на ракията е на половина по-ниска от тази на уискито;
            //	цената на виното е с 40 % по - ниска от цената на ракията;
            //•	цената на бирата е с 80 % по - ниска от цената на ракията


            double priceOfRakia = priceOfWhiskey / 2;
            double priceOfWine = priceOfRakia -(0.4*priceOfRakia);
            double priceOfBeer = priceOfRakia - (0.8 * priceOfRakia);
            double sumOfRakia = amountOfRakia * priceOfRakia;
            double sumOfWine = amountOfWine * priceOfWine;
            double sumOfBeer = priceOfBeer * amountOfBeer;
            double sumOfWhiskey = amountOfWhiskey * priceOfWhiskey;
            double total = sumOfRakia + sumOfWhiskey + sumOfBeer + sumOfWine;


            Console.WriteLine($"{total:F2}");
            
        }
    }
}

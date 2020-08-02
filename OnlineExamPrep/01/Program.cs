using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFoodFor1day = double.Parse(Console.ReadLine());
            double moneyForSouvenirsFor1day = double.Parse(Console.ReadLine());
            double moneyForHotelFor1day = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            double alltheway = 420;
            double GasolineNeeded = alltheway / 100 * 7;
            double GasolinePrice = GasolineNeeded * 1.85;
            double sumForAllDays = 3 * moneyForFoodFor1day + 3 * moneyForSouvenirsFor1day;
            double firstDayInHotel = moneyForHotelFor1day * 0.9;
            double secondDayInHotel = moneyForHotelFor1day * 0.85;
            double thirdDayInHotel = moneyForHotelFor1day * 0.8;

            totalPrice = GasolinePrice + sumForAllDays + firstDayInHotel + secondDayInHotel + thirdDayInHotel;

            Console.WriteLine($"Money needed: {totalPrice:f2}");
        }
    }
}

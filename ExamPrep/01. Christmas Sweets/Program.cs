using System;

namespace _01._Christmas_Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double baklavaPriceKG = double.Parse(Console.ReadLine());
            double muffinPriceKG = double.Parse(Console.ReadLine());
            double KGShtolen = double.Parse(Console.ReadLine());
            double candiesKG = double.Parse(Console.ReadLine());
            double biscuitsKG = double.Parse(Console.ReadLine());

            
            double priceShtolenKG = KGShtolen * (1.6 * baklavaPriceKG);
            double biscuitsPrice = biscuitsKG * 7.50;
            double sumCandies = candiesKG * (1.8 * muffinPriceKG);
            double totalPrice = priceShtolenKG + sumCandies + biscuitsPrice;

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}

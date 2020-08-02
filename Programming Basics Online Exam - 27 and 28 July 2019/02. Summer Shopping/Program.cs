using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budged = int.Parse(Console.ReadLine());
            double priceOfTowel = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());
            percentDiscount = percentDiscount * 0.01;
            double priceOfUmbrella = 2 * priceOfTowel / 3 ;
            double priceOfflipflops = 0.75 * (priceOfUmbrella);
            double priceOfBeackBackpack = (priceOfTowel + (priceOfflipflops)) / 3;
            double totalPrice = priceOfTowel + priceOfUmbrella + priceOfflipflops + (priceOfBeackBackpack);

            double priceWithDiscount = (totalPrice) * percentDiscount;
            double totalSumAfter = (totalPrice) - (priceWithDiscount);

            double budgedAftePaid = budged - totalSumAfter;

            if (budged >= totalSumAfter)
            {
                Console.WriteLine($"Annie's sum is {totalSumAfter:f2} lv. She has {budgedAftePaid:f2} lv. left.");
            }
            else
            {
                budgedAftePaid = Math.Abs(budgedAftePaid);
                Console.WriteLine($"Annie's sum is {totalSumAfter:f2} lv. She needs {budgedAftePaid:f2} lv. more.");
            }
        }
    }
}

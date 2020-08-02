using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.  Кв. метри, които ще бъдат озеленени – реално число в интервала [0.00… 10000.00]

            double yardgreening = double.Parse(Console.ReadLine());
            double totalprice = yardgreening * 7.61;
            double discountPrice = 0.18 * totalprice;
            double finalPrice = totalprice - discountPrice; 

            Console.WriteLine($"The final price is: {finalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discountPrice:f2} lv.");
        }
    }
}

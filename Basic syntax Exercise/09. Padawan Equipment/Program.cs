using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double LightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalLightsabersPrice = LightsabersPrice * Math.Ceiling(studentsCount * 1.1);
            double totalRobesPrice = robesPrice * studentsCount;
            double totalBeltsPrice = beltsPrice * studentsCount;
            
            
            int freeBeltsCount = studentsCount / 6;
            double freeBeltsPrice = freeBeltsCount * beltsPrice;
            totalBeltsPrice -= freeBeltsPrice;

            double totalPrice = totalLightsabersPrice + totalBeltsPrice + totalRobesPrice;


            if (amountOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                double neededMoney = totalPrice - amountOfMoney;
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine());
            int fantasyBooks = int.Parse(Console.ReadLine());
            int HorrorBooks = int.Parse(Console.ReadLine());
            int romaticBooks = int.Parse(Console.ReadLine());

            double income = fantasyBooks * 14.9 + HorrorBooks * 9.8 + romaticBooks * 4.3;
            income *= 0.8;

            if (income >= target)
            {
                double profit = income - target;
                double pay = Math.Floor(profit * 0.1);
                income -= pay;
                Console.WriteLine($"{income:f2} leva donated.");
                Console.WriteLine($"Sellers will receive {pay} leva.");
            }
            else
            {
                double diff = target - income;
                Console.WriteLine($"{diff:f2} money needed.");
            }
        }
    }
}

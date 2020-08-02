using System;

namespace FishTANK
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Дължина в см – цяло число в интервала [10 … 500]
            //2.Широчина в см – цяло число в интервала[10 … 300]
            //3.Височина в см – цяло число в интервала[10… 200]
            //4.Процент – реално число в интервала[0.000 … 100.000]
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double percentInput = double.Parse(Console.ReadLine());

            double percent = percentInput * 0.01; // заетия процент 

            double totalVolume = (length * width * height) / 1000.0; // см във дм3
            double usedVolume = totalVolume * percent; // използвам обем 
            double result = totalVolume - usedVolume; 

            Console.WriteLine($"{result:F3}");
        }
    }
}

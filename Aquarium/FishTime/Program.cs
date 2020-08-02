using System;

namespace FishTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double percentInput = double.Parse(Console.ReadLine());
            double percent = percentInput * 0.01;
            double totalVolume = (length * width * height) / 1000.0;
            double usedVolume = totalVolume * percent;
            double result = totalVolume - usedVolume;

            Console.WriteLine("{0:F3}", result);
        }
    }
}

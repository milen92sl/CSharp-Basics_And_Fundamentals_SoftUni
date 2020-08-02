using System;

namespace _07.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double bestVolume = 0;
            string bestModel = string.Empty;
            for (int i = 0; i < count; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > bestVolume)
                {
                    bestVolume = volume;
                    bestModel = model;
                }
            }
            Console.WriteLine(bestModel);
        }
    }
}

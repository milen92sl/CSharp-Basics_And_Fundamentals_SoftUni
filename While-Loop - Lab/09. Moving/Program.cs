using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int totalVolume = width * lenght * height;

            string inPut = Console.ReadLine();
            int totalBoxCount = 0;



            while (inPut != "Done")
            {

                int currentboxes = int.Parse(inPut);
                totalBoxCount += currentboxes;

                if (totalBoxCount > totalVolume)
                {
                    break;
                }

                inPut = Console.ReadLine();
            }

            if (totalBoxCount > totalVolume)
            {
                int neededSpace = totalBoxCount - totalVolume;
                Console.WriteLine($"No more free space! You need {neededSpace} Cubic meters more.");
            }
            else
            {
                int freeSpace = totalVolume - totalBoxCount;
                Console.WriteLine($"{freeSpace} Cubic meters left.");

            }
        }
    }
}

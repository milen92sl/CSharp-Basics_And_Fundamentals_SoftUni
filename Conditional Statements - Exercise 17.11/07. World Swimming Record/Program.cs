using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecPerMeter = double.Parse(Console.ReadLine());

            double swimingSecounds = distanceInMeters * timeInSecPerMeter;
            double delay = Math.Floor(distanceInMeters / 15);
            double delaySwimming = delay * 12.5;
            double ivanTime = swimingSecounds + delaySwimming;


            if (recordInSec <= ivanTime)
            {
                double needetSeconds = Math.Abs(ivanTime - recordInSec);
                Console.WriteLine($"No, he failed! He was {needetSeconds:f2} seconds slower.");
            }
            else if (recordInSec > ivanTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:f2} seconds.");
            }
        }
    }
}
using System;

namespace PetsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Броят на кучетата – цяло число в интервала [0… 100]
            //2.Броят на останалите животни - цяло число в интервала[0… 100]

            double numberOfDogs = double.Parse(Console.ReadLine());
            double numberOfAnimals = double.Parse(Console.ReadLine());
            numberOfDogs = numberOfDogs * 2.50;
            numberOfAnimals = numberOfAnimals * 4;

            double moneyneeded = numberOfDogs + numberOfAnimals;
            Console.WriteLine($"{moneyneeded:F2} lv.");



        }
    }
}

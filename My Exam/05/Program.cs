using System;

namespace petsFOOD
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            double quantityFood = double.Parse(Console.ReadLine());

            double nagradaCounter = 0;
            double dogCounter = 0;
            double catCounter = 0;


            for (int i = 1; i <= numOfDays; i++)
            {
                int quantityFoodDog = int.Parse(Console.ReadLine());
                dogCounter += quantityFoodDog;
                int quantityFoodCat = int.Parse(Console.ReadLine());

                catCounter += quantityFoodCat;

                if (i % 3 == 0)
                {
                    double nagrada = (quantityFoodCat + quantityFoodDog) * 0.1;
                    nagrada = Math.Ceiling(nagrada);

                    nagradaCounter += nagrada;
                }
            }
            double totalFood = dogCounter + catCounter;
            double percentFood = totalFood / quantityFood * 100;

            double percentDog = dogCounter / totalFood * 100;
            double percentCat = catCounter / totalFood * 100;

            Console.WriteLine($"Total eaten biscuits: {nagradaCounter}gr.");
            Console.WriteLine($"{percentFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentDog:F2}% eaten from the dog.");
            Console.WriteLine($"{percentCat:F2}% eaten from the cat.");

        }
    }
}
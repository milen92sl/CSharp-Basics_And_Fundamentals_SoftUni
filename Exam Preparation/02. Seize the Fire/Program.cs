using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fires = Console.ReadLine()
                   .Split("#");
            List<int> fireCells = new List<int>();

            int water = int.Parse(Console.ReadLine());

            double effort = 0;

            for (int i = 0; i < fires.Length; i++)
            {
                string[] fireArgs = fires[i]
                    .Split(" = ");

                string type = fireArgs[0];
                int fireValue = int.Parse(fireArgs[1]);

                water -= fireValue;
                bool isCellValid = IsCellValid(type, fireValue);

                if (isCellValid && water >= fireValue)
                {
                    effort += fireValue * 0.25;
                    water -= fireValue;
                    fireCells.Add(fireValue);
                }
            }
            int totalFire = fireCells.Sum();

            Console.WriteLine($"Cells:");

            foreach (var cell in fireCells)
            {
                Console.WriteLine($" - {cell}");
            }


            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }

        private static bool IsCellValid(string type, int fireValue)
        {
            if (type == "High")
            {
                return fireValue >= 81 && fireValue <= 125;
            }
            if (type == "Medium")
            {
                return fireValue >= 51 && fireValue <= 80;
            }
            if (type == "Low")
            {
                return fireValue >= 1 && fireValue <= 50;
            }
            return false;
        }
    }
}

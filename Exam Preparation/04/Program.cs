using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int productionPerDay = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());
            int productionToOtherFactory = int.Parse(Console.ReadLine());

            int productionFor30days = 0;

            for (int i = 1; i <= 30; i++)
            {

                if (i % 3 == 0)
                {
                    if (productionPerDay != 1)
                    {
                        productionFor30days += (int)(0.75 * productionPerDay * employees);
                    }
                    
                }
                else
                {
                    productionFor30days += productionPerDay * employees;
                }

            }
            int diff = productionFor30days - productionToOtherFactory;
            decimal percentsDiff = diff /(decimal)productionToOtherFactory * 100;

            

            Console.WriteLine($"You have produced {productionFor30days} biscuits for the past month.");

            if (productionFor30days > productionToOtherFactory)
            {
                Console.WriteLine($"You produce {percentsDiff:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {Math.Abs(percentsDiff):f2} percent less biscuits.");
            }

        }
    }
}

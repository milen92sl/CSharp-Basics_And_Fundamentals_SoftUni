using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double daylyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double additionalPlunder = 0;
            double allPlunder = 0;
            double losedPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                allPlunder += daylyPlunder;

                if (i % 3 == 0)
                {
                    additionalPlunder = daylyPlunder* 0.5;

                    allPlunder += additionalPlunder;
                }
                if (i % 5 == 0)
                {
                    losedPlunder = allPlunder * 0.3;
                    allPlunder -= losedPlunder;
                }
            }
            if (allPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {allPlunder:f2} plunder gained.");
            }
            else
            {
                double pecentagePlunder = allPlunder/ expectedPlunder * 100;

                Console.WriteLine($"Collected only {pecentagePlunder:f2}% of the plunder.");
            }
            
        }
    }
}

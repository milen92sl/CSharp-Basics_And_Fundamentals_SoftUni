using System;

namespace _03._Luggage_Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            bool ticket = bool.Parse(Console.ReadLine());

            double volumeSuitcase = width * height * depth;
            int tax = 0;

            if (volumeSuitcase > 50 && volumeSuitcase <= 100)
            {
                if (ticket == true)
                {
                    tax = 0;
                }
                else
                {
                    tax = 25;
                }
            }
            if (volumeSuitcase > 100 && volumeSuitcase <= 200)
            {
                if (ticket == true)
                {
                    tax = 10;
                }
                else
                {
                    tax = 50;
                }
            }
            if (volumeSuitcase > 200 && volumeSuitcase <= 300)
            {
                if (ticket == true)
                {
                    tax = 20;
                }
                else
                {
                    tax = 100;

                }
            }
            Console.WriteLine($"Luggage tax: {tax:f2}");
        }
    }

}

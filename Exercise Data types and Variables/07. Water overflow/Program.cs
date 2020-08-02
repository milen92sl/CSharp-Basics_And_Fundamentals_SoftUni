using System;

namespace _07._Water_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxcapacity = 255;
            int Capacity = 0;

            for (int i = 0; i < n; i++)
            {
                int Litters = int.Parse(Console.ReadLine());
                if (Capacity + Litters <= maxcapacity)
                {
                    Capacity += Litters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(Capacity);
        }
    }
}

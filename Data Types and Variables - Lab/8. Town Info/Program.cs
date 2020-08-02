using System;

namespace _8._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            decimal population = decimal.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}

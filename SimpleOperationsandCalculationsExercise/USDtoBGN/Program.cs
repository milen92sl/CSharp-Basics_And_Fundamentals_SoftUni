using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            USD = USD * 1.79549;
            Console.WriteLine($"{USD:F2}");

        }
    }
}

using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double rounded = Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", numbers[i], rounded);
            }
        }
    }
}
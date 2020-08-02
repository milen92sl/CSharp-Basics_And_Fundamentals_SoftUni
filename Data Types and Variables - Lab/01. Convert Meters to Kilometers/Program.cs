using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            double ConvertedNumber = number * 0.001;

            Console.WriteLine($"{ConvertedNumber:f2}");
        }
    }
}

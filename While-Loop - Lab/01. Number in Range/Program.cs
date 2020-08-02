using System;

namespace _01._Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isinValidNumber = number <= 1 || 100 < number;
            while (isinValidNumber)
            {
                number = int.Parse(Console.ReadLine());
                isinValidNumber = number < 1 || 100 < number;
            }
            {
                Console.WriteLine("The number is: " + number);
            }
           

        }
    }
}

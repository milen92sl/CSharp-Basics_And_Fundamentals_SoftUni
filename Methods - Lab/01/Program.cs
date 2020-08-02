using System;
using System.Globalization;
using System.Linq;
namespace _01
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }
        
        static void PrintSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");

            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
    
    
}


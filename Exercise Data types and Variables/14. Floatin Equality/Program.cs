using System;

namespace _14._Floatin_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double diff = 0.0;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            diff = a - b;
            if (Math.Abs(diff) < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
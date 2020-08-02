using System;

namespace Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double averageSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
                averageSum = sum / n;
            }
            Console.WriteLine($"{averageSum:f2}");
        }
    }
}

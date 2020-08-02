using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;



            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1++;
                }
                else if (number <=399)
                {
                    p2++;
                }
                else if (number <= 599)
                {
                    p3++;
                }
                else if (number <= 799)
                {
                    p4++;
                }
                else 
                {
                    p5++;
                }
            }
            Console.WriteLine($"{p1 * 1.0 / n * 100:f2}%");
            Console.WriteLine($"{p2 * 1.0 / n * 100:f2}%");
            Console.WriteLine($"{p3 * 1.0 / n * 100:f2}%");
            Console.WriteLine($"{p4 * 1.0 / n * 100:f2}%");
            Console.WriteLine($"{p5 * 1.0 / n * 100:f2}%");
        }
    }
}

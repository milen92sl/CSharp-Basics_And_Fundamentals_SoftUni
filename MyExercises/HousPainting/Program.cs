using System;

namespace HousPainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWall = x * y;
            double window = 1.5 * 1.5;
            double AllSides = 2 * sideWall - 2 * window;
            double backWall = x * x;
            double entry = 1.2 * 2;
            double backAndFront = 2 * backWall - entry;
            double allPloshtSides = AllSides + backAndFront;
            double GreenPaint = allPloshtSides / 3.4;
            //Pokriv 
            double pravoagalniciNaPokriva = 2 * (x * y);
            double triagalniciNaPokriva = 2 * (x * h / 2);
            double AllPloshtPokriv = pravoagalniciNaPokriva + triagalniciNaPokriva;

            double RedPaint = AllPloshtPokriv / 4.3;

            Console.WriteLine($"{GreenPaint:F2}");
            Console.WriteLine($"{RedPaint:F2}");
        }
    }
}

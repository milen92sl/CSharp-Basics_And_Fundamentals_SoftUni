using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.L – дължина на залата в метри – реално число в интервала  [10.00 … 100.00]
            //2.W – ширина на залата в метри – реално число в интервала[10.00 … 100.00]
            //3.А – страна на гардероба в метри – реално число в интервала[2.00… 20.00]

            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double hallArea = L*W;
            double wardrobeArea = Math.Pow(A,2);
            double benchArea = hallArea / 10;
            
            double freeSpace = hallArea - wardrobeArea - benchArea;
            freeSpace = freeSpace * 10000;
            double numberOfDancers = Math.Floor(freeSpace / 7040);

            Console.WriteLine($"{numberOfDancers}");
            


        }
    }
}

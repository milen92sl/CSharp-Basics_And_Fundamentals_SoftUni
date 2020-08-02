using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Брой правоъгълни маси – цяло число в интервала [0...500]
            //Дължина на правоъгълните маси в метри – реално число в интервала[0.00...3.00]
            //Широчина на правоъгълните маси в метри – реално число в интервала[0.00...3.00]

            double numberoftables = double.Parse(Console.ReadLine());
            double lenghtOfTablesInMeters = double.Parse(Console.ReadLine());
            double heightOfTablesInMeters = double.Parse(Console.ReadLine());

            double numberOfpokrivka = numberoftables * (lenghtOfTablesInMeters + (2 * 0.30)) * (heightOfTablesInMeters + (2 * 0.30));
            double numberOfKareta = numberoftables * (lenghtOfTablesInMeters / 2) * (lenghtOfTablesInMeters / 2);

            double priceInUSD = (numberOfpokrivka * 7) + (numberOfKareta * 9);
            double priceInBGN = (priceInUSD * 1.85);

            Console.WriteLine($"{priceInUSD:F2} USD");
            Console.WriteLine($"{priceInBGN:F2} BGN");
        } 
    }
}

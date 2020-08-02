using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            
          
            double broiBaloni = 0;
            double metriPandelka = 0;
            double broiSveshti = 0;
            double broiCvetq = 0;            
            double broi = 0;
            string vidStoka = string.Empty;

            double izharcheniPari = 0;

            while (vidStoka != "stop")
            {
                vidStoka = Console.ReadLine();
                broi = double.Parse(Console.ReadLine());

                double cena = 0;
                

                if (vidStoka == "balloons")
                {
                    cena = broi * 0.1;
                    budget = budget - cena;
                    broiBaloni = broi;
                    izharcheniPari += cena;
                }
                else if (vidStoka == "flowers")
                {
                    cena = broi * 1.5;
                    budget = budget - cena;
                    broiCvetq = broi;
                    izharcheniPari += cena;
                }
                else if (vidStoka == "candles")
                {
                    cena = broi * 0.5;
                    budget = budget - cena;
                    broiSveshti = broi;
                    izharcheniPari += cena;
                }
                else if (vidStoka == "ribbon")
                {
                    cena = broi * 2;
                    budget = budget - cena;
                    metriPandelka = broi;
                    izharcheniPari += cena;
                }

                if (vidStoka == "stop")
                {
                    Console.WriteLine($"Spend money: {izharcheniPari}");
                    Console.WriteLine($"Money left: {budget}");
                    break;
                }

                


                if (budget <= 0)
                {

                    Console.WriteLine("All money is spent!");
                    break;
                }

            }
            Console.WriteLine($"Purchased decoration is {broiBaloni} balloons, {metriPandelka} m ribbon, {broiCvetq} flowers and {broiSveshti} candles.");
        }
    }
}

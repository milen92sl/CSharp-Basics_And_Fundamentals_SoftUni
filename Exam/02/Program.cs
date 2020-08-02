using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double cenaNaSki = double.Parse(Console.ReadLine());
            double cenaNaShteki = double.Parse(Console.ReadLine());

            double cenaNaSkiObuwki = cenaNaSki * 0.4;
            double cenaNaSkiObleklo = cenaNaSki + (cenaNaSki * 0.4);
            double obshtaCena = cenaNaSkiObleklo + cenaNaSki + cenaNaSkiObuwki;

            double ostatyk = 0;

            if (obshtaCena > 800)
            {
                obshtaCena = obshtaCena;
                ostatyk = budget - obshtaCena;
            }
            else if (obshtaCena < 800)
            {
                obshtaCena = obshtaCena + cenaNaShteki;
                ostatyk = budget - obshtaCena;
            }

            if (obshtaCena <= budget)
            {
                Console.WriteLine($"Angel's sum is {obshtaCena:f2} lv. He has {ostatyk:f2} lv. left.");
            }
            else 
            {
                ostatyk = Math.Abs(ostatyk);    

                Console.WriteLine($"Not enough money! You need {ostatyk:f2} leva more!");
            }
          
            
        }
    }
}

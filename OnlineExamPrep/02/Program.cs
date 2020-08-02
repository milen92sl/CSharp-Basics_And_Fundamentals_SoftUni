using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirochina = double.Parse(Console.ReadLine());
            double daljina = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            double srednaVisochinaNaAstronavtite = double.Parse(Console.ReadLine());


            double obemNaRaketata = shirochina * daljina * visochina;
            double obemNa1Staq = (srednaVisochinaNaAstronavtite + 0.40) * 2 * 2;
            double ShteImaMqstoZa = obemNaRaketata / obemNa1Staq;

            double astronavti = Math.Floor(ShteImaMqstoZa);
           

            if (ShteImaMqstoZa >= 3 && ShteImaMqstoZa <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronavti} astronauts.");               
            }
            else if (ShteImaMqstoZa < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (ShteImaMqstoZa > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}

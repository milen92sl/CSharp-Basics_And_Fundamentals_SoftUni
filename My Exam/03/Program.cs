using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string srokNaDogovor = Console.ReadLine();
            string tipDogovor = Console.ReadLine();
            string desert = Console.ReadLine();
            int broiMeseci = int.Parse(Console.ReadLine());
            double cenaDesert = 0;
            double cenaNaDogovor = 0;
            double otstypka = 0;

            if (srokNaDogovor == "one")
            {
                if (tipDogovor == "Small")
                {
                    cenaNaDogovor = 9.98;
                }
                else if (tipDogovor == "Middle")
                {
                    cenaNaDogovor = 18.99;
                }
                else if (tipDogovor == "Large")
                {
                    cenaNaDogovor = 25.98;
                }
                else if (tipDogovor == "ExtraLarge")
                {
                    cenaNaDogovor = 35.99;
                }
            }
            else if (srokNaDogovor == "two")
            {
                if (tipDogovor == "Small")
                {
                    cenaNaDogovor = 8.58;
                }
                else if (tipDogovor == "Middle")
                {
                    cenaNaDogovor = 17.09;
                }
                else if (tipDogovor == "Large")
                {
                    cenaNaDogovor = 23.59;
                }
                else if (tipDogovor == "ExtraLarge")
                {
                    cenaNaDogovor = 31.79;
                }

                
            }
            if (cenaNaDogovor <= 10)
            {
                cenaDesert = 5.50;
            }
            else if (cenaNaDogovor > 10 && cenaNaDogovor <= 30 )
            {
                cenaDesert = 4.35;
            }
            else if (cenaNaDogovor > 30)
            {
                cenaDesert = 3.85;
            }

            if (desert == "yes")
            {
                cenaNaDogovor = cenaNaDogovor + cenaDesert;
            }
            else if (desert == "no")
            {
                cenaNaDogovor = cenaNaDogovor;
            }
            

            if (srokNaDogovor == "two")
            {
                otstypka = cenaNaDogovor * 0.0375;
                cenaNaDogovor = cenaNaDogovor - otstypka;
            }

            cenaNaDogovor = cenaNaDogovor * broiMeseci;

            Console.WriteLine($"{cenaNaDogovor:f2} lv.");
        }

    }
}

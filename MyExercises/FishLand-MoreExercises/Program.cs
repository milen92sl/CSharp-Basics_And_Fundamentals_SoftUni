using System;

namespace FishLand_MoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
                double priceOfkgSkumriq = double.Parse(Console.ReadLine());
                double priceOfkgcaca = double.Parse(Console.ReadLine());
                double KgPalamud = double.Parse(Console.ReadLine());
                double KgSafrid = double.Parse(Console.ReadLine());
                double KgMidi = double.Parse(Console.ReadLine());

                double priceOfPalamud = priceOfkgSkumriq + priceOfkgSkumriq * 0.60;

                double SumOfPalamud = KgPalamud * priceOfPalamud;
                double PriceOfSafrid = priceOfkgcaca + priceOfkgcaca * 0.80;
                double sumOfSafrid = KgSafrid * PriceOfSafrid;
                double sumOfMidi = KgMidi * 7.50;

                double amountOfAll = SumOfPalamud + sumOfSafrid + sumOfMidi;


                Console.WriteLine($"{amountOfAll:F2}");

            }
        }
    }

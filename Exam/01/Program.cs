using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double broiMeseci = double.Parse(Console.ReadLine());
            double procentKomisionna = double.Parse(Console.ReadLine());
            double cenaNameMesec = double.Parse(Console.ReadLine());

            procentKomisionna = procentKomisionna * 0.01;

            double parwapolowinaMeseci = broiMeseci / 2;
            parwapolowinaMeseci = Math.Floor(parwapolowinaMeseci);

            double wtorapolowinaMeseci = broiMeseci - parwapolowinaMeseci;
            double cenaZaWtoraPolovina = cenaNameMesec * 0.8;
            double parwaPolowina = parwapolowinaMeseci * cenaNameMesec;
            double wtoraPolovina = wtorapolowinaMeseci * cenaZaWtoraPolovina;
            double obshto = parwaPolowina + wtoraPolovina;

           
            double zaBrokera = obshto * procentKomisionna;
            double obshtoVsichko = obshto + zaBrokera;

            Console.WriteLine($"Total: {obshtoVsichko:f2}");
        }
    }
}

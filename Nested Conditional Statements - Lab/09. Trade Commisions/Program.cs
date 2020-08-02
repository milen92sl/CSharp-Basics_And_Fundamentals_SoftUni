using System;

namespace _09._Trade_Commisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commisions = 0.0;
            
            if ("Sofia"== town)
            
                if (sales > 0 && sales <= 500)
            {
                    commisions = 0.05;
            }
                else if (sales > 500 && sales <= 1000)
                {
                    commisions = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commisions = 0.08;
                }
                else if (sales > 10000)
                {
                commisions = 0.12;
                }
            if ("Varna" == town)
                if (sales > 0 && sales <= 500)
                {
                    commisions = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commisions = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commisions = 0.10;
                }
                else if (sales > 10000)
                {
                    commisions = 0.13;
                }

            if ("Plovdiv" == town)
                if (sales > 0 && sales <= 500)
                {
                    commisions = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commisions = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commisions = 0.12;
                }
                else if (sales > 10000)
                {
                    commisions = 0.145;
                }
            if (commisions > 0)
            {
                double result = commisions * sales;
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

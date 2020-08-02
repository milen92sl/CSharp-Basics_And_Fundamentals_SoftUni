using System;

namespace _03._Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCruise = Console.ReadLine();
            string typeCabin = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());
            double vaccationSum = 0;
            double discount = vaccationSum * 0.25;

            if (typeCabin == "standard cabin")
            {
                if (typeCruise == "Mediterranean")
                {
                    vaccationSum = 27.50 * 4 * countNights;
                }
                else if (typeCruise == "Adriatic")
                {
                    vaccationSum = 22.99 * 4 * countNights;
                }
                else if (typeCruise == "Aegean")
                {
                    vaccationSum = 23.00 * 4 * countNights;
                }
            }
            if (typeCabin == "cabin with balcony")
            {
                if (typeCruise == "Mediterranean")
                {
                    vaccationSum = 30.20 * 4 * countNights;
                }
                else if (typeCruise == "Adriatic")
                {
                    vaccationSum = 25.00 * 4 * countNights;
                }
                else if (typeCruise == "Aegean")
                {
                    vaccationSum = 26.60 * 4 * countNights;
                }
            }
            if (typeCabin == "apartment")
            {
                if (typeCruise == "Mediterranean")
                {
                    vaccationSum = 40.50 * 4 * countNights;
                }
                else if (typeCruise == "Adriatic")
                {
                    vaccationSum = 34.99 * 4 * countNights;
                }
                else if (typeCruise == "Aegean")
                {
                    vaccationSum = 39.80 * 4 * countNights;
                }
            }
            if (countNights > 7)
            {
                discount = vaccationSum * 0.25;
                vaccationSum = vaccationSum - discount;
            }
            
            Console.WriteLine($"Annie's holiday in the {typeCruise} sea costs {vaccationSum:f2} lv.");
        }
    }
}

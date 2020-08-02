using System;

namespace biggest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfResevetion = int.Parse(Console.ReadLine());
            int mountOfResevetion = int.Parse(Console.ReadLine());
            int dayOfArriving = int.Parse(Console.ReadLine());
            int mounthOfArriving = int.Parse(Console.ReadLine());
            int dayForLeaving = int.Parse(Console.ReadLine());
            int mountForLeaving = int.Parse(Console.ReadLine());
            int priceForOneNight = 0;
            double finalPrice = 0;
            int NightsInHotel = 0;
            double discount;



            NightsInHotel = dayForLeaving - dayOfArriving;

            if (mountOfResevetion < mounthOfArriving)
            {
                priceForOneNight = 25;
                discount = (NightsInHotel * priceForOneNight) * 0.2;
                
                finalPrice = (NightsInHotel * priceForOneNight) - discount;

            }

            if (dayOfResevetion < 10 && dayOfResevetion <= dayOfArriving)
            {
                priceForOneNight = 25;
                discount = (NightsInHotel * priceForOneNight) * 0.2;
                finalPrice = (NightsInHotel * priceForOneNight) - discount;
            }
            if (mountOfResevetion == mounthOfArriving)
            {
                priceForOneNight = 30;
                finalPrice = NightsInHotel * priceForOneNight;

            }

            Console.WriteLine($"Your stay from {dayOfArriving}/{mounthOfArriving} to {dayForLeaving}/{mountForLeaving} will cost {finalPrice:f2}");

        }
        
        
    }
}
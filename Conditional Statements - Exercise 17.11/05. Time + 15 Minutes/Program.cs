using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());

            int startTimeInMinutes = startHour * 60 + startMinutes;
            int timeAfter15minutes = startTimeInMinutes + 15;

            int finalHours = timeAfter15minutes / 60;
            if (finalHours == 24)
            {
                finalHours = 0;
            }
            int finalMinutes = timeAfter15minutes % 60;

            if (finalMinutes < 10)
            {
                Console.WriteLine($"{finalHours}:0{finalMinutes}");
            }
            else
            {
                Console.WriteLine($"{finalHours}:{finalMinutes}");
            }
        }
    }
}

using System;
using System.Globalization;

namespace _01
{
    class Program
    {
        public static DateTimeStyles InvariantCulture { get; private set; }

        static void Main(string[] args)
        {

            var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.MM.yyyy", CultureInfo.InvariantCulture);

            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.MM.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;

            Console.WriteLine(holidaysCount);
        }
    }

}






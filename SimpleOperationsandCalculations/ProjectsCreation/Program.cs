using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Името на архитекта - текст
            //2.Брой на проектите -цяло число в интервала[0… 100]
            string architectName = Console.ReadLine();
            int numberOfproects = int.Parse(Console.ReadLine());

            int hoursNeeded = numberOfproects * 3;



            Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {numberOfproects} project/s.");

        }


    }
}

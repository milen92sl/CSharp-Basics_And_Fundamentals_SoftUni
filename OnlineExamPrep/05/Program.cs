using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPassengers = int.Parse(Console.ReadLine());
            int numberOfStopStation = int.Parse(Console.ReadLine());
            int counter = 0;
            int getOff = 0;
            int getIn = 0;

            for (int i = 1; i <= numberOfStopStation; i++)
            {
                getOff = int.Parse(Console.ReadLine());
                getIn = int.Parse(Console.ReadLine());
                numberOfPassengers -= getOff;
                numberOfPassengers += getIn;

                if (i % 2 == 1)
                {
                    numberOfPassengers += 2;

                }
                else if (i % 2 == 0)
                {
                    numberOfPassengers -= 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {numberOfPassengers}");
        }
    }
}

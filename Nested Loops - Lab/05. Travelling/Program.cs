using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double neededMoney = 0;
            double moneySaved = 0;
            
            while (destination!= "End")
            {
               
                neededMoney = double.Parse(Console.ReadLine());
                double currentSum = 0;
                while (currentSum < neededMoney)
                {
                    moneySaved = double.Parse(Console.ReadLine());
                    currentSum = currentSum + moneySaved;
                }
                Console.WriteLine($"Going to {destination}!");
                currentSum = 0;
                destination = Console.ReadLine();
            }

        }
    }
}

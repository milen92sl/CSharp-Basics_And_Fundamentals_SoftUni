using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            int totalfactorialSum = 0;

            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                tempNum /= 10;
                int currentFactorialSum = 1;

                for (int i = 1; i <= digit; i++)
                {
                    currentFactorialSum *= i;

                }

                totalfactorialSum += currentFactorialSum;
      
            }
            if (num == totalfactorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

using System;

namespace _08._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {

                int currentNumber = int.Parse(Console.ReadLine());
                counter++;
                if (counter % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else if (counter % 2 == 1)
                {
                    sumOdd += currentNumber;
                }
                

            }
            sum = sumEven - sumOdd;
            if (sum == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+ sumEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+ Math.Abs(sum));

            }
        }
    }
}

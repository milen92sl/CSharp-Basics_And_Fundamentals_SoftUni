using System;

namespace _15.Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int currentNum = 1;
            string value = string.Empty;
            for (int i = 2; i <= num; i++)
            {
                currentNum++;
                bool isitTrue = true;
                value = "true";
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        
                        isitTrue = false;
                        value = "false";
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {value}");
            }

        }
    }
}

using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerLimit = int.Parse(Console.ReadLine());
            int upperLimit = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            bool hasMagicCombination = false;
            int combinationCount = 0;

            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                for (int j = lowerLimit; j <= upperLimit; j++)
                {
                    combinationCount++;

                    int currentsum = i + j;
                    if (currentsum == magicNumber)
                    {
                        
                        Console.WriteLine($"Combination N:{combinationCount} ({i} + {j} = {currentsum})");
                        hasMagicCombination = true;
                        break;
                    }                      
                }
                if (hasMagicCombination)
                {
                    break;
                }
                
            }
            if (!hasMagicCombination)
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicNumber}");
            }
            
        }
    }
}

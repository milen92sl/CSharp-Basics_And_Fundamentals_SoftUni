using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] maxArr = new int[n];
            int maxCount = 0;
            int maxIndex = 0;
            int maxSample = 1;
            int currSample = 1;
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Clone them!")
                {
                    break;
                }


                int[] currArr = Console.ReadLine()
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                currSample++;
                int bestCurrCount = 0;
                int bestCurrIndex = 0;
                int bestCurrSum = 0;


                for (int currIndex = 0; currIndex < currArr.Length; currIndex++)
                {
                    int currElement = currArr[currIndex];
                    int currcounter = 1;
                    if (currElement == 0)
                    {
                        continue;
                    }
                    for (int Index = currIndex + 1; Index < currArr.Length; Index++)
                    {

                        if (currArr[Index] == 1)
                        {
                            currcounter++;
                        }
                        else
                        {
                            break;
                        }
                        if (currcounter > bestCurrCount)
                        {
                            bestCurrCount = currcounter;
                            bestCurrIndex = currIndex;
                            bestCurrSum = currArr.Sum();


                        }
                    }
                    if (bestCurrCount > maxCount ||
                        (bestCurrCount == maxIndex && maxIndex > bestCurrIndex) ||
                        maxArr.Sum() < bestCurrSum)
                    {
                        maxIndex = bestCurrIndex;
                        maxCount = bestCurrCount;
                        maxArr = currArr;
                        maxSample = currSample;
                    }
                }

            }
            Console.WriteLine($"Best DNA sample {maxSample} with sum: {maxArr.Sum()}.");
            Console.WriteLine(string.Join(" ", maxArr));
            //Console.WriteLine(maxSample);
        }
    }
}

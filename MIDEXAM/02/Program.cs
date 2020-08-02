using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetValue = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();

            int count = 0;

            string input = string.Empty;

            while (input != "End")
            {
                input = Console.ReadLine();

                if (input != "End")
                {
                    int currentIndex = int.Parse(input);

                    if (currentIndex >= 0 && currentIndex < targetValue.Count)
                    {
                        int currentNum = targetValue[currentIndex];
                        int endIndex = targetValue.Count;
                        if (currentIndex >= 0
                            && currentIndex < targetValue.Count
                            && endIndex > 0)
                        {
                            for (int i = 0; i < endIndex; i++)
                            {
                                if (targetValue[i] == -1)
                                {

                                }
                                if (targetValue[i] < currentNum)
                                {
                                    targetValue[i] += currentNum;
                                }
                                else
                                {
                                    targetValue[i] -= currentNum;
                                }

                                if (targetValue[i] == 0)
                                {
                                    count++;
                                    targetValue[i] = -1;
                                }
                            }
                        }

                    }
                }

            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", targetValue)}");
        }

    }

}
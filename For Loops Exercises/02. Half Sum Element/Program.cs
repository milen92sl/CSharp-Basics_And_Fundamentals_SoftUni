﻿using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace _01
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                int sum = 0;
                int max = int.MinValue;

                for (int i = 0; i < n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    sum += num;

                    if (num > max)
                    {
                        max = num;
                    }
                }
                int sumWithoutMaxNumber = sum - max;

                if (max == sumWithoutMaxNumber)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = " + max);
                }

                else if (max != sumWithoutMaxNumber)
                {
                    int diff = (max - sumWithoutMaxNumber);
                    Console.WriteLine("No");
                    Console.WriteLine("Diff = " + Math.Abs(diff));
                }
            }
        }
    }

}
    }
}

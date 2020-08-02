using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] rise = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        double firstSumTime = GetSumofAllEtap(rise);

        rise = rise
            .Reverse()
            .ToArray();

        double secondSumTime = GetSumofAllEtap(rise);

        if (firstSumTime <= secondSumTime)
        {
            Console.WriteLine("The winner is left with total time: {0}", firstSumTime);
        }
        else
        {
            Console.WriteLine("The winner is right with total time: {0}", secondSumTime);
        }
    }

    public static double GetSumofAllEtap(int[] rise)
    {
        int halfIndex = rise.Length / 2;

        double sum = 0.0;

        for (int i = 0; i < halfIndex; i++)
        {
            if (rise[i] == 0)
            {
                sum = sum * 8 / 10;
            }
            else
            {
                sum += rise[i];
            }

            // Console.WriteLine("rise[{0}] = {1}, sum = {2}", i, rise[i], sum);                  
        }
        return sum;
    }
}
﻿using System;

namespace _10._Numbers_1N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number ; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}

﻿using System;

namespace _02._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            
            else
            {
                Console.WriteLine(num2);
            }
            
        }
    }
}

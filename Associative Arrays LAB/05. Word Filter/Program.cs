﻿using System;
using System.Linq;
namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string[] wordsWithoutOdd = words.Where(word => word.Length % 2 == 0).ToArray();

            
            Console.WriteLine(String.Join('\n',wordsWithoutOdd));
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string result = "";
            foreach (string word in words)
            {
                int repeatTimes = word.Length;

                for (int i = 0; i < repeatTimes; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
            
           
        }
    }
}


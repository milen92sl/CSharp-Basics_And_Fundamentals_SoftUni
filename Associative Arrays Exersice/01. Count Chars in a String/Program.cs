using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, uint> histogram = new Dictionary<char, uint>();


            string text = Console.ReadLine() ;
            for (int i = 0; i < text.Length; i++)
            {
                char currCh = text[i];
                if (currCh != ' ')
                {
                    if (!histogram.ContainsKey(currCh))
                    {
                        histogram[currCh] = 0;
                    }

                    histogram[currCh]++;
                }
            }
            foreach (var keyValuePair in histogram)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}

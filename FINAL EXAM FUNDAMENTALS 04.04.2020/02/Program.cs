using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([#|@]){1}([A-Za-z]{3,})(\1{2})([A-Za-z]{1,})(\1)";
            int count = 0;
            
          MatchCollection matches = Regex.Matches(input, pattern);

            foreach (var m in matches)
            {
                
                Match match = Regex.Match(input, pattern);

                if (String.Join("", match.Groups[2].Value.Reverse()) == match.Groups[4].Value)
                {
                    Console.WriteLine("The mirror words are:");
                    foreach (var mat in matches)
                    {
                        
                        Console.Write($"{match.Groups[2]} <=> {match.Groups[4]}, ");
                    }
                }
                else 
                {
                    Console.WriteLine("No mirror words!");
                }


                count++;
                
            }

            Console.WriteLine($"{count} word pairs found!");


            if (count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
                

        }

    }
}



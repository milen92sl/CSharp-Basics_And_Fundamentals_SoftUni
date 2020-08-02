using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // @"\b[A-Z][a-z]+ [A-Z][a-z]+\b"

            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            MatchCollection names = regex.Matches(input);

            foreach (Match name in names)
            {
                Console.Write(name.Value + " ");
            }
            

            
        }
    }
}

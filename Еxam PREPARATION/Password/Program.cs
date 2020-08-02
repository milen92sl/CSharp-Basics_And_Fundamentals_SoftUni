using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(.+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<(\1)$";
            // pattern 
            // regex 
            Regex regex = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();

                Match match = regex.Match(password);

                //validate password =>
                if (!match.Success)
                {

                    Console.WriteLine("Try another password");
                    continue;
                }
                // encrypt password
                string numbers = match.Groups[2].Value;
                string lowerLetters = match.Groups[3].Value;
                string upperLetters = match.Groups[4].Value;
                string symbols = match.Groups[5].Value;

                string encryptedPass = string.Concat(numbers, lowerLetters, upperLetters, symbols);

                Console.WriteLine($"Password: {encryptedPass}");
            }




        }
    }
}

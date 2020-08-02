using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

            double sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                sum = ProcessWord(words, sum, i);
            }
            Console.WriteLine($"{sum:f2}");
        }

        private static double ProcessWord(string[] words,
            double sum, int i)
        {
            double tempSum = 0;

            string currentWord = words[i];

            char firstLetter = currentWord[0];
            char lastLetter = currentWord[currentWord.Length - 1];

            double number = ParseNumberFromInput
                (currentWord);


            int firstLetterPos =
                GetAlphabeticalPositionByLetter(firstLetter);
            int lastLetterPos =
                GetAlphabeticalPositionByLetter(lastLetter);


            if (Char.IsUpper(firstLetter) &&
                firstLetterPos > 0)
            {
                tempSum = number / firstLetterPos;
            }
            else if (Char.IsLower(firstLetter) &&
                firstLetterPos > 0)
            {
                tempSum = number * firstLetterPos;
            }
            if (Char.IsUpper(lastLetter) &&
                lastLetter > 0)
            {
                tempSum -= lastLetterPos;
            }
            else if (Char.IsLower(lastLetter) &&
                lastLetterPos > 0)
            {
                tempSum += lastLetterPos;
            }
            sum += tempSum;
            return sum;
        }

        private static int GetAlphabeticalPositionByLetter(char letter)
        {
            int position = -1;

            if (Char.IsLetter(letter))
            {
                if (Char.IsUpper(letter))
                {
                    position = letter - 64;
                }
                else
                {
                    position = letter - 96;
                }
            }

            return position;
        }

        private static double ParseNumberFromInput(string currentWord)
        {
            char[] numberAsCharArr = currentWord
                                .Skip(1)
                                .Take(currentWord.Length - 2)
                                .ToArray();
            string numberAsString = String.Join("",
                numberAsCharArr);

            double number = double.Parse(numberAsString);
            return number;
        }
    }
}

using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string allDigits = string.Empty;
            string allLetters = string.Empty;
            string everythingElse = string.Empty;

            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    allDigits += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    allLetters += symbol;
                }
                else
                {
                    everythingElse += symbol;
                }
            }
            Console.WriteLine(allDigits);
            Console.WriteLine(allLetters);
            Console.WriteLine(everythingElse);

        }
    }
}

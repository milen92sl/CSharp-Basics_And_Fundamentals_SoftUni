using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char currentCh = input[i];

                int subsequenceLenght = 0;
                for (int j = i+ 1; j < input.Length; j++)
                {

                    char nextCh = input[j];

                    if (currentCh == nextCh)
                    {
                        subsequenceLenght++;
                    }
                    else
                    {
                        break;
                    }
                }

                input = input.Remove(i + 1, subsequenceLenght);
            }
            Console.WriteLine(input);
        }
    }
}

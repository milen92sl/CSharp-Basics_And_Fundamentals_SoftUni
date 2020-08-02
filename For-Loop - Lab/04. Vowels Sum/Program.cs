using System;

namespace _04._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = (char)input[i];
                switch (currentLetter)
                {
                    case 'a':
                        sum += 1;
                        
                    case 'e':
                      sum += 2;

                            case 'i':
                        sum += 3;

                            case 'o':
                        sum += 4;

                            case 'u':
                       sum += 5;

                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

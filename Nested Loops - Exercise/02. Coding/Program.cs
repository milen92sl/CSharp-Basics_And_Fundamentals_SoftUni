using System;

namespace _02._Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            for (int i = inputNum.Length - 1; i >= 0; i--)
            {
                char currentDigit = inputNum[i];
                int currentDigitNum = int.Parse(currentDigit.ToString());

                if (currentDigitNum == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;

                }
                for (int n = 1; n <=currentDigitNum; n++)
                {
                    Console.Write((char)(currentDigitNum + 33));
                }
                Console.WriteLine();
            }
        }
    }
}

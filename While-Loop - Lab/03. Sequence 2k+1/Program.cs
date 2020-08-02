using System;

namespace _03._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());
            int currentNum = 1;

            while (currentNum <= maxNum)
            {
                Console.WriteLine(currentNum);
                currentNum = currentNum * 2 + 1; 
            }
        }
    }
}

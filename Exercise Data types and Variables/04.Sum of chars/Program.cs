using System;

namespace _04.Sum_of_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += symbol;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}

using System;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int index = random.Next(0, input.Length);

                string tempVar = input[index];
                input[index] = input[i];
                input[i] = tempVar;
            }
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}

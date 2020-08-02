using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();
            string result = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                bool isTopInt = true;

                for (int index = i+1; index < arr.Length; index++)
                {
                    if (current <= arr[index])
                    {
                        isTopInt = false;
                        break;
                    }
                }
                if (isTopInt)
                {
                    result += current + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}

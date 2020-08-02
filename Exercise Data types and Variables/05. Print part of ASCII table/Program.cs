using System;

namespace _05._Print_part_of_ASCII_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = start; i <= end; i++)
            {
                result += (char)i + " ";
            }

            Console.WriteLine(result);
        }
    }
}

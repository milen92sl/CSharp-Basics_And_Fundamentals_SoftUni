using System;

namespace _03._Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

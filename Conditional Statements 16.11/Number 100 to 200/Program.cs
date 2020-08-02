using System;

namespace Number_100_to_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            if (numb < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (numb <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (numb > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}

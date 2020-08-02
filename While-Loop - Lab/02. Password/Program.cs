using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();
            string passAttempt = Console.ReadLine();

            while (passAttempt != password)
            {
                passAttempt = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}!");
        }
    }
}

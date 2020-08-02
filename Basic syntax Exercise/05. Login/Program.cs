using System;

namespace Zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPassword = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPassword += username[i];
            }


            for (int i = 1; i <= 4; i++)
            {

                string password = Console.ReadLine();

                if (correctPassword == password)
                {

                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (i <= 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                }





            }
        }
    }
}

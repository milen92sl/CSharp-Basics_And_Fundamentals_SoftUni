using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] commandArr = command.Split(":|:");
                string instruction = commandArr[0];

                if (instruction == "InsertSpace")
                {

                    int index = int.Parse(commandArr[1]);
                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }

                else if (instruction == "Reverse")
                {
                    string oldSubstring = commandArr[1];
                    

                    if (message.Contains(oldSubstring))
                    {
                        string newSubstring = string.Join("", oldSubstring.Reverse());
                        message = message.Replace(oldSubstring, newSubstring);

                        Console.WriteLine(message);
                    }
                   

                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (instruction == "ChangeAll")
                {
                    char substring = char.Parse(commandArr[1]);
                    char replacement = char.Parse(commandArr[2]);

                    message = message.Replace(substring, replacement).ToString();
                    Console.WriteLine(message);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
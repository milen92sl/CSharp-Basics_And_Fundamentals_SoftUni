using System;
using System.Collections.Generic;
using System.Linq;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split("|");

            string input = Console.ReadLine();

            while (input != "Done")
            {

                string[] splitted = input.Split();
                Move(parts, splitted);

                if (splitted[0] == "Check")
                {
                    int sign = 0;

                    if (splitted[1] == "Odd")
                    {
                        sign = 1;
                    }

                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (i % 2 == sign)
                        {
                            Console.Write(parts[i] + " ");
                        }

                    }
                    Console.WriteLine();
                }
                input = Console.ReadLine();
                
            }
            Console.WriteLine($"You crafted {String.Join("", parts)}!");

        }

        public static void Move(string[] parts, string[] splitted)
        {
            if (splitted[0] == "Move")
            {
                if (splitted[1] == "Left")
                {
                    int index = int.Parse(splitted[2]);

                    if (index > 0 && index < parts.Length)
                    {
                        string temp = parts[index];
                        parts[index] = parts[index - 1];
                        parts[index - 1] = temp;
                    }

                }
                else if (splitted[1] == "Right")
                {
                    int index = int.Parse(splitted[2]);

                    if (index >= 0 && index < parts.Length - 1)
                    {
                        string temp = parts[index];
                        parts[index] = parts[index + 1];
                        parts[index + 1] = temp;
                    }
                }
            }
        }
    }
}

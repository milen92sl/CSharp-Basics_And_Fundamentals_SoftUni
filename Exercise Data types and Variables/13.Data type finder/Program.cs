﻿using System;

namespace _13.Data_type_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int valueInt;
            float valueFloat;
            char valueChar;
            bool valueBoolean;

            while (input != "END")
            {
                if (int.TryParse(input, out valueInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out valueFloat))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out valueChar))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out valueBoolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
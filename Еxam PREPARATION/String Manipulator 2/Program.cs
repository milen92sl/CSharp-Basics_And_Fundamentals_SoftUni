using System;
using System.Linq;
using System.Collections.Generic;


namespace String_Manipulator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splitedInput = input.Split(" ");
                string command = splitedInput[0];

                if (command == "Add")
                {
                    string newStringToAdd = splitedInput[1];

                    result += newStringToAdd;


                }
                else if (command == "Upgrade")
                {
                    char oldChar = char.Parse(splitedInput[1]);

                    result = result.Replace(oldChar, (char)(oldChar + 1));
                }
                else if (command == "Print")
                {
                    Console.WriteLine(result);
                }
                else if (command == "Index")
                {
                    char symbol = char.Parse(splitedInput[1]);
                    int count = 0;

                    if (result.Contains(symbol))
                    {
                        for (int i = 0; i < result.Length; i++)
                        {
                            char currentSymbol = result[i];

                            if (currentSymbol == symbol)
                            {
                                Console.Write(i + " ");
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("None");
                        }

                    }
                }



                input = Console.ReadLine();
            }
        }
    }
}

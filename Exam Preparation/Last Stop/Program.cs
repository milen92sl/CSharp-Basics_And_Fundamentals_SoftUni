using System;
using System.Collections.Generic;
using System.Linq;

namespace Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                   .Split(" ")
                   .Select(int.Parse)
                   .ToList();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string [] commandArgs = input
                    .Split(" ");

                string command = commandArgs[0];

                if (command == "Change")
                {
                    int currentNumber = int.Parse(commandArgs[1]);
                    int newNumber = int.Parse(commandArgs[2]);

                    if (numbers.Contains(currentNumber))
                    {
                        int index = numbers.IndexOf(currentNumber);

                        numbers[index] = newNumber;
                    }
                    
                }
                else if (command == "Hide")
                {
                    int currentNumber = int.Parse(commandArgs[1]);
                    if (numbers.Contains(currentNumber))
                    {
                        numbers.Remove(currentNumber);
                    }
                    
                }
                else if (command == "Switch")
                {
                    int firstNumber = int.Parse(commandArgs[1]);
                    int secondNumber = int.Parse(commandArgs[2]);
                    if (numbers.Contains(firstNumber) && numbers.Contains(secondNumber))
                    {
                        int firstIndex = numbers.IndexOf(firstNumber);
                        int secondIndex = numbers.IndexOf(secondNumber);

                        numbers[firstIndex] = secondNumber;
                        numbers[secondIndex] = firstNumber;
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commandArgs[1]) + 1;
                    int newNumber = int.Parse(commandArgs[2]);
                    if (index > -1 && index < numbers.Count)
                    {
                        numbers.Insert(index, newNumber);
                    }          
                }
                else if (command == "Reverse")
                {
                    numbers.Reverse();
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                 .Split(' ', 
                                 StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();

            string command;
            while ((command = Console.ReadLine())!= "End")
            {
                string[] cmdArgs = command
                    .Split(' ',
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    AddNumber(numbers, cmdArgs);
                }
                else if (cmdType == "Insert")
                {
                    InsertAtIndex(numbers, cmdArgs);
                }
                else if (cmdType == "Remove")
                {
                    RemoveAtIndex(numbers, cmdArgs);
                }
                else if (cmdType == "Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);

                    count = count % numbers.Count;
                    ShiftNums(numbers, direction, count);
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        private static void ShiftNums(List<int> numbers, string direction, int count)
        {
            if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    int firstEl = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(firstEl);

                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < count; i++)
                {
                    int lastEl = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(0, lastEl);
                        }
            }
        }

        private static void RemoveAtIndex(List<int> numbers, string[] cmdArgs)
        {
            int index = int.Parse(cmdArgs[1]);

            if (index >= 0 && index < numbers.Count)
            {
                numbers.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        private static void InsertAtIndex(List<int> numbers, string[] cmdArgs)
        {
            int numberToInsert = int.Parse(cmdArgs[1]);
            int index = int.Parse(cmdArgs[2]);
            if (index >= 0 && index < numbers.Count)
            {
                numbers.Insert(index, numberToInsert);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        private static void AddNumber(List<int> numbers, string[] cmdArgs)
        {
            int numberToAppend = int.Parse(cmdArgs[1]);
            numbers.Add(numberToAppend);
        }
    }
}

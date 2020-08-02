using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetValue = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while (input != "End")
            {
                input = Console.ReadLine();
                string[] commandArgs = input
                    .Split(" ");

                string command = commandArgs[0];

                if (command == "Shoot")
                {
                    int index = int.Parse(commandArgs[1]);
                    int power = int.Parse(commandArgs[2]);

                    if (index >= 0 && index < targetValue.Count)
                    {
                        targetValue[index] -= power;
                        if (targetValue[index] <= 0)
                        {
                            targetValue.RemoveAt(index);

                        }

                    }
                }

                else if (command == "Add")
                {
                    int index = int.Parse(commandArgs[1]);
                    int value = int.Parse(commandArgs[2]);
                    if (index >= 0 && index < targetValue.Count)
                    {
                        targetValue.Insert(index, value);
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (command == "Strike")
                {
                    int index = int.Parse(commandArgs[1]);
                    int radius = int.Parse(commandArgs[2]);
                    int rightIndex = index + radius;
                    int leftIndex = index - radius;
                    if (index >= 0  
                        && rightIndex < targetValue.Count 
                        && leftIndex > 0)
                    {
                        for (int i = index; i <= rightIndex; i++)
                        {
                            if (i < targetValue.Count)
                            {
                                targetValue.RemoveAt(index);
                            }
                            else
                            {
                                break;
                            }
                        }

                        for (int i = index - 1; i >= leftIndex; i--)
                        {
                            if (i >= 0)
                            {
                                targetValue.RemoveAt(i);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }

                }


            }
            Console.WriteLine(string.Join("|", targetValue));
        }
    }
}

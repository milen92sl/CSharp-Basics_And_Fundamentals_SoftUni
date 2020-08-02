using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 19 2 53 6 43
            //Add 3
            //Remove 2
            //RemoveAt 1
            //Insert 8 3
            //end

            List<int> nums = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToList();

            List<int> evenNums = new List<int>();
            List<int> oddNums = new List<int>();
            List<int> filterSmall = new List<int>();
            List<int> filterESmall = new List<int>();
            List<int> filterBig = new List<int>();
            List<int> filterEBig = new List<int>();

            int sum = 0;
            int numberFilter = 0;
            int count = 0;
            string condition = string.Empty;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;

                }
                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numbToAdd = int.Parse(tokens[1]);
                        nums.Add(numbToAdd);
                        break;
                    case "Remove":
                        int numbToRemove = int.Parse(tokens[1]);
                        nums.Remove(numbToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        nums.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numbToInsert = int.Parse(tokens[1]);
                        int indxToInsert = int.Parse(tokens[2]);
                        nums.Insert(indxToInsert, numbToInsert);
                        break;
                    case "Contains":
                        int numberToContains = int.Parse(tokens[1]);
                        nums.Contains(numberToContains);
                        if (nums.Contains(numberToContains))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 == 0)
                            {

                                evenNums.Add(nums[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", evenNums));
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 == 1)
                            {
                                oddNums.Add(nums[i]);
                            }
                        }

                        Console.WriteLine(string.Join(" ", oddNums));
                        break;
                    case "GetSum":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            sum += nums[i];

                        }

                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        condition = tokens[1];
                        numberFilter = int.Parse(tokens[2]);

                        if (condition == "<")
                        {
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] < numberFilter)
                                {
                                    filterSmall.Add(nums[i]);

                                }
                            }

                            Console.WriteLine(string.Join(" ", filterSmall));

                        }
                        else if (condition == ">")
                        {
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] > numberFilter)
                                {
                                    filterBig.Add(nums[i]);

                                }
                            }

                            Console.WriteLine(string.Join(" ", filterBig));

                        }
                        else if (condition == ">=")
                        {
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] >= numberFilter)
                                {
                                    filterEBig.Add(nums[i]);

                                }
                            }

                            Console.WriteLine(string.Join(" ", filterEBig));

                        }

                        else if (condition == "<=")
                        {
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] <= numberFilter)
                                {
                                    filterESmall.Add(nums[i]);

                                }
                            }

                            Console.WriteLine(String.Join(" ", filterESmall));

                        }
                        break;
                }
            }

            if (count > 0)
            {
                Console.WriteLine(String.Join(" ", nums));
            }
        }
    }
}
using System;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string specialWords = "Like";

            string commands = Console.ReadLine();

            while (commands != "Finish")
            {

                string[] commandInfo = commands.Split();
                string action = commandInfo[0];

                if (action == "Replace")
                {
                    string currentChar = commandInfo[1];
                    string newChar = commandInfo[2];

                    specialWords = specialWords.Replace(currentChar, newChar);
                }
                if (action == "Cut")
                {
                    // Cut {startIndex} {endIndex} 
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);

                    if (startIndex < 0 || startIndex >= specialWords.Length || endIndex < 0 || endIndex >= specialWords.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        specialWords = specialWords.Substring(0, startIndex) + specialWords.Substring(endIndex + 1);
                        Console.WriteLine(specialWords);
                    }

                }
                if (action == "Make")
                {
                    string subAction = commandInfo[1];
                    if (subAction == "Upper")
                    {
                        specialWords = specialWords.ToUpper();
                        Console.WriteLine(specialWords);
                    }
                    else
                    {
                        specialWords = specialWords.ToLower();
                        Console.WriteLine(specialWords);
                    }

                }
                if (action == "Check")
                {
                    string targetString = commandInfo[1];
                    if (specialWords.Contains(targetString))
                    {

                        Console.WriteLine($"Message contains {targetString}");
                    }
                    else
                    {

                        Console.WriteLine($"Message doesn't contain {targetString}");
                    }
                    
                }
                //"Sum {startIndex} {endIndex}"
                if (action == "Sum")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);

                    if (startIndex < 0 || startIndex >= specialWords.Length || endIndex < 0 || endIndex >= specialWords.Length)
                    {
                        Console.WriteLine("Invalid indexes!");

                    }
                    else
                    {
                        int sum = 0;
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            sum += specialWords[i];
                        }
                        Console.WriteLine(sum);
                    }
                    

                }
                commands = Console.ReadLine();
            }
        }
    }
}

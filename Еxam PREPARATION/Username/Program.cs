using System;
using System.Linq;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string input = Console.ReadLine();


            while (input != "Sign in")
            {

                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "Case")
                {
                    string caseType = tokens[1];

                    if (caseType == "lower")
                    {
                        username = username.ToLower();

                    }
                    else if (caseType == "upper")
                    {
                        username = username.ToUpper();

                    }
                    Console.WriteLine(username);
                }
                if (command == "Reverse")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int length = endIndex - startIndex + 1;
                    bool isNotValidStartIndex = startIndex < 0 || startIndex >= username.Length;
                    bool isNotValidEndIndex = endIndex < 0 || endIndex >= username.Length;
                   
                    if (isNotValidEndIndex || isNotValidStartIndex)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    string subStr = username.Substring(startIndex, length);
                    char[] chars = subStr.Reverse().ToArray();
                    string reversedSubStr = new string(chars);

                    Console.WriteLine(reversedSubStr);
                }
                if (command == "Cut")
                {
                    string SubStrCut = tokens[1];

                    if (username.Contains(SubStrCut))
                    {
                        username = username.Replace(SubStrCut, "");
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {SubStrCut}");
                    }
                }
                if (command == "Replace")
                {
                    char charReplace = char.Parse(tokens[1]);
                    username = username.Replace(charReplace, '*');
                }
                if (command == "Check")
                {
                    char charCheck = char.Parse(tokens[1]);
                    if (username.Contains(charCheck))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {charCheck}.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}

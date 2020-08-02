using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.House_party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> people = new List<string>();
            for (int i = 0; i < n; i++)
            {
                ProceedCommand(people);
            }
            PrintPeople(people);
        }

        private static void PrintPeople(List<string> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        private static void ProceedCommand(List<string> people)
        {
            string command = Console.ReadLine();

            string[] cmdArgs = command.Split(' ')
                .ToArray();

            string name = cmdArgs[0];

            if (cmdArgs.Length == 3)
            {
                //going 

                AddPerson(people, name);

            }
            else if (cmdArgs.Length == 4)
            {
                //not going
                RemovePerson(people, name);
            }
        }

        private static void AddPerson(List<string> people, string name)
        {
            if (people.Contains(name))
            {
                Console.WriteLine($"{name} is already in the list!");
            }
            else
            {
                people.Add(name);
            }
        }

        private static void RemovePerson(List<string> people, string name)
        {
            if (people.Contains(name))
            {
                people.Remove(name);
            }
            else
            {
                Console.WriteLine($"{name} is not in the list!");
            }
        }


    }
}

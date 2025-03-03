﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hero_Recruitment
{
    // check why 90/100
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
            var command = Console.ReadLine();
            while (command != "End")
            {
                var tokens = command.Split();
                var instruction = tokens[0];
                if (instruction == "Enroll")
                {
                    var heroName = tokens[1];
                    if (heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                        command = Console.ReadLine();
                        continue;
                    }
                    heroes.Add(heroName, new List<string>());
                }
                else if (instruction == "Learn")
                {
                    var heroName = tokens[1];
                    var heroSpell = tokens[2];
                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                        command = Console.ReadLine();
                        continue;
                    }
                    else if (heroes.ContainsKey(heroName))
                    {
                        if (heroes[heroName].Contains(heroSpell))
                        {
                            Console.WriteLine($"{heroName} has already learnt {heroSpell}.");
                            command = Console.ReadLine();
                            continue;
                        }
                        heroes[heroName].Add(heroSpell);

                    }
                }
                else if (instruction == "Unlearn")
                {
                    var heroName = tokens[1];
                    var heroSpell = tokens[2];
                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                        command = Console.ReadLine();
                        continue;
                    }
                    else if (heroes.ContainsKey(heroName))
                    {
                        if (heroes[heroName].Contains(heroSpell))
                        {
                            heroes[heroName].Remove(heroSpell);
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine($"{heroName} doesn't know {heroSpell}.");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Heroes:");
            foreach (var hero in heroes.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
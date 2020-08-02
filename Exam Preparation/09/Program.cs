using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._03._ContactList
{
    class ContactList
    {
        static void Main()
        {
            List<string> contacts = Console.ReadLine()
                .Split(" ")
                .ToList();

            List<string> exportPrint = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                string[] splitedInput = input.Split(" ");
                string command = splitedInput[0];

                switch (command)
                {
                    case "Add":

                        string contact = splitedInput[1];
                        int index = int.Parse(splitedInput[2]);

                        if (!contacts.Contains(contact))
                        {
                            contacts.Add(contact);
                        }

                        else
                        {
                            if (index >= 0 && index < contacts.Count)
                            {
                                contacts.Insert(index, contact);
                            }
                        }


                        break;

                    case "Remove":

                        index = int.Parse(splitedInput[1]);

                        if (index >= 0 && index < contacts.Count)
                        {
                            contacts.RemoveAt(index);
                        }

                        break;

                    case "Export":

                        int startIndex = int.Parse(splitedInput[1]);
                        int count = int.Parse(splitedInput[2]);

                        if (startIndex >= 0 && startIndex < contacts.Count() && count > 0)
                        {
                            if (count >= contacts.Count || count <= 0)
                            {
                                count = contacts.Count;
                            }

                            for (int i = startIndex; i < count; i++)
                            {
                                exportPrint.Add(contacts[i]);
                            }

                            Console.WriteLine(string.Join(" ", exportPrint));
                            exportPrint.Clear();
                        }

                        break;

                    case "Print":

                        string secondCommand = splitedInput[1];

                        if (secondCommand == "Normal")
                        {
                            Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");

                            return;
                        }

                        else if (secondCommand == "Reversed")
                        {
                            contacts.Reverse();

                            Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");

                            return;
                        }


                        break;
                }

            }
        }
    }
}
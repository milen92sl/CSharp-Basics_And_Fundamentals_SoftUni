using System;
using System.Collections.Generic;
using System.Linq;
namespace TaskPlanner
{
    class Program
    {
        static int CountIncomplete(List<string> list)
        {
            int incompletedTasks = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != "0" && list[i] != "-1")
                {
                    incompletedTasks++;
                }
            }
            return incompletedTasks;
        }
        static int CountCompleted(List<string> list)
        {
            int completedTasks = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "0")
                {
                    completedTasks++;
                }
            }
            return completedTasks;
        }
        static int CountDrop(List<string> list)
        {
            int dropElements = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "-1")
                {
                    dropElements++;
                }
            }
            return dropElements;
        }
        static List<string> Drop(List<string> list, int index)
        {
            if (index >= 0 && index <= list.Count)
            {
                list.RemoveAt(index);
                list.Insert(index, "-1");
            }
            return list;
        }
        static List<string> Change(List<string> list, int index, string value)
        {
            if (index >= 0 && index <= list.Count)
            {
                list.RemoveAt(index);
                list.Insert(index, value);
            }
            return list;
        }
        static List<string> Complete(List<string> list, int index)
        {
            if (index >= 0 && index <= list.Count)
            {
                list.RemoveAt(index);
                list.Insert(index, "0");
            }
            return list;
        }
        static void Main()
        {
            List<string> taskList = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] manipulation = command.Split().ToArray();
                switch (manipulation[0])
                {
                    case "Complete":
                        int index = int.Parse(manipulation[1]);
                        taskList = Complete(taskList, index);
                        break;
                    case "Change":
                        index = int.Parse(manipulation[1]);
                        string value = manipulation[2];
                        taskList = Change(taskList, index, value);
                        break;
                    case "Drop":
                        index = int.Parse(manipulation[1]);
                        taskList = Drop(taskList, index);
                        break;
                    default:
                    case "Count":
                        if (manipulation[1] == "Dropped")
                        {
                            Console.WriteLine(CountDrop(taskList));
                        }
                        else if (manipulation[1] == "Completed")
                        {
                            Console.WriteLine(CountCompleted(taskList));
                        }
                        else if (manipulation[1] == "Incomplete")
                        {
                            Console.WriteLine(CountIncomplete(taskList));
                        }
                        break;
                }
                command = Console.ReadLine();
            }

            foreach (string item in taskList)
            {
                if (item != "0" && item != "-1")
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gaus_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ReadList();
            for (int i = 0; i < list.Count / 2; i++)
            {
                Console.Write(list[i] + list[list.Count - 1 - i] + " ");
            }
            if (list.Count % 2 == 1)
            {
                Console.Write(list[list.Count / 2]);
            }
        }
        //static void PrintList(List<int> list)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine(list[i]);
        //    }
        //}
        static List<int> ReadList()
        {

            List<int> list = new List<int>();
            string[] elements = Console.ReadLine().Split();
            for (int i = 0; i < elements.Length; i++)
            {
                list.Add(int.Parse(elements[i]));
            }
            return list;
        }
    }
}


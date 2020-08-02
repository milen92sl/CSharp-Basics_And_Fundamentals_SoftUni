using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> materiaRep = new Dictionary<string, long>();

            string product;
            while ((product = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!materiaRep.ContainsKey(product))
                {
                    materiaRep[product] = 0;

                }
                materiaRep[product] += quantity;
            }

            foreach (var kvp in materiaRep)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

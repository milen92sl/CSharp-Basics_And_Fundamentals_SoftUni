using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> product = new List<string>();

            for (int i = 0; i < n ; i++)
            {
                string currentProduct = Console.ReadLine();
                product.Add(currentProduct);
            }

            product.Sort();

            for (int i = 0; i < product.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{product[i]}");
            }
        }

    }
}

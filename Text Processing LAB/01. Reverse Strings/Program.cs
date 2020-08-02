using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            

            while (line != "end")
            {
                line = Console.ReadLine();
                string reversed = string.Empty;
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversed += line[i];
                }
                if (line == "end")
                {
                    return;
                }

                Console.WriteLine($"{line} = {reversed}");
            }
            
            
        }
    }
}


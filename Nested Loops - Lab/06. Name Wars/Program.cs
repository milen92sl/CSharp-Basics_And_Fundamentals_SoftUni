using System;

namespace _06._Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputName = Console.ReadLine();
            string bestName = string.Empty;
            int bestScope = int.MinValue;

            while (inputName != "STOP")
            {
                int currentScope = 0;
                string currentName = string.Empty;
               
                for (int i = 0; i < inputName.Length; i++)
                {
                    currentScope += (int)inputName[i];
                    currentName += inputName[i];
                }
                if (currentScope > bestScope)
                {
                    bestScope = currentScope;
                    bestName = currentName;

                }
                inputName = Console.ReadLine();

            }

            Console.WriteLine($"Winner is {bestName} - {bestScope}!");
        }
    }
}

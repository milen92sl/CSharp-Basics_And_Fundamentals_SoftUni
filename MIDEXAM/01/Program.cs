using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string input = string.Empty;
            int distance;
            int wins = 0;
            while (input != "End of battle")
            {
                input = Console.ReadLine();
                if (input != "End of battle")
                {
                    distance = int.Parse(input);

                    if (initialEnergy > 0)
                    {
                        
                        if (wins % 3 == 0)
                        {
                            initialEnergy += wins;
                        }
                        
                    }
                    if (initialEnergy < distance)
                    {
                        
                        Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {Math.Abs(initialEnergy)} energy");
                        return;
                    }
                    
                    initialEnergy -= distance;
                    wins++;

                }
            }
            Console.WriteLine($"Won battles: {wins}. Energy left: {initialEnergy}");
        }
    }
}

using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int totalPieces = w * l;
            string input = Console.ReadLine();

            while (input != "STOP")
            {

                totalPieces -= int.Parse(input);
                if (totalPieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
                    break;

                }
                
                input = Console.ReadLine();

            }
            if (input == "STOP")
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
        }
    }
}

using System;

namespace _04._Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoints = int.Parse(Console.ReadLine());

            int score = 0;
            int counter = 0;

            while (startPoints > score)
            {
                string dartsSector = Console.ReadLine();
                counter++;

                if (dartsSector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {counter} moves!");
                    break;
                }

                int points = int.Parse(Console.ReadLine());

                if (dartsSector == "double ring")
                {
                    score += points * 2;
                }
                else if (dartsSector == "triple ring")
                {
                    score += points * 3;
                }
                else if (dartsSector == "number section")
                {
                    score += points;
                }
                if (startPoints - score == 0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {counter} moves!");
                }
                else if (startPoints - score < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {score - startPoints}.");
                }


            }



        }
    }
}
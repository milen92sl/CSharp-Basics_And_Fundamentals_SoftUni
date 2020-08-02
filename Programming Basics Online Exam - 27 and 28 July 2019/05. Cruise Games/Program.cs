using System;

namespace _05._Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();
            int countGames = int.Parse(Console.ReadLine());

            double tempPointVolley = 0;
            double tempPointTenis = 0;
            double tempPointBadminton = 0;
            double sumGameVoley = 0;
            double sumGameTenis = 0;
            double sumGameBadm = 0;

            for (int i = 0; i < countGames; i++)
            {
                string nameGame = Console.ReadLine();
                double countPoints = double.Parse(Console.ReadLine());

                if (nameGame == "volleyball")
                {
                    tempPointVolley += countPoints * 1.07;
                    sumGameVoley++;
                }
                else if (nameGame == "tennis")
                {
                    tempPointTenis += countPoints * 1.05;
                    sumGameTenis++;
                }
                else if (nameGame == "badminton")
                {
                    tempPointBadminton += countPoints * 1.02;
                    sumGameBadm++;
                }
            }
            double sumPoint = Math.Floor(tempPointVolley + tempPointBadminton + tempPointTenis);
            tempPointVolley = Math.Floor(tempPointVolley / sumGameVoley);
            tempPointTenis = Math.Floor(tempPointTenis / sumGameTenis);
            tempPointBadminton = Math.Floor(tempPointBadminton / sumGameBadm);

            bool isWinner = tempPointBadminton >= 75 && tempPointTenis >= 75 && tempPointVolley >= 75;
            if (isWinner)
            {
                Console.WriteLine($"Congratulations, {namePlayer}! You won the cruise games with {sumPoint} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {namePlayer}, you lost. Your points are only {sumPoint}.");
            }

        }
    }
}
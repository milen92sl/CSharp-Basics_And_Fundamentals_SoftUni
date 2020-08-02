using System;
using System.Numerics;
namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger count = BigInteger.Parse(Console.ReadLine());
            BigInteger bestValue = 0;
            BigInteger bestsnowBallSnow = 0;
            BigInteger bestsnowBallTime = 0;
            BigInteger bestsnowBallQuality = 0;


            for (BigInteger i = 0; i < count; i++)
            {
                BigInteger snowBallSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowBallTime = BigInteger.Parse(Console.ReadLine());
                BigInteger snowBallQuality = BigInteger.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snowBallSnow / snowBallTime),(int) snowBallQuality);

                if (value > bestValue)
                {
                    bestValue = value;
                    bestsnowBallSnow = snowBallSnow;
                    bestsnowBallTime = snowBallTime;
                    bestsnowBallQuality = snowBallQuality;



                }
            }
            Console.WriteLine($"{bestsnowBallSnow} : {bestsnowBallTime} = {bestValue} ({bestsnowBallQuality})");
        }
    }
}

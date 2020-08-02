using System;

namespace _07._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int etaji = int.Parse(Console.ReadLine());
            int stai = int.Parse(Console.ReadLine());
            string vid = "";


            for (int i = etaji; i >= 1; i--)
            {

                for (int j = 0; j < stai; j++)
                {
                    if (etaji == i)
                    {
                        vid = "L";
                    }
                    else if (i % 2 == 0)
                    {
                        vid = "O";
                    }
                    else
                    {
                        vid = "A";
                    }
                    Console.Write($"{vid}{i}{j} ");

                }
                Console.WriteLine("");
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < count; i++)
            {


                string[] inputInfo = Console.ReadLine().Split(' ');

                string typeList = inputInfo[0];
                string name = inputInfo[1];
                string time = inputInfo[2];

                Song song = new Song();
                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string targetListType = Console.ReadLine();
            foreach (Song currentSong in songs)
            {
                if (currentSong.TypeList == targetListType)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }

        }
    }
}
using _04._Songs;
using System;
using System.Collections.Generic;

namespace _04._Songs
{
    class Song
    {
        public string TypeList { get; internal set; }

        public string Name { get; internal set; }

        public string Time { get; internal set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < count; i++)
            {


                string[] inputInfo = Console.ReadLine().Split('_');

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

            if (targetListType == "all")
            {
                foreach (Song currentSong in songs)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
            else
            {
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

}

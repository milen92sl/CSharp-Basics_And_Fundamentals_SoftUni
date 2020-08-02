using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> likes = new Dictionary<string, int>();
            Dictionary<string, int> comments = new Dictionary<string, int>();
            while (input != "Log out ")
            {
                string[] tokens = input.Split(" ");

                string command = tokens[0];
                string username = tokens[1];

                if (command == "New follower")
                {
                    if (!likes.ContainsKey(username))
                    {
                        likes.Add(username, 0);
                        comments.Add(username, 0);
                    }
                }
                if (command == "Like")
                {
                    int countLikes = int.Parse(tokens[2]);

                    if (!likes.ContainsKey(username))
                    {
                        likes.Add(username, 0);
                        comments.Add(username, 0);
                    }
                    
                }
                if (command == "Comment")
                {
                    int countComments = int.Parse(tokens[2]);

                    if (comments.ContainsKey(username))
                    {
                        likes.Add(username, 0);
                        comments.Add(username, 0);
                    }
                    comments[username] += 1;
                }
                if (command == "Blocked")
                {
                    if (likes.ContainsKey(username))
                    {
                        likes.Remove(username);
                        comments.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }
                Console.WriteLine($"{likes.Count} followers");
                foreach (KeyValuePair<string, int> kvpLikes in likes.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    username = kvpLikes.Key;
                    int likesCount = kvpLikes.Value;
                    int commentsCount = comments[username];
                    Console.WriteLine($"{username}: {likesCount + commentsCount}");
                }

                input = Console.ReadLine();

            }
        }
    }
}

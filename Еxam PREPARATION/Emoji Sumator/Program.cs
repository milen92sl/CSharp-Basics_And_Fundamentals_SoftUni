using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Emoji_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ")
                .Where(x => x.Contains(":"))
                .ToList();
            int[] asciiCodes = Console.ReadLine()
                .Split(":")
                .Select(int.Parse)
                .ToArray();

            string emojiCode = ":";

            for (int i = 0; i < asciiCodes.Length; i++)
            {
                emojiCode += (char)asciiCodes[i];

            }
            emojiCode += ":";

            
            string pattern = @"^(?<emoji>:(?<emojiValue>[a-z]{4,}):)$";

            int totalEmojiPower = 0;
            List<string> validEmojis = new List<string>();

            foreach (var currentEmoji in words)
            {
                
                if (currentEmoji.Contains(",")
                    || currentEmoji.Contains("!")
                    || currentEmoji.Contains("?")
                    || currentEmoji.Contains("."))
                {
                    pattern = @"^(?<emoji>:(?<emojiValue>[a-z]{4,}):)(,|\.|!|\?)$";
                }
                Match match = Regex.Match(currentEmoji, pattern);

                if (match.Success)
                {
                    
                    string valueOfEmoji = match.Groups["emoji"].Value;
                    foreach (var emoji in currentEmoji)
                    {


                        foreach (var symbol in valueOfEmoji)
                        {
                            if (symbol != ':')
                            {
                                totalEmojiPower += symbol;
                            }

                        }
                        validEmojis.Add(match.Groups["emoji"].Value);
                    }
                }
                if (validEmojis.Contains(emojiCode))
                {
                    totalEmojiPower *= 2;
                }

                if (validEmojis.Any())
                {
                    Console.WriteLine($"Emojis found: {string.Join(", ", validEmojis)}");
                }
                Console.WriteLine($"Total Emoji Power {totalEmojiPower}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(x => int.Parse(x)).OrderByDescending(x => x).ToList();
            for (int i = 0; i < (nums.Count < 3 ? nums.Count : 3); i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}

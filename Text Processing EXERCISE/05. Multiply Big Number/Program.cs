using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstNum = Console.ReadLine()
                 .ToCharArray();

            int multiplier = int.Parse(Console.ReadLine());
           
            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            int reminder = 0;

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                char currentCh = firstNum[i];
                int currentNum = int.Parse(currentCh.ToString());

                int sum = (currentNum * multiplier) + reminder;
                sb.Append(sum % 10);
                reminder = sum / 10;
            }

            if (reminder != 0)
            {
                sb.Append(reminder);
            }

            List<char> resultArr = sb.ToString()
                     .Reverse()
                     .ToList();
            RemoveTrailingZeroes(resultArr);

            Console.WriteLine(String.Join("", resultArr));
        }
        private static void RemoveTrailingZeroes(List<char> resultArr)
        {

            if (resultArr[0] == '0')
            {
                int zerosCount = 0;

                for (int j = 0; j < resultArr.Count; j++)
                {
                    if (resultArr[j] != '0')
                    {
                        zerosCount = j;
                    }
                }

                for (int i = 0; i < zerosCount; i++)
                {
                    resultArr.RemoveAt(0);
                }
            }
        }
    }
}

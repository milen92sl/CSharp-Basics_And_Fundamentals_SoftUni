using System;

namespace _13.From_left_to_right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            long greaterNumber = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                string leftHalfNumber = String.Empty;
                string rightHalfNumber = String.Empty;
                bool isFirstNumber = true;
                for (int j = 0; j < input.Length; j++)
                {
                    if (isFirstNumber && input[j] != ' ')
                    {
                        leftHalfNumber += input[j];
                    }
                    else if (!isFirstNumber && input[j] != ' ')
                    {
                        rightHalfNumber += input[j];
                    }
                    else if (input[j] == ' ')
                    {
                        isFirstNumber = false;
                    }
                }

                long firstNumber = long.Parse(leftHalfNumber);
                long secondNumber = long.Parse(rightHalfNumber);

                greaterNumber = Math.Max(firstNumber, secondNumber);

                long sum = 0;

                while (greaterNumber != 0)
                {
                    sum += greaterNumber % 10;
                    greaterNumber /= 10;
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
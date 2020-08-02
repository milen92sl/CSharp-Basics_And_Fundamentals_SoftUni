using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
           
                char sector = char.Parse(Console.ReadLine());
                int numRows = int.Parse(Console.ReadLine());
                int num = int.Parse(Console.ReadLine());
                int counter = 0;


                for (char i = 'A'; i <= sector; i++)
                {

                    for (int a = 1; a <= numRows; a++)
                    {
                        if (a % 2 != 0)
                        {
                            for (int b = 1; b <= num; b++)
                            {
                                char c = (char)(b + 96);
                                Console.WriteLine("{0}{1}{2}", i, a, c);
                                counter++;

                            }
                        }
                        else if (a % 2 == 0)
                        {
                            for (int b = 1; b <= num + 2; b++)
                            {
                                char c = (char)(b + 96);
                                Console.WriteLine("{0}{1}{2}", i, a, c);
                                counter++;
                            }
                        }

                    }
                    numRows++;
                }
                Console.WriteLine("{0}", counter);
            }
        }
    }
    


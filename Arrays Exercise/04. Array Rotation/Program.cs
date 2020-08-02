using System;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.
                ReadLine()
                .Split();
            int count = int.Parse(Console.ReadLine());
            for (int c = 0; c < count; c++)
            {
                string temp = array[0];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];

                }
                array[array.Length - 1] = temp;
            }
            
            Console.WriteLine(string.Join(" ", array));
        }
    }
}

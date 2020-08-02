using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;

           
            char ch1 = char.Parse(Console.ReadLine());
            if (result = Char.IsUpper(ch1))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }

            
            
        }
    }
}

using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int guests = int.Parse(Console.ReadLine());
            double gifts = int.Parse(Console.ReadLine());
           
            double money = 0;
            double electrik = 0;
            double vauchers = 0;
            double others = 0;

            for (int i = 0 ; i <= gifts; i++)
            {

                string category = Console.ReadLine();
                if (category == "A")
                {
                    money++;
                }
                else if (category == "B")
                {
                    electrik++;
                }
                else if (category == "V")
                {
                    vauchers++;
                }
                else if (category == "G")
                {
                    others++;
                }

                
            }
            {
               

            }
            Console.WriteLine("{0:f2}%", money / gifts * 100);
            Console.WriteLine("{0:f2}%", electrik / gifts * 100);
            Console.WriteLine("{0:f2}%", vauchers / gifts * 100);
            Console.WriteLine("{0:f2}%", others / gifts * 100);
            Console.WriteLine("{0:f2}%", gifts / guests * 100);

        }
    }
}
    
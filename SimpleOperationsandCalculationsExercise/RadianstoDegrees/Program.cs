using System;

namespace RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете ъгъл в радиани (rad) и го преобразува в градуси (deg). 
            //Използвайте формулата: градус = радиан * 180 / π.Числото π в C# програми е достъпно чрез Math.PI. 
            //Закръглете резултата до най-близкото цяло число използвайки Math.Round().

            double rad = double.Parse(Console.ReadLine());
            double deg = (rad * 180) / Math.PI;

            Console.WriteLine($"{Math.Round(deg)}");

        }
    }
}

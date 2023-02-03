using System;

namespace _02._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {

            //Напишете програма, която чете ъгъл в радиани (десетично число) и го преобразува в градуси.
            //Използвайте формулата: градус = радиан * 180 / π.
            //Числото π в C# програми е достъпно чрез Math.PI.
            //вход 3.1416


            double radians = double.Parse(Console.ReadLine());

            double degreece = radians * (180 / Math.PI);

            Console.WriteLine(degreece);


        }
    }
}

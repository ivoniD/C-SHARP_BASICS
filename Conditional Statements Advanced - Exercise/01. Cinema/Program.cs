using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //income - Console.WriteLine("{0:f2} leva"
            //•	Premiere – премиерна прожекция, на цена 12.00 лева
            //•	Normal – стандартна прожекция, на цена 7.50 лева.
            //•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

            string screening = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double income = 0.0;

            switch (screening)
            {
                case "Premiere":
                    income = r * c * 12.00;
                    Console.WriteLine($"{income:f2} leva");
                    break;
                case "Normal":
                    income = r * c * 7.50;
                    Console.WriteLine($"{income:f2} leva");
                    break;
                case "Discount":
                    income = r * c * 5.00;
                    Console.WriteLine($"{income:f2} leva");
                    break;
                default:
                    break;
            }

        }
    }
}
using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //Часовете винаги са между 0 и 23
            //минутите винаги са между 0 и 59

            if (minutes < 45)
            {
                minutes = minutes + 15;
                hour = hour;
            }
            else if (minutes >= 45 && hour != 23)
            {
                minutes = minutes + 15 - 60;
                hour = hour + 1;
            }
            else if (minutes >= 45 && hour == 23)
            {
                minutes = minutes + 15 - 60;
                hour = 00;
            }

            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}

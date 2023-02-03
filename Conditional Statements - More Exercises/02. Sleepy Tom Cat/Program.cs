using System;

namespace Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //времето за игра на Том е над нормата 
            //На първия ред отпечатайте: “Tom will run away”
            //На втория ред отпечатайте разликата от нормата : “{H} hours and {M} minutes more for play”

            //времето за игра на Том е под нормата 
            //На първия ред отпечатайте: “Tom sleeps well”
            //На втория ред отпечатайте разликата от нормата: “{H} hours and {M} minutes less for play”

            int holidays = int.Parse(Console.ReadLine());
            double theNormForPlay = 30000;
            int daysOfYear = 365;
            //•	Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
            //•	Когато почива, стопанинът му си играе с него  по 127 минути на ден.

            double workDays = daysOfYear - holidays;
            double playWorkDays = workDays * 63;//21735
            double playHolidays = holidays * 127;//2540
            double playForYear = playWorkDays + playHolidays;//24275


            if (playForYear >= theNormForPlay)
            {
                double difference = playForYear - theNormForPlay; //227
                                                                  //  Console.WriteLine($"difference{difference}");
                double H = (difference / 60);
                H = Math.Floor(H);
                double M = (difference % 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{H} hours and {M} minutes more for play");
            }
            else
            {
                double difference = theNormForPlay - playForYear;
                double H = (difference / 60);
                double M = (difference % 60);
                H = Math.Floor(H);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{H:f0} hours and {M} minutes less for play");
            }
        }
    }
}

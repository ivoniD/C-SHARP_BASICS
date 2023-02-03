using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"You have enough time to watch {име на сериал} and left with {останало време} minutes free time." 
            //"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
            //Времето да се закръгли до най-близкото цяло число нагоре.

            string series = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int lunchBreakTime = int.Parse(Console.ReadLine());

            //Времето за обяд ще бъде 1/8 от времето за почивка
            //времето за отдих ще бъде 1 / 4 от времето за почивка
            double lunchTime = lunchBreakTime * 0.125; //12
            double restTime = lunchBreakTime * 0.25; //24

            double freeTime = lunchBreakTime - lunchTime - restTime; //60
            //double difference = freeTime - episodeTime;
            if (freeTime >= episodeTime)
            {
                double difference = freeTime - episodeTime;
                difference = Math.Ceiling(difference);
                Console.WriteLine($"You have enough time to watch {series} and left with {difference} minutes free time.");
            }
            else
            {
                double difference = episodeTime - freeTime;
                difference = Math.Ceiling(difference);
                Console.WriteLine($"You don't have enough time to watch {series}, you need {difference} more minutes.");
            }

        }

    }
}

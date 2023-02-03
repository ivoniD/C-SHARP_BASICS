using System;

namespace exam___02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            //	" Yes! The new record is {времето на Георги} seconds." -	Ако Георги е подобрил рекорда 
            //	"No! He was {недостигащите секунди} seconds slower." - 	Ако НЕ е подобрил рекорда 

            //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            double record = double.Parse(Console.ReadLine());
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            double distanceMeters = double.Parse(Console.ReadLine());
            //3.Времето в секунди, за което изкачва 1 м. – реално число в интервала[0.00 … 1000.00]
            double timePer1Meter = double.Parse(Console.ReadLine());

            double GeorgiTime = distanceMeters * timePer1Meter; //1340 * 3.23 = 4328.20 сек.
            double delayTimes = Math.Floor(distanceMeters / 50);

            double delay = delayTimes * 30; //26 * 30 = 780 сек.

            double GeorgiFinTime = GeorgiTime + delay; //4328.20 + 780 = 5108.20 сек.

            if (GeorgiFinTime < record)
            {
                Console.WriteLine($" Yes! The new record is {GeorgiFinTime:f2} seconds.");

            }
            else
            {
                Console.WriteLine($"No! He was {Math.Abs(record - GeorgiFinTime):f2} seconds slower.");
            }

        }
    }
}

using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Yes, he succeeded! The new world record is {времето на Иван} seconds." - времето е по-малко от рекорда
            //"No, he failed! He was {недостигащите секунди} seconds slower." - времето е по-голямо или равно на рекорда
            // до втори знак след запетая
            double secRecord = double.Parse(Console.ReadLine()); //задачата //рекордът в сек, който трябва да подобри
            double meters = double.Parse(Console.ReadLine()); //разстоянието в метри, което трябва да преплува 
            double secPerOneMeter = double.Parse(Console.ReadLine());//времето в сек, за което плува разстояние от 1 м

            // съпротивлението на водата го забавя на всеки 15 м.с 12.5 секунди
            //колко пъти ще се забави - резултатът трябва да се закръгли надолу до най-близкото цяло число

            double secondsIvan = meters * secPerOneMeter;//
            double numDelay = meters / 15;
            numDelay = Math.Floor(numDelay);
            double delay = numDelay * 12.5;
            double IvanTime = secondsIvan + delay;


            if (secRecord > IvanTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {IvanTime:f2} seconds.");
            }
            else if (IvanTime >= secRecord)
            {
                double difference = IvanTime - secRecord;
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }




        }
    }
}
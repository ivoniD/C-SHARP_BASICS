using System;

namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----произведеното вино е по-малко от нужното - (закръгленo към по-ниско цяло число)
            //It will be a tough winter! More {недостигащо вино} liters wine needed. 
            //----произведеното вино е колкото или повече от нужното - (закръглен към по-ниско цяло число)
            //Good harvest this year! Total wine: {общо вино} liters.
            //{Оставащо вино} liters left -> {вино за 1 работник} liters per person. - (2те да се закр към по-голямото цяло)

            int X = int.Parse(Console.ReadLine()); // кв.м е лозето 
            double Y = double.Parse(Console.ReadLine()); // kg грозде за един кв.м 
            int Z = int.Parse(Console.ReadLine()); //нужни литри вино 
            int workers = int.Parse(Console.ReadLine()); //брой работници 

            double allProduction = X * Y;
            double grapesProductionForWine = allProduction * 0.4;
            double wineLiters = grapesProductionForWine / 2.5;

            if (Z > wineLiters)
            {
                double difference = Z - wineLiters;
                difference = Math.Floor(difference);
                Console.WriteLine($"It will be a tough winter! More {difference} liters wine needed.");
            }
            else
            {
                double difference = wineLiters - Z;
                double winePerWorker = difference / workers;
                difference = Math.Ceiling(difference);
                winePerWorker = Math.Ceiling(winePerWorker);
                wineLiters = Math.Floor(wineLiters);
                Console.WriteLine($"Good harvest this year! Total wine: {wineLiters} liters.");
                Console.WriteLine($"{difference} liters left -> {winePerWorker} liters per person.");
            }



        }
    }
}

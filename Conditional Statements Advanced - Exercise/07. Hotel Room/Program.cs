using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double apPrice = 0.0;
            double stPrice = 0.0;

            // --Май и октомври - Студио – 50 лв / Апартамент – 65
            // Юни и септември - Студио – 75.20 / Апартамент – 68.70 
            // Юли и август - Студио – 76  / Апартамент – 77 

            //----Studio > 7 night - през май и октомври : 5% намаление
            //----Studio > 14 night - през май и октомври : 30% намаление
            //Studio > 14 night - юни и септември: 20 % намаление

            //---Apartment > 14 нощувки, без значение от месеца : 10% намаление
            //May*, June*, July, August, September* или October*
            if (month == "May" || month == "October")
            {
                stPrice = nights * 50;
                apPrice = nights * 65;
                if (nights > 14)
                {
                    stPrice = stPrice - (stPrice * 0.3);
                    apPrice = apPrice - (apPrice * 0.1);
                }
                else if (nights > 7)
                {
                    stPrice = stPrice - (stPrice * 0.05);
                }
            }
            else if (month == "June" || month == "September")
            {
                stPrice = nights * 75.20;
                apPrice = nights * 68.70;
                if (nights > 14)
                {
                    stPrice = stPrice - (stPrice * 0.2);
                    apPrice = apPrice - (apPrice * 0.1);
                }
            }
            else if (month == "July" || month == "August")
            {
                stPrice = nights * 76;
                apPrice = nights * 77;

                if (nights > 14)
                {
                    apPrice = apPrice - (apPrice * 0.1);
                }

            }
            //“Apartment: {цена за целият престой} lv.”
            //“Studio: {цена за целият престой} lv.“
            Console.WriteLine($"Apartment: {apPrice:f2} lv.");
            Console.WriteLine($"Studio: {stPrice:f2} lv.");

        }
    }
}
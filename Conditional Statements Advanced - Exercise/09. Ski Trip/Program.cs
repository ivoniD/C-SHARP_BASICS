using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.
            // room for one person - 18 
            // apartment - 25
            // president apartment 35
            double days = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();
            //11 дни = 10 нощувки
            double price = 0.0;
            double nights = days - 1;
            double nightsPrice = 0;
            //вид помещение 	        по-малко от 10 дни	         между 10 и 15 дни	           повече от 15 дни
            //room for one person       не ползва намаление          не ползва намаление          не ползва намаление
            //apartment                 30 % от крайната цена        35 % от крайната цена        50 % от крайната цена
            //president apartment      10 % от крайната цена        15 % от крайната цена        20 % от крайната цена


            if (type == "room for one person")
            {
                price = 18 * nights;
                //if (days < 10 || days >= 10 && days < 15 || days >= 15)
                //{
                //    price = 18 * nights;
                //}
            }
            else if (type == "apartment")
            {

                if (days < 10)
                {
                    nightsPrice = 25 * nights;
                    price = nightsPrice - nightsPrice * 0.3;
                }
                else if (days >= 10 && days < 15)
                {
                    nightsPrice = 25 * nights;
                    price = nightsPrice - nightsPrice * 0.35;
                }
                else if (days >= 15)
                {
                    nightsPrice = 25 * nights;
                    price = nightsPrice - nightsPrice * 0.50;
                }
            }
            else if (type == "president apartment")
            {

                if (days < 10)
                {
                    nightsPrice = 35 * nights;
                    price = nightsPrice - nightsPrice * 0.1;
                }
                else if (days >= 10 && days < 15)
                {
                    nightsPrice = 35 * nights;
                    price = nightsPrice - nightsPrice * 0.15;
                }
                else if (days >= 15)
                {
                    nightsPrice = 35 * nights;
                    price = nightsPrice - nightsPrice * 0.20;
                }
            }
            if (grade == "positive")
            //positive - 25% от цената приспада
            //negative - 10% от цената приспада
            {
                price = price + (price * 0.25);
            }
            else if (grade == "negative")
            {
                price = price - (price * 0.1);
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
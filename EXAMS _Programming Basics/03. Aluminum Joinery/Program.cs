using System;

namespace _03AluminumJourney
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine()); // брой на поръчнаните дограми  
            string kind = Console.ReadLine(); //вид на дограмите 
            string deliveryOrNot = Console.ReadLine(); //с доставка или не

            double totalPrice = 0.00;

            if (num <= 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            if (kind == "90X130")
            {
                totalPrice = num * 110;
                if (num > 30 && num <= 60)
                {
                    totalPrice = 0.95 * (num * 110);
                }
                if (num > 60)
                {
                    totalPrice = 0.92 * (num * 110);
                }
            }
            else if (kind == "100X150")
            {
                totalPrice = num * 140;
                if (num > 40 && num <= 80)
                {
                    totalPrice = 0.94 * (num * 140);
                }
                if (num > 80)
                {
                    totalPrice = 0.90 * (num * 140);
                }
            }
            else if (kind == "130X180")
            {
                totalPrice = num * 190;
                if (num > 20 && num <= 50)
                {
                    totalPrice = 0.93 * (num * 190);
                }
                if (num > 50)
                {
                    totalPrice = 0.88 * (num * 190);
                }
            }
            else if (kind == "200X300")
            {
                totalPrice = num * 250;
                if (num > 25 && num <= 50)
                {
                    totalPrice = 0.91 * (num * 250);
                }
                if (num > 50)
                {
                    totalPrice = 0.86 * (num * 250);
                }
            }

            if (deliveryOrNot == "With delivery")
            {
                totalPrice += 60;
            }

            if (num > 99)
            {
                totalPrice *= 0.96;
            }
            Console.WriteLine($"{totalPrice:f2} BGN");
        }
    }
}

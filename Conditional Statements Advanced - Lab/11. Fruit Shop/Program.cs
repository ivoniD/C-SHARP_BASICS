using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Monday / Tuesday / Wednesday / Thursday / Friday

            //Saturday / Sunday

            // закръглен с 2 цифри след десетичната точка
            // невалидно име на плод да се отпечата "error"
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                //fruitbanana  apple orange  grapefruit   kiwi    pineapple   grapes
                // 2.50    1.20    0.85    1.45      2.70      5.50       3.85
                {
                    price = quantity * 2.50;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "apple")
                {
                    price = quantity * 1.20;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "orange")
                {
                    price = quantity * 0.85;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = quantity * 1.45;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = quantity * 2.70;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = quantity * 5.50;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = quantity * 3.85;
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            // banana  apple    orange    grapefruit   kiwi    pineapple   grapes
            //   2.70    1.25    0.90      1.60         3.00    5.60       4.20
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.70;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "apple")
                {
                    price = quantity * 1.25;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "orange")
                {
                    price = quantity * 0.90;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = quantity * 1.60;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = quantity * 3.00;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = quantity * 5.60;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = quantity * 4.20;
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if ((day != "Monday" || day != "Tuesday" || day != "Wednesday" || day != "Thursday" || day != "Friday" || day != "Saturday" || day != "Sunday") &&
                (fruit != "banana" || fruit != "apple" || fruit != "orange" || fruit != "grapefruit" || fruit != "kiwi" || fruit != "pineapple" || fruit != "grapes"))
            {
                Console.WriteLine("error");
            }
        }
    }
}
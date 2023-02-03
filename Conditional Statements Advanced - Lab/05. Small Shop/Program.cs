using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //total price ?

            //град-прод coffee  water	 beer	sweets	peanuts
            //Sofia     0.50    0.80    1.20    1.45    1.60

            //продукт (низ), град (низ) и количество (десетично число)
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double totalprice = 0.0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    totalprice = quantity * 0.50;
                    Console.WriteLine(totalprice);
                }
                else if (product == "water")
                {
                    totalprice = quantity * 0.80;
                    Console.WriteLine(totalprice);
                }
                else if (product == "beer")
                {
                    totalprice = quantity * 1.20;
                    Console.WriteLine(totalprice);
                }
                else if (product == "sweets")
                {
                    totalprice = quantity * 1.45;
                    Console.WriteLine(totalprice);
                }
                else if (product == "peanuts")
                {
                    totalprice = quantity * 1.60;
                    Console.WriteLine(totalprice);
                }
            }
            else if (town == "Plovdiv")
            //            //Plovdiv    0.40    0.70    1.15    1.30    1.50
            {
                if (product == "coffee")
                {
                    totalprice = quantity * 0.40;
                    Console.WriteLine(totalprice);
                }
                else if (product == "water")
                {
                    totalprice = quantity * 0.70;
                    Console.WriteLine(totalprice);
                }
                else if (product == "beer")
                {
                    totalprice = quantity * 1.15;
                    Console.WriteLine(totalprice);
                }
                else if (product == "sweets")
                {
                    totalprice = quantity * 1.30;
                    Console.WriteLine(totalprice);
                }
                else if (product == "peanuts")
                {
                    totalprice = quantity * 1.50;
                    Console.WriteLine(totalprice);
                }
            }
            else if (town == "Varna")
            ////Varna       0.45    0.70    1.10    1.35    1.55
            {
                if (product == "coffee")
                {
                    totalprice = quantity * 0.45;
                    Console.WriteLine(totalprice);
                }
                else if (product == "water")
                {
                    totalprice = quantity * 0.70;
                    Console.WriteLine(totalprice);
                }
                else if (product == "beer")
                {
                    totalprice = quantity * 1.10;
                    Console.WriteLine(totalprice);
                }
                else if (product == "sweets")
                {
                    totalprice = quantity * 1.35;
                    Console.WriteLine(totalprice);
                }
                else if (product == "peanuts")
                {
                    totalprice = quantity * 1.55;
                    Console.WriteLine(totalprice);
                }
            }
        }

    }
}
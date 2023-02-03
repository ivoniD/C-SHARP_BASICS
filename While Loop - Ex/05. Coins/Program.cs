using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 = 200// 1 = 100 // 0.50 // 0.20 // 0.10 // 0.05 // 0.02 // 0.01
            //1.23 * 100 = 123

            int counter = 0;
            double input = double.Parse(Console.ReadLine());
            double money = input * 100;

            while (money != 0)
            {
                if (money >= 200)
                {
                    counter++;
                    money -= 200;
                }
                else if (money >= 100)
                {
                    counter++;
                    money -= 100;
                }
                else if (money >= 50)
                {
                    counter++;
                    money -= 50;
                }
                else if (money >= 20)
                {
                    counter++;
                    money -= 20;
                }
                else if (money >= 10)
                {
                    counter++;
                    money -= 10;
                }
                else if (money >= 5)
                {
                    counter++;
                    money -= 5;
                }
                else if (money >= 2)
                {
                    counter++;
                    money -= 2;
                }
                else if (money >= 1)
                {
                    counter++;
                    money -= 1;
                }
                else
                {
                    break;
                }
                //input = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(counter);
        }
    }
}

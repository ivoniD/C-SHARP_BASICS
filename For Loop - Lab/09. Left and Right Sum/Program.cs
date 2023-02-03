using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //чете 2*n-на брой цели числа, подадени от потребителя
            //и проверява дали сумата на първите n числа (лява) е равна на сумата на вторите n числа (дясна)

            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sumLeft = sumLeft + num;
            }

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sumRight = sumRight + num;
            }
            //" Yes, sum = " + сумата; иначе печата " No, diff = " + разликата
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
        }
    }
}
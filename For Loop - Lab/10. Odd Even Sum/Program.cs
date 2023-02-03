using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //n-на брой цели числа, подадени от потребителя и проверява
            //дали сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции

            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumOdd = sumOdd + num;
                }
                else
                {
                    sumEven = sumEven + num;
                }

            }
            if (sumOdd == sumEven)
            {
                // Yes" и на нов ред "Sum = " + сумата; 
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOdd}");
            }
            else
            {
                Console.WriteLine("No");
                //Diff = " + разликата. 
                int diff = sumOdd - sumEven;
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }
        }
    }
}
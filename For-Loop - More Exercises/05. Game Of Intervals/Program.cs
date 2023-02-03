using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine()); // колко хода ще има
            double result = 0;
            double n0 = 0;
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            double n4 = 0;
            double n5 = 0;
            // процент 
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine()); // 
                if (num < 0 || num > 50)//•	Невалидно число  резултата се дели на 2 (n5) // 2
                {
                    n5++;
                    result = result / 2;
                }
                else if (num >= 0 && num <= 9) //•	От 0 до 9  20 % от числото (n0) // 1
                {
                    n0++;
                    result = result + num * 0.2;
                }
                else if (num <= 19) //•	От 10 до 19  30 % от числото (n1) // 1
                {
                    n1++;
                    result = result + (num * 0.3);
                }
                else if (num <= 29)//•	От 20 до 29  40 % от числото (n2) // 2
                {
                    n2++;
                    result = result + (num * 0.4);
                }
                else if (num <= 39)//•	От 30 до 39  50 точки (n3) // 1
                {
                    n3++;
                    result = result + 50;
                }
                else if (num <= 50)//•	От 40 до 50  100 точки (n4) // 3
                {
                    n4++;
                    result = result + 100;
                }

            }
            double allNum = n0 + n1 + n2 + n3 + n4 + n5;
            double prN0 = n0 / allNum * 100; // 10
            double prN1 = n1 / allNum * 100;//10
            double prN2 = n2 / allNum * 100;//20
            double prN3 = n3 / allNum * 100;//10
            double prN4 = n4 / allNum * 100;//30
            double prN5 = n5 / allNum * 100;//20
            Console.WriteLine($"{result:f2}"); //295.80
            Console.WriteLine($"From 0 to 9: {prN0:f2}%");
            Console.WriteLine($"From 10 to 19: {prN1:f2}%");
            Console.WriteLine($"From 20 to 29: {prN2:f2}%");
            Console.WriteLine($"From 30 to 39: {prN3:f2}%");
            Console.WriteLine($"From 40 to 50: {prN4:f2}%");
            Console.WriteLine($"Invalid numbers: {prN5:f2}%");
        }
    }
}

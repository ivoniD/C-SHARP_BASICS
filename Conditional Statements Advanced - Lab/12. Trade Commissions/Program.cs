using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            //изчислява и извежда размера на търговската комисионна -2 цифри след десетичната точка
            //невалиден град или обем на продажбите (отрицателно число) да се отпечата "error"
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            //Sofia
            //(sales >=0 && sales <=500) - 5% / (sales>500 && sales<=1000) - 7% /
            //(sales>1000<=10000) - 8% / (sales >10000) -12%

            if (town == "Sofia")
            {
                if (sales < 0)
                {
                    Console.WriteLine("error");
                }
                else if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.05;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.07;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.08;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.12;
                    Console.WriteLine($"{commission:f2}");
                }
            }
            else if (town == "Varna")
            //(sales >=0 && sales <=500) - 4.5% / (sales>500 && sales<=1000) - 7.5% /
            //(sales>1000<=10000) - 10% / (sales >10000) -13%
            {
                if (sales < 0)
                {
                    Console.WriteLine("error");
                }
                else if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.045;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.075;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.1;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.13;
                    Console.WriteLine($"{commission:f2}");
                }
            }
            else if (town == "Plovdiv")
            //(sales >=0 && sales <=500) - 5.5% / (sales>500 && sales<=1000) - 8% /
            //(sales>1000<=10000) - 12% / (sales >10000) -14.5%
            {
                if (sales < 0)
                {
                    Console.WriteLine("error");
                }
                else if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.055;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.08;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.12;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.145;
                    Console.WriteLine($"{commission:f2}");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

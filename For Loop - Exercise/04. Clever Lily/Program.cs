using System;

namespace _04._Clever_Lily_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	За четните рождени дни (2, 4, 6...n) получава пари. 
            int yearsLili = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double money = 0;

            for (int i = 1; i <= yearsLili; i++)
            {
                if (i % 2 == 0) // 2-10; 4-20; 6-30
                {
                    money = money + (i * 5 - 1);
                }
                else
                {
                    money = money + toyPrice;
                }
            }

            if (money >= laundryPrice)
            {
                Console.WriteLine($"Yes! {(money - laundryPrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(laundryPrice - money):f2}");
            }
        }
    }
}
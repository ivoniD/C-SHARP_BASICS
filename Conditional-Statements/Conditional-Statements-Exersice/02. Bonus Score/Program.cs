using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //числото + бонуса
            int num = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            //•	Ако числото е до 100 включително, бонус точките са 5
            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num > 100 && num <= 1000)//•	Ако числото е по-голямо от 100, бонус т са 20 % от числото
            {
                bonus = num * 0.2;
            }
            else //•	Ако числото е по-голямо от 1000, бонус точките са 10 % от числото
            {
                bonus = num * 0.1;
            }

            if (num % 2 == 0) //За четно число  + 1 т.
            {
                bonus = bonus + 1;
            }
            else if ((num % 10 == 5))// За число, което завършва на 5  +2 т.
            {
                bonus = bonus + 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);

        }
    }
}

using System;

namespace _05._Salary_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double penalty = 0;
            for (int i = 1; i <= n; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook") // 150
                {
                    penalty = penalty + 150;
                }
                else if (site == "Instagram") // 100
                {
                    penalty = penalty + 100;
                }
                else if (site == "Reddit") // 50
                {
                    penalty = penalty + 50;
                }
                if (penalty >= salary)
                {
                    break;
                }
            }
            if (penalty >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary - penalty);
            }
        }
    }
}
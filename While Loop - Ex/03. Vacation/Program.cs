using System;

namespace _03._Vacation_exx
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoneyForExcursion = double.Parse(Console.ReadLine());
            double checkBalance = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int daysCounter = 0;
            while (checkBalance < neededMoneyForExcursion)
            {
                string transType = Console.ReadLine(); //"spend" и "save"
                double moneyTrans = double.Parse(Console.ReadLine()); // сумата, която ще спести / похарчи 
                daysCounter++;
                if (transType == "spend")
                {
                    spendCounter++;
                    checkBalance -= moneyTrans;
                    if (checkBalance < 0)
                    {
                        checkBalance = 0;
                    }
                    if (spendCounter == 5)
                    {
                        break;
                    }
                }
                else if (transType == "save")
                {
                    checkBalance += moneyTrans;
                    spendCounter = 0;
                }
            }
            if (spendCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }

        }
    }
}

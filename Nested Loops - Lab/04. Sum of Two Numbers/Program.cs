using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());    //– начало на интервала
            int secondtNum = int.Parse(Console.ReadLine());  // – край на интервала
            int magictNum = int.Parse(Console.ReadLine());   // – магическото число
            int combinCounter = 0;
            bool flag = false;
            for (int i = firstNum; i <= secondtNum; i++)
            {
                for (int j = firstNum; j <= secondtNum; j++)
                {
                    combinCounter++;
                    if (i + j == magictNum)
                    {
                        Console.WriteLine($"Combination N:{combinCounter} ({i} + {j} = {magictNum})");
                        return;
                    }
                    if (flag == true)
                    {
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            Console.WriteLine($"{combinCounter} combinations - neither equals {magictNum}");
        }
    }
}


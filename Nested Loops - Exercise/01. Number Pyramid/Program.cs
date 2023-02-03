using System;

namespace _01._Number_Pyramid_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло число n, въведено от потребителя, и отпечатва пирамида от числа

            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }



        }
    }
}

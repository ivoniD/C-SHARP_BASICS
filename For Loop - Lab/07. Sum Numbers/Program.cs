﻿using System;

namespace _07._Sum_Numbers_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //чете n - на брой цели числа, въведени от потребителя и ги сумира

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(sum);

        }
    }
}
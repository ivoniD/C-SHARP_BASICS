using System;

namespace deposit_test_3
{
    class Program
    {
        static void Main(string[] args)
        {


            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double sum = deposit + months * ((deposit * percent / 100) / 12);


            Console.WriteLine(sum);
        }
    }
}
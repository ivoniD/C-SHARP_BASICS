using System;

namespace _02._Greater_Number_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма,
            // която чете две цели числа въведени от потребителя и отпечатва по-голямото от двете. 

            double NUM1 = double.Parse(Console.ReadLine());
            double NUM2 = double.Parse(Console.ReadLine());
            if (NUM1 > NUM2)
            {
                Console.WriteLine(NUM1);
            }
            else
            {
                Console.WriteLine(NUM2);
            }

        }
    }
}

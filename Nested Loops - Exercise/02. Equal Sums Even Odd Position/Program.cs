using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());


            for (int i = firstNum; i <= secondNum; i++)
            //сумата от цифрите на четни и нечетни позиции да са равни
            {
                int evensum = 0;
                int oddsum = 0;
                string currentNum = i.ToString();

                for (int k = 0; k < currentNum.Length; k++)
                {
                    if (k % 2 == 0)
                    {
                        evensum += currentNum[k];
                    }
                    else
                    {
                        oddsum += currentNum[k];
                    }
                }
                if (evensum == oddsum)
                {
                    Console.Write(currentNum + " ");
                }
            }

        }
    }
}

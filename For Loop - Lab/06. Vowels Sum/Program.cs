using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //напише програма, която чете текст (стринг), въведен от потребителя,
            //и изчислява и отпечатва сумата от стойностите на гласните букви според таблицата
            // a - 1 ; e-2 ; i-3 ; o-4 ; u-5

            string text = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                switch (letter)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }

            Console.WriteLine(sum);

        }
    }
}
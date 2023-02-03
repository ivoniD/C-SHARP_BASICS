using System;

namespace Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //да се отпечата най-ниската цена за посочения брой километри, форматирана до втория знак 

            //•	Такси-Начална такса: 0.70 -Дневна тарифа: 0.79 - Нощна тарифа: 0.90 
            //•	Автобус. Дневна / нощна тарифа: 0.09 лв. / км. Може да се използва за разстояния минимум 20 км.
            //•	Влак. Дневна / нощна тарифа: 0.06 лв. / км. Може да се използва за разстояния минимум 100 км.

            //Напишете програма, която въвежда броя километри n и период от деня (ден или нощ)
            //и изчислява цената на най-евтиния транспорт.

            int N = int.Parse(Console.ReadLine());//брой километри 
            string DN = Console.ReadLine();//ден или нощ

            double taxiDay = (N * 0.79) + 0.70;
            double taxiNight = (N * 0.90) + 0.70;

            double bus = N * 0.09; // N>20km

            double train = N * 0.06; // N>100km

            if (N < 20 && DN == "day")
            {
                Console.WriteLine($"{taxiDay:f2}");
            }
            else if (N < 20 && DN == "night")
            {
                Console.WriteLine($"{taxiNight:f2}");
            }
            else if (N >= 20 && N < 100)
            {
                Console.WriteLine($"{bus:f2}");
            }
            else
            {
                Console.WriteLine($"{train:f2}");
            }


        }
    }
}

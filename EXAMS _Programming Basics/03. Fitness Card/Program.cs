using System;

namespace exam___03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyWeHave = double.Parse(Console.ReadLine());//•	Сумата, с която разполагаме 
            string gender = Console.ReadLine();//•	Пол - символ('m' за мъж и 'f' за жена)
            int age = int.Parse(Console.ReadLine());//•	Възраст - цяло число в интервала[5…105]
            string sport = Console.ReadLine();//•	Спорт - текст(една от възможностите в таблицата
            double price = 0;
            //Пол         Gym        Boxing      Yoga    Zumba     Dances     Pilates
            //мъж	      $42        $41         $45     $34        $51         $39
            //жена        $35        $37         $42     $31        $53         $37

            if (gender == "m")
            {
                if (sport == "Gym")
                {
                    price = 42;
                }
                else if (sport == "Boxing")
                {
                    price = 41;
                }
                else if (sport == "Yoga")
                {
                    price = 45;
                }
                else if (sport == "Zumba")
                {
                    price = 34;
                }
                else if (sport == "Dances")
                {
                    price = 51;
                }
                else if (sport == "Pilates")
                {
                    price = 39;
                }
            }
            else if (gender == "f")
            {
                if (sport == "Gym")
                {
                    price = 35;
                }
                else if (sport == "Boxing")
                {
                    price = 37;
                }
                else if (sport == "Yoga")
                {
                    price = 42;
                }
                else if (sport == "Zumba")
                {
                    price = 31;
                }
                else if (sport == "Dances")
                {
                    price = 53;
                }
                else if (sport == "Pilates")
                {
                    price = 37;
                }
            }
            //Всички цени на карти за ученици (възраст под 19 години вкл.) са с 20% намаление.
            if (age <= 19)
            {
                price = price - (price * 0.2);
            }

            if (moneyWeHave >= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(price - moneyWeHave):f2} more.");
            }
        }
    }
}

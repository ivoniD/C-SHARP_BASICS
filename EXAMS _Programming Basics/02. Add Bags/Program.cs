using System;

namespace exam___02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBagageOver20 = double.Parse(Console.ReadLine()); // 1.Цената на багаж над 20кг
            double bagageKilograms = double.Parse(Console.ReadLine()); //2.Килограми на багажа
            int dayToTravel = int.Parse(Console.ReadLine()); //3.Дни до пътуването
            int numBagages = int.Parse(Console.ReadLine()); //4.Брой багажи

            double babagPrice = 0;
            //•	повече от 30 дни - цената на багажа се оскъпява с 10 %
            //•	между 7 и 30 дни вкл. -цената на багажа се оскъпява с 15 %
            //•	по - малко от 7 дни - цената на багажа се оскъпява с 40 %
            if (bagageKilograms < 10)
            //•	до 10кг – 20 % от цената на багаж над 20кг
            {
                babagPrice = priceBagageOver20 * 0.2;
                if (dayToTravel > 30)
                //•	повече от 30 дни - цената на багажа се оскъпява с 10 %
                {
                    babagPrice = babagPrice + (babagPrice * 0.1);
                }
                else if (dayToTravel >= 7 && dayToTravel <= 30)
                {
                    babagPrice = babagPrice + (babagPrice * 0.15);
                }
                else if (dayToTravel < 7)
                {
                    babagPrice = babagPrice + (babagPrice * 0.40);
                }
            }
            else if (bagageKilograms <= 20)
            //•	между 10кг и 20кг вкл. – 50 % от цената на багаж над 20кг.
            {
                babagPrice = priceBagageOver20 / 2;
                if (dayToTravel > 30)
                //•	повече от 30 дни - цената на багажа се оскъпява с 10 %
                {
                    babagPrice = babagPrice + (babagPrice * 0.1);
                }
                else if (dayToTravel >= 7 && dayToTravel <= 30)
                {
                    babagPrice = babagPrice + (babagPrice * 0.15);
                }
                else if (dayToTravel < 7)
                {
                    babagPrice = babagPrice + (babagPrice * 0.40);
                }
            }
            else if (bagageKilograms > 20)
            //•	над 20кг – таксата се чете от конзолата
            {
                babagPrice = priceBagageOver20;
                if (dayToTravel > 30)
                //•	повече от 30 дни - цената на багажа се оскъпява с 10 %
                {
                    babagPrice = babagPrice + (babagPrice * 0.1);
                }
                else if (dayToTravel >= 7 && dayToTravel <= 30)
                {
                    babagPrice = babagPrice + (babagPrice * 0.15);
                }
                else if (dayToTravel < 7)
                {
                    babagPrice = babagPrice + (babagPrice * 0.40);
                }
            }

            Console.WriteLine($"The total price of bags is: {(babagPrice * numBagages):f2} lv. ");
        }
    }
}

using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"You have {остатъчен бюджет} leva left!" - •	Ако бюджета е достатъчен
            //"Not enough money! You need {нужна сума} leva more!" - •	Ако сумата надхвърля бюджета
            //до втория знак след десетичната запетая

            double PeterBudget = double.Parse(Console.ReadLine());
            int numVideocard = int.Parse(Console.ReadLine());
            int numProcessor = int.Parse(Console.ReadLine());
            int numRam = int.Parse(Console.ReadLine());

            //Ако броя на видеокартите > процесорите = 15% отстъпка от крайната сметка
            //•	Видеокарта – 250 лв./бр
            //•	Процесор – 35% от цената на закупените видеокарти/бр.
            //•	Рам памет – 10% от цената на закупените видеокарти/бр.

            double videocardPrice = numVideocard * 250;
            double processorPrice = numProcessor * (videocardPrice * 0.35);
            double ramPrice = numRam * (videocardPrice * 0.10);
            double PetersBill = videocardPrice + processorPrice + ramPrice;

            if (numVideocard > numProcessor)
            {
                PetersBill = PetersBill - (PetersBill * 0.15);
            }

            double difference = PeterBudget - PetersBill;

            if (PeterBudget >= PetersBill)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else if (PetersBill > PeterBudget)
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money! You need {difference:f2} leva more!");
            }
        }
    }
}

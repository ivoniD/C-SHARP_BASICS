using System;

namespace exam___04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            //процента на катерачите изкачващи всеки връх
            int groups = int.Parse(Console.ReadLine());
            double allPople = 0;

            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;


            for (int i = 1; i <= groups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                allPople += peopleInGroup;
                if (peopleInGroup <= 5)//•	Група до 5 човека– Мусала
                {
                    musala += peopleInGroup;
                }
                else if (peopleInGroup <= 12)//•	Група от 6 до 12 – Монблан
                {
                    monblan += peopleInGroup;
                }
                else if (peopleInGroup <= 25)//•	Група от 13 до 25 – Килиманджаро
                {
                    kilimandjaro += peopleInGroup;
                }
                else if (peopleInGroup <= 40) //•	Група от 26 до 40 – К2
                {
                    k2 += peopleInGroup;
                }
                else if (peopleInGroup >= 41)//•	Група от 41 или повече – Еверест
                {
                    everest += peopleInGroup;
                }
            }

            double musalaP = (musala / allPople) * 100;
            double monblanP = (monblan / allPople) * 100;
            double kilimandjaroP = (kilimandjaro / allPople) * 100;
            double k2P = (k2 / allPople) * 100;
            double everestP = (everest / allPople) * 100;

            Console.WriteLine($"{musalaP:F2}%");
            Console.WriteLine($"{monblanP:F2}%");
            Console.WriteLine($"{kilimandjaroP:F2}%");
            Console.WriteLine($"{k2P:F2}%");
            Console.WriteLine($"{everestP:F2}%");
        }
    }
}

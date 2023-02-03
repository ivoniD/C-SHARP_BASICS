using System;

namespace _07._Trekking_Mania_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());

                if (peopleInGroup <= 5) //Мусала
                {
                    musala += peopleInGroup;
                }
                else if (peopleInGroup <= 12) // Монблан
                {
                    monblan += peopleInGroup;
                }
                else if (peopleInGroup <= 25) // Килиманджаро
                {
                    kilimandjaro += peopleInGroup;
                }
                else if (peopleInGroup <= 40) // К2
                {
                    k2 += peopleInGroup;
                }
                else if (peopleInGroup >= 41) // Еверест
                {
                    everest += peopleInGroup;
                }
            }
            double allPeople = musala + monblan + kilimandjaro + k2 + everest;
            musala = musala / allPeople * 100;
            monblan = monblan / allPeople * 100;
            kilimandjaro = kilimandjaro / allPeople * 100;
            k2 = k2 / allPeople * 100;
            everest = everest / allPeople * 100;

            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{kilimandjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");

        }
    }
}
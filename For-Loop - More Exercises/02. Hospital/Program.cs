using System;

namespace _02._Hospital_new_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int term = int.Parse(Console.ReadLine()); //4
            int treated = 0;
            int unTreated = 0;
            int doctor = 7;
            for (int i = 1; i <= term; i++)
            {
                int patient = int.Parse(Console.ReadLine()); // 7, 27, 9 , 1
                if ((i % 3 == 0) && unTreated > treated)
                {
                    doctor = doctor + 1;
                }
                if (patient <= doctor)
                {
                    treated = treated + patient;
                    unTreated = unTreated;
                }
                else if (patient > doctor)
                {
                    treated = treated + doctor;
                    unTreated = unTreated + (patient - doctor);
                }

                //tr23 - untr21
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {unTreated}.");
        }
    }
}

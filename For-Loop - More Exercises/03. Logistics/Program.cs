using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //броя на товарите // 4
            double minibus = 0;
            double truck = 0;
            double train = 0;

            for (int i = 1; i <= n; i++)
            {
                double cargo = double.Parse(Console.ReadLine()); // 1 / 5 / 16 / 3
                if (cargo <= 3) // 200 - minibus 
                {
                    minibus = minibus + cargo;
                }
                else if (cargo <= 11) // 175 - truck 
                {
                    truck = truck + cargo;
                }
                else if (cargo >= 12) // 120 - train 
                {
                    train = train + cargo;
                }
            }
            double allCargo = minibus + truck + train;
            double average = (minibus * 200 + truck * 175 + train * 120) / allCargo;
            Console.WriteLine($"{average:f2}");
            double minibusP = minibus / allCargo * 100;
            double truckP = truck / allCargo * 100;
            double trainP = train / allCargo * 100;
            Console.WriteLine($"{minibusP:f2}%");
            Console.WriteLine($"{truckP:f2}%");
            Console.WriteLine($"{trainP:f2}%");
        }
    }
}

using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            // "{дарената сума}" - форматирана с точност до 2 знака след десетичната запетая.
            int numJuniors = int.Parse(Console.ReadLine());
            int numSeniors = int.Parse(Console.ReadLine());
            string route = Console.ReadLine(); //"trail" / "cross-country" / "downhill" / "road"
            double juniorTicket = 0.0;
            double seniorTicket = 0.0;
            double donation = 0.0;
            double donationPrice = 0.0;


            //cross-country >=50(общо младши и старши) ->таксата  намалява с 25%.
            //Организаторите отделят 5 % процента от събраната сума за разходи

            switch (route)
            {
                case "trail":
                    juniorTicket = 5.50;
                    seniorTicket = 7;
                    break;
                case "cross-country":
                    juniorTicket = 8;
                    seniorTicket = 9.50;
                    break;
                case "downhill":
                    juniorTicket = 12.25;
                    seniorTicket = 13.75;
                    break;
                case "road":
                    juniorTicket = 20;
                    seniorTicket = 21.50;
                    break;
                default:
                    break;
            }
            if (true)
            {

            }
            donation = (numJuniors * juniorTicket) + (numSeniors * seniorTicket);
            double totalNumTickets = numJuniors + numSeniors;
            if (route == "cross-country" && totalNumTickets >= 50)
            {
                donation = donation - (donation * 0.25);
            }
            donationPrice = donation - (donation * 0.05);
            Console.WriteLine($"{donationPrice:f2}");
        }
    }
}

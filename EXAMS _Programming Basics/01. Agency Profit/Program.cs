using System;

namespace exam___01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	"The profit of your agency from {име на авиокомпанията} tickets is {печалба за агенцията} lv."
            //детският билет е със 70% по-евтин от adultTicketPrice
            string nameAviocomp = Console.ReadLine(); //1.Име на авиокомпанията -текст
            int adultTickets = int.Parse(Console.ReadLine()); //2.Брой билети за   възрастни 
            int childrenTickets = int.Parse(Console.ReadLine()); //3.Брой детски билети 
            double adultTicketPrice = double.Parse(Console.ReadLine()); //4.Нетна цена на билет за възрастен
            double serviceTax = double.Parse(Console.ReadLine()); //5.Цената на такса обслужване

            double childrenTicketsPrice = adultTicketPrice - (adultTicketPrice * 0.7);

            //Крайната печалба на Агенцията е 20% от общата цена на всички билети
            double priceAllTickets = ((adultTicketPrice + serviceTax) * adultTickets) + ((childrenTicketsPrice + serviceTax) * childrenTickets);
            //Console.WriteLine(priceAllTickets);
            double profit = priceAllTickets * 0.2;
            Console.WriteLine($"The profit of your agency from {nameAviocomp} tickets is {profit:f2} lv.");

        }
    }
}

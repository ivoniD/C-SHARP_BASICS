using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int str = int.Parse(Console.ReadLine());
            int strPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());


            int AllHours = str / strPerHour;
            int HoursPerDay = AllHours / days;

            Console.WriteLine(HoursPerDay);
        }
    }
}
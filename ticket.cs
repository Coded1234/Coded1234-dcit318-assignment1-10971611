using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

            Console.WriteLine("Ticket Price: GHC" + ticketPrice);
        }
    }
}
using System;

class TicketAge
{
    static void Main()
    {
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        int priceOfTheTicket;

        if (age <= 12 || age >= 65)
        {
            priceOfTheTicket = 7;
        }
        else
        {
           priceOfTheTicket = 10;
        }

        Console.WriteLine("Ticket Price: GHC " + priceOfTheTicket);
    }
}

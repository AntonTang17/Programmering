using System;

namespace TicketMachineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try buy ticket for 1 hour 30 minutes");
            Console.WriteLine("Current date and time: " + DateTime.Now);
            ParkingMachine machine = new ParkingMachine(20);
            machine.InsertMoney(30);
            string ticketText = machine.BuyTicket();
            Console.WriteLine("Printing ticket: ");
            Console.WriteLine();
            Console.WriteLine(ticketText);
            
        }
    }
}

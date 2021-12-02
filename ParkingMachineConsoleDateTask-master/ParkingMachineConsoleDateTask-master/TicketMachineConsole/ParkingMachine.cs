using System;
using System.Collections.Generic;
using System.Text;

namespace TicketMachineConsole
{
    /// <summary>
    /// An object of the class ParkingMachine represents a parking machine.
    /// 
    /// Insert money first. 
    /// 
    /// Then buy a ticket or select cancel to refund.
    /// </summary>
    public class ParkingMachine
    {
        // There is two places to save money.
        // Total in the machine, from all finnished purchases.
        private int total;

        // Total for the current customer.
        private int currentTotal;

        // Cost to park.
        private int costPerHour;

        public ParkingMachine(int costPerHour)
        {
            total = 0;
            currentTotal = 0;
            this.costPerHour = costPerHour;
        }

        public int CurrentTotal
        {
            get
            {
                return currentTotal;
            }
        }
        public int Total
        {
            get
            {
                return total;
            }
        }

        public int CostPerHour 
        { 
            get
            {
                return costPerHour;
            }
        }

        public void InsertMoney(int ct)
        {
            if (ct >= 0)
            {
                currentTotal = currentTotal + ct;
            }

        }

        public int Cancel()
        {
            int tillbaka = currentTotal;
            currentTotal = 0;
            return tillbaka;
        }

        public string BuyTicket()
        {
            TimeSpan spantime = GetParkingTimeSpan();
            string ticketext = TimeToTicketText(spantime.Days, spantime.Hours, spantime.Minutes);
            total = total + currentTotal;
            currentTotal = 0;
            return ticketext;

        }

        private string TimeToTicketText(int days, int hours, int minutes)
        {
            return "Parking ticket valid for:" + Environment.NewLine +
                days + " days" + Environment.NewLine +
                hours + " hours" + Environment.NewLine +
                minutes + " minutes" + Environment.NewLine + Environment.NewLine +
                "Valid to: " + GetValidTo();
        }

       

       
    }

}


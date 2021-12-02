using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
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
            this.costPerHour = costPerHour;
            total = 0;
            currentTotal = 0;
            
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

        public void InsertMoney(int ct)
        {
            if(ct>=0)
            {
                currentTotal = currentTotal+ct;
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
            int antalDagar;
            antalDagar = currentTotal / (costPerHour * 24);
            int rest;
            rest = currentTotal % (costPerHour * 24);
            int antalTimmar;
            antalTimmar = rest / costPerHour;
            int rest2;
            rest2 = rest % costPerHour;
            int antalMinuter = rest2 * 60 / costPerHour;
            total = total + currentTotal;
            currentTotal = 0;
            return TimeToTicketText(days: antalDagar, hours: antalTimmar, minutes: antalMinuter);
        }

        private string TimeToTicketText(int days, int hours, int minutes)
        {
            return "Parking ticket valid for:" + Environment.NewLine +
                days + " days" + Environment.NewLine +
                hours + " hours" + Environment.NewLine +
                minutes + " minutes";
        }
    }
}

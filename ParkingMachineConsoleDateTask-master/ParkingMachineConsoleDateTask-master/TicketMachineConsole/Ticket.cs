using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsoleV2
{
    class Ticket
    {
        private DateTime purchaseTime;
        private readonly int costPerHour;
        private readonly int price;

        public Ticket(int price, int costPerHour)
        {
            
        }
        public int CostPerHour
        {
            get
            {
                return costPerHour;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
        }

        public TimeSpan GetParkingTimeSpan()
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



            TimeSpan timeSpan = new TimeSpan(days: antalDagar, hours: antalTimmar, minutes: antalMinuter, seconds: 0);
            return timeSpan;

        }

        public DateTime GetValidTo()
        {
            DateTime date = DateTime.Now;
            date = date.Add(GetParkingTimeSpan());
            return date;
        }

        public string ToString()
        {

        }
    }

}

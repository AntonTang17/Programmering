using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ParkingMachineConsole;

namespace UnitTestParkingMachine
{
    /// <summary>
    /// Test for the TicketMachine class.
    /// </summary>
    [TestClass]
    public class ParkingMachineTest
    {
        [TestMethod]
        public void ValidInsertMoney()
        {
            // Arrange
            ParkingMachine machine = new ParkingMachine(40);

            // Act
            machine.InsertMoney(60);
            machine.InsertMoney(120);
            

            // Assert
            Assert.AreEqual(180, machine.CurrentTotal);
        }
        [TestMethod]
        public void InvalidInsertMoney()
        {
            // Arrange
            ParkingMachine machine = new ParkingMachine(10);

            // Act
            machine.InsertMoney(-15);

            // Assert
            Assert.AreEqual(0, machine.CurrentTotal);
        }
        [TestMethod]
        public void Cancel()
        {
            // Arrange
            ParkingMachine machine = new ParkingMachine(30);

            // Act
            machine.InsertMoney(150);
            int refund = machine.Cancel();

            // Assert
            Assert.AreEqual(0, machine.CurrentTotal);
            Assert.AreEqual(150, refund);

        }
        [TestMethod]
        public void BuyTicket30Min_CurrentTotal_Zeroed()
        {
            // Arrange
            ParkingMachine machine = new ParkingMachine(50);

            // Act
            machine.InsertMoney(25);
            machine.BuyTicket();

            // Assert
            Assert.AreEqual(0, machine.CurrentTotal);
        }
        [TestMethod]
        public void BuyTicketTwice_Total_Summed()
        {
            // Arrange
            ParkingMachine machine = new ParkingMachine(30);

            // Act
            machine.InsertMoney(15);
            machine.BuyTicket();
            machine.InsertMoney(60);
            machine.BuyTicket();

            // Assert
            Assert.AreEqual(75, machine.Total);
        }
        [TestMethod]
        public void BuyTicket30Min_TicketText()
        {
            // Arrange
            ParkingMachine machine = new ParkingMachine(40);

            // Act
            machine.InsertMoney(20);
            string ticketText = machine.BuyTicket();

            // Assert
            Assert.AreEqual(TimeToTicketText(days: 0, hours: 0, minutes: 30), ticketText);
        }
        [TestMethod]
        public void BuyTicket3Hour_TicketText()
        {
            // Arrange
            ParkingMachine machine = new ParkingMachine(35);

            // Act
            machine.InsertMoney(105);
            string ticketText = machine.BuyTicket();

            // Assert
            Assert.AreEqual(TimeToTicketText(days: 0, hours: 3, minutes: 0), ticketText);
        }
        [TestMethod]
        public void BuyTicket4Day_TicketText()
        {
            // Arrange
            ParkingMachine machine = new ParkingMachine(25);

            // Act
            machine.InsertMoney(25 * 24 * 4);
            string ticketText = machine.BuyTicket();

            // Assert
            Assert.AreEqual(TimeToTicketText(days: 4, hours: 0, minutes: 0), ticketText);
        }
        [TestMethod]
        public void BuyTicket2Day3Hour15Min_TicketText()
        {
            // Arrange
            ParkingMachine machine = new ParkingMachine(40);
            int money = 2 * 24 * 40 + 3 * 40 + 10;

            // Act
            machine.InsertMoney(money);
            string ticketText = machine.BuyTicket();

            // Assert
            Assert.AreEqual(TimeToTicketText(days: 2, hours: 3, minutes: 15), ticketText);
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

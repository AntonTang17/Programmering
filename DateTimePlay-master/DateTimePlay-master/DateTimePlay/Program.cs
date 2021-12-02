using System;

namespace DateTimePlay
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = DateTime.Now;
            Console.WriteLine("Current date and time : " + date.ToString());
            Console.WriteLine();

            TimeSpan timeSpan = new TimeSpan(days: 7, hours: 1, minutes: 0, seconds: 0);
            Console.WriteLine("Add this time span (Days.Hours.Minutes.Seconds): " + timeSpan.ToString());
            Console.WriteLine();

            date = date.Add(timeSpan);
            Console.WriteLine("New date: " + date.ToString());
            Console.WriteLine();

        }
    }
}

using System;

namespace DateTimeMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2022, 1, 17);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

            var tommorrow = now.AddDays(1);  //tomorrow time
            var yesterday = now.AddDays(-1); //yesterday time

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("F"));  //used for different time and date format

        }
    }
}

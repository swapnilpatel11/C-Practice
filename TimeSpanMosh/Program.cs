using System;

namespace TimeSpanMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timeSpan = new TimeSpan(2, 1, 1);
            
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);

            //Add & Subtract
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: "+ timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            //toString()
            Console.WriteLine("ToStinrg :" + timeSpan.ToString());

            //parse
            Console.WriteLine("Parse method: "+ TimeSpan.Parse("01:02:13"));

        }
    }
}

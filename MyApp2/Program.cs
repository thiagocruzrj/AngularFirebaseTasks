using System;
using System.Globalization;

namespace MyApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now;

            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddMonths(2));
            Console.WriteLine(data.AddYears(1));

            var br = new CultureInfo("pt-BR");
            var pt = new CultureInfo("pt-PT");
            var eu = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");

            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", eu));
            Console.WriteLine(DateTime.Now.ToString("D", de));

            var utcDate = DateTime.UtcNow;
            Console.WriteLine(utcDate);

            Console.WriteLine(utcDate.ToLocalTime());
            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            var hourAustralia = TimeZoneInfo.ConvertTimeToUtc(utcDate, timezoneAustralia);
            Console.WriteLine(hourAustralia);
            Console.WriteLine(timezoneAustralia);
        }
    }
}
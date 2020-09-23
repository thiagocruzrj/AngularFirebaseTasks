using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            decimal value = 10.25M;
            Console.WriteLine(value.ToString(CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(value.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(value.ToString("C ",CultureInfo.CreateSpecificCulture("en-UK")));

            decimal newValue = 1033.6534M;
            Console.WriteLine(Math.Round(newValue));
            Console.WriteLine(Math.Ceiling(newValue));
            Console.WriteLine(Math.Floor(newValue));
        }
    }
}
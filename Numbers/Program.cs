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
        }
    }
}
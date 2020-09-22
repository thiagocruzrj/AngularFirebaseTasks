using System;

namespace MyApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now;

            var formatY = string.Format("{0:yyyy/MM/dd hh:mm:ss}", data);
            Console.WriteLine(formatY);
        }
    }
}
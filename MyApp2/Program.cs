using System;

namespace MyApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now;

            var format = string.Format("{0}", data);
            Console.WriteLine(format);
        }
    }
}
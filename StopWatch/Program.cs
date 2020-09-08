using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Choise between:");
            Console.WriteLine("s = Seconds, like 10s");
            Console.WriteLine("m = Minutes, like 10m");
            Console.WriteLine("0 = exit");
            Console.WriteLine("How long do you want to count ?");

            string data = Console.ReadLine().ToLower();
            Console.WriteLine(data);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.Write("Stopwatch finished");
            Thread.Sleep(2000);
        }
    }
}
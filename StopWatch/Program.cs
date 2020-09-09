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
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multMinute = 1;

            if (time == 'm')
                multMinute = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multMinute);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go !");
            Thread.Sleep(500);

            Start(time);
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
            Menu();
        }
    }
}
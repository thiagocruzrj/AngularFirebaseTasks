using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
    }
}
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Console.WriteLine(arr[i]);
                }
            }
            catch
            {
                System.Console.WriteLine("Something wrong");
            }
        }
    }
}
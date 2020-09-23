using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var newArray = new int[5];

            var newArray2 = new int[5]{1,2,3,4,5};
            newArray[0] = 10;

            Console.WriteLine(newArray[0]);
            Console.WriteLine(newArray2[3]);
        }
    }
}

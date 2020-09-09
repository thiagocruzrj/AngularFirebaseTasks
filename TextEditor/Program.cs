using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What do you need ? ");
            Console.WriteLine("1 - Open File ");
            Console.WriteLine("2 - Create a new file ");
            Console.WriteLine("0 - Exit ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {

            }
        }

        static void Open()
        {

        }

        static void Edit()
        {

        }
    }
}

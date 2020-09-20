using System;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
        }

        public static void DrawScreen()
        {
            DrawingHeaderFooter();

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
            DrawingHeaderFooter();
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Html Editor");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Select a option below");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - New File");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Open File");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Exit");
            Console.SetCursorPosition(3,10);
            Console.Write("Option: ");
        }

        private static void DrawingHeaderFooter()
        {
            Console.Write("+");
            for(int i = 0; i <= 30; i++)
                Console.Write("-");
            
            Console.Write("+");
            Console.Write("\n");
        }
    }
}
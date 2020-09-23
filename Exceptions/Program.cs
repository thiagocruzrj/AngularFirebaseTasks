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
            //     for (int i = 0; i < 10; i++)
            //     {
            //         System.Console.WriteLine(arr[i]);
            //     }
                Save("");
            }

            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Not found the index on list");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Fail to save the text");
            }
            catch(MyException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.WhenHappened);
                Console.WriteLine("Custom Exception");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something wrong");
            }
        }

        static void Save(string text)
        {
            if(string.IsNullOrEmpty(text))
                throw new MyException(DateTime.Now);
        }

        public class MyException : Exception
        {
            public DateTime WhenHappened { get; set; }

            public MyException(DateTime whenHappened)
            {
                WhenHappened = whenHappened;
            }
        }
    }
}
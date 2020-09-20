using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();
            id = new Guid("163fde36-c352-418f-85de-4c48663ad786");
            Console.WriteLine(id);

            var price = 10.2;
            var text = "Product price is " + price;
            var secText = string.Format("Product price is {0} only in promotion", price);
            var thirdText = $"Product price is {price} only in promotion";

            Console.WriteLine(text);
            Console.WriteLine(secText);
            Console.WriteLine(thirdText);

            var compareText = "Testing";
            Console.WriteLine(compareText.CompareTo("Testing"));
            Console.WriteLine(compareText.CompareTo("testing"));

            var testText = "This text is a test";
            Console.WriteLine(testText.Contains("test"));
            Console.WriteLine(testText.Contains("Test"));
            Console.WriteLine(testText.Contains("Test", StringComparison.OrdinalIgnoreCase));

            var textWith = "This text is a test";
            Console.WriteLine(textWith.StartsWith("This"));
            Console.WriteLine(textWith.StartsWith("this"));
            Console.WriteLine(textWith.EndsWith("this"));
            Console.WriteLine(textWith.EndsWith("this"));
            
            var textEquals = "This text is a test";
            Console.WriteLine(textEquals.Equals("This text is a test"));
            Console.WriteLine(textEquals.Equals("his text is a test"));

            var textIndex = "This text is a test";
            Console.WriteLine(textIndex.IndexOf("test"));
            Console.WriteLine(textIndex.LastIndexOf("t"));
            Console.WriteLine(textIndex.ToLower());
            Console.WriteLine(textIndex.ToUpper());
        }
    }
}
using System;
using System.Text;

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

            Console.WriteLine(textIndex.Insert(5, "good "));

            Console.WriteLine(textIndex.Remove(5));
            Console.WriteLine(textIndex.Replace("This", "Amazing"));
            Console.WriteLine(textIndex.Replace("t", "x"));

            var division = textIndex.Split(" ");
            Console.WriteLine(division[0]);
            Console.WriteLine(division[1]);
            Console.WriteLine(division[2]);
            Console.WriteLine(division[3]);
            Console.WriteLine(division[4]);

            var result = textIndex.Substring(5, 4);
            var result2 = textIndex.Substring(5, textIndex.LastIndexOf("a"));
            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.WriteLine(textIndex.Trim());

            var newText = new StringBuilder();
            newText.Append("This is a new text");
            newText.Append("This is a ");
            newText.Append("This is a text ");
            newText.Append("new text");
            newText.Append("This text");
            
            Console.WriteLine(newText);
        }
    }
}
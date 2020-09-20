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

            Console.WriteLine(text);
            Console.WriteLine(secText);
        }
    }
}
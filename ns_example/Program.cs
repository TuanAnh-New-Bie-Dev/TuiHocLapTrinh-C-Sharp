using System;
using Sanpham;
namespace ns_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine(p.GetInfo());

            p.Name = "Apple";
            p.Price = 123;
            p.Description = "Day la good Apple";

            Console.WriteLine(p.GetInfo());
        }
    }
}

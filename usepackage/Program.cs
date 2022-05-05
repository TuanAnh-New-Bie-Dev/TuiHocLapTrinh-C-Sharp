using System;
using Newtonsoft.Json;
using THLT.Utils;
using System.Text;

namespace usepackage
{
    class Program
    {
        // dotnet add package packagename --version xxx
        // dotnet remove package packagename

        // dotnet restore

        // dotnet add tenduan.csproj reference thuvien.csproj
        //  D:\Project C# .NET\C#\usepackage\usepackage.csproj reference D:\Project C# .NET\C#\usepackage\Utils\Utils.csproj

        class Product
        {
            public string Name { get; set; }
            public DateTime Expiry { get; set; }
            public string[] Sizes { get; set; }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a = 3453453453;
            var kq = ConvertMoneyToText.NumberToText(a);
            Console.WriteLine(kq);
            ConvertMoneyToText.Hello();

            // string json = @"
            // {
            //     ""Name"":""Dien thoai Iphone"",
            //     ""Expiry"":""2022-1-30T00:00:00"",
            //     ""Size"":[""Large"", ""Small""]
            // }
            // ";

            // var product = JsonConvert.DeserializeObject<Product>(json);

            // Console.WriteLine(product.Name);
            // Console.WriteLine(product.Expiry.ToLongDateString());


            // Bad Boys
            // Product product = new Product();
            // product.Name = "Apple";
            // product.Expiry = new DateTime(2008, 12, 28);
            // product.Sizes = new string[] { "Small" };

            // string json = JsonConvert.SerializeObject(product);
            // Console.WriteLine(json);
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }
        }
    }
}

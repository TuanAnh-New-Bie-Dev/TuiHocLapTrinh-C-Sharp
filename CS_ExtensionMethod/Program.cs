using System;

namespace CS_ExtensionMethod
{

    static class Morong
    {
        // public static void Print(this string s, ConsoleColor color) {
        //     Console.ForegroundColor = color;
        //     Console.WriteLine(s);
        // }

        public static double Binhphuong(this double x) => x * x;
        public static double CanBacHai(this double x) => Math.Sqrt(x);
        public static double Cos(this double x) => Math.Cos(x);
        public static double Sin(this double x) => Math.Sin(x);

    }
    class Program
    {
        static void Main(string[] args)
        {
            // String s = "tuan anh dep trai";
            // s.Print(ConsoleColor.Green);

            double x = 12.12;

            Console.WriteLine(x.Binhphuong() + " | " +
            x.CanBacHai() + " | " +
            x.Cos() + " | " +
            x.Sin());
        }
    }
}

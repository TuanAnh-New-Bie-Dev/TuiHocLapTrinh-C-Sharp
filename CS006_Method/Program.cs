using System;
using System.Text;
using CS006_Method;

namespace CS006_Method
{
    class Program
    {

        public static int tich(int a, int b)
        {
            int rs;
            rs = a * b;
            return rs;
        }

        public static double tich(double a, double b)
        {
            double rs;
            rs = a * b;
            return rs;
        }

        class Count
        {
            public int c = 1;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            // Console.WriteLine(tich(4, 5));
            // Console.WriteLine(tich(4.1, 5));

            // Console.WriteLine(TinhToan.tong(123, 456));

            // Console.WriteLine(TinhToan.tong(123.23123f, 456.123123f));

            // xinchao("Tuấn Anh", "Hoàng");

            // xinchao(ho: "Hoàng", ten: "Tuấn Anh");

            // xinchao("Tuấn Anh");
            // int a;
            // binhphuong(5, out a);
            // Console.WriteLine(a);

            Count c = new Count();

            Console.WriteLine(c.c);

            dem(c);
            dem(c);
            dem(c);
            dem(c);

            Console.WriteLine(c.c);

        }
        static void dem(Count count)
        {
            count.c++;
        }
        static void binhphuong(int x, out int kq)
        {

            kq = x * x;
            Console.WriteLine(kq);
        }

        static void xinchao(string ten, string ho = "Hoàng")
        {
            String fullname = ho + " " + ten;
            Console.WriteLine(fullname);
        }
    }
}

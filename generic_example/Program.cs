using System;

namespace generic_example
{
    class Program
    {
        // static void Swap(ref int a, ref int b)
        // {

        //     int t = a;
        //     a = b;
        //     b = t;

        // }
        // static void Swap(ref float a, ref float b)
        // {

        //     float t = a;
        //     a = b;
        //     b = t;

        // }

        // static void Swap<T>(ref T x, ref T y)
        // {
        //     T t = x;
        //     x = y;
        //     y = t;
        // }

        class Product<T>
        {
            T ID;

            public void SetID(T _id)
            {
                this.ID = _id;
            }

            public void PrintInf()
            {
                Console.WriteLine($"ID = {this.ID}");
            }
        }
        static void Main(string[] args)
        {
            // int a = 3;
            // int b = 45;
            // float c = 3.5f;
            // float d = 123.5f;

            // Console.WriteLine($"so a la {a}, so b la {b}");

            // Swap(ref a, ref b);

            // Console.WriteLine($"so c la {c}, so d la {d}");

            Product<string> p = new Product<string>();
            p.SetID("asdasd");
            p.PrintInf();
        }
    }
}

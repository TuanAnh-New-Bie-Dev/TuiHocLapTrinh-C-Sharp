using System;

namespace CS10
{
    class Program
    {
        class ABC {
            public void Xinchao() => Console.WriteLine("Xin chao Tuihoclaptrinh code c# day!");
        }
        static void Main(string[] args)
        {
            ABC a = new ABC();

            a?.Xinchao();
        }
    }
}

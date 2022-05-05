using System;
using System.Text;

namespace CS005_for_while
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} nhỏ hơn hoặc bằng 10");
            }
        }
    }
}

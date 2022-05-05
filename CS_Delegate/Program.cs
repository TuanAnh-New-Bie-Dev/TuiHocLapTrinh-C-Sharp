using System;

namespace CS_Delegate
{
    public delegate void ShowLog(string message);
    class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        // static int Tong(int a, int b) => a + b;
        // static int Hieu(int a, int b) => a - b;

        static void Tong(int a, int b, ShowLog log)
        {
            int kq = a + b;
            log?.Invoke($"Tong la {kq}");
        }
        static void Main(string[] args)
        {
            // ShowLog log = null;
            // log?.Invoke("Chao Tuihoclaptrinh lan 2");
            // log = Info;

            // log("Xin Chao Tuihoclaptrinh day!");
            // log = Warning;

            // log += Info;
            // log += Info;
            // log += Info;

            // log += Warning;
            // log += Warning;

            // log?.Invoke("Chao Tuihoclaptrinh dang code delegate");

            // Action action; //delegate void kieu();

            // Action<string, int> action1;// delegate void Kieu(string s, int o);

            // Action<string> action2; // delegate void kieu(string a);

            // action2 = Warning;
            // action2 += Info;

            // action2?.Invoke("Tuhoclaptrinh dung action ");

            // Func<int> f1; // delegate int Kieu();

            // Func<string, double, string> f2; //delegate string KIEU(string,double);

            // Func<int, int, int> tinhtoan; //  delegate int Kieu(int a, int b);

            // int a = 5;
            // int b = 10;

            // tinhtoan = Tong;


            // Console.WriteLine($"Tong la {tinhtoan(a, b)}"); 
            // tinhtoan = Hieu;
            // Console.WriteLine($"Hieu la {tinhtoan(a, b)}"); 

            Tong(4, 5, Warning);

        }
    }
}

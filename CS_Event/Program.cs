using System;

namespace CS_Event
{
    public delegate void EventInputNumber(int x);
    /*
        publisher -> class - phat su kien
        subsriber -> class - nhan su kien
    */

    //publisher
    class UserInput
    {
        public event EventInputNumber sukiennhapso;
        public void Input()
        {
            do
            {
                Console.Write("nhap vao so nguyen : ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                // phat di su kien
                sukiennhapso?.Invoke(i);
            } while (true);
        }
    }

    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso += Can;
        }
        public void Can(int a)
        {
            Console.WriteLine($"Can bac hai cua {a} la : {Math.Sqrt(a)}");
        }
    }
    class BinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso += TinhBinhPhuong;
        }
        public void TinhBinhPhuong(int a)
        {
            Console.WriteLine($"Binh phuong cua {a} la : {a * a}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // publisher
            UserInput u = new UserInput();
            // subcriber
            TinhCan tinhCan = new TinhCan();

            BinhPhuong binhPhuong = new BinhPhuong();


            tinhCan.Sub(u);
            binhPhuong.Sub(u);

            u.Input();
        }
    }
}

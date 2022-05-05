using System;
using System.Linq;

namespace CS_Lamda
{
    /*
    
    Lamda = Anonymous function

    1)
    (tham_so) => bieu_thuc;

    2)
    (tham_so) => {
        cac_bieu_thuc;
        return bieu_thuc_tra_ve;
    }

    */
    class Program
    {
        static void Main(string[] args)
        {
            // Action<string> thongbao;
            // thongbao = (string s) => Console.WriteLine(s); //delegate void kieu(string s) = Acount<string>

            // thongbao?.Invoke("Xin chao");

            // Action thongbao;

            // thongbao = () => Console.WriteLine("Tuihoclaptrinh dung lamda");

            // thongbao?.Invoke();

            // Action<string> welcome;

            // welcome = (string s) => Console.WriteLine(s);
            // //welcome = ( s) => Console.WriteLine(s);
            // //welcome =  s => Console.WriteLine(s);

            // welcome?.Invoke("xin chao");

            // Action<string,string> welcome;

            // welcome = (string msg, string name) => Console.WriteLine(msg + " | " + name);
            // //welcome = ( msg,  name) => Console.WriteLine(msg + " | " + name);


            // welcome?.Invoke("xinchao", "tuihoclaptrinh");
            // welcome?.Invoke("chao", "Hoang Tuan Anh");

            // (int a, int b) =>
            // {
            //     int kq = a + b;
            //     return kq;
            // }

            int[] mang = { 2, 4, 64, 5, 7, 8, 9, 33, 55 };

            // var kq = mang.Select(
            //     (int x) =>
            // {
            //     return Math.Sqrt(x);
            // });

            // foreach (var rs in kq)
            // {
            //     Console.WriteLine(rs);
            // }

            // mang.ToList().ForEach(
            //     (int x) =>
            //     {
            //         if (x % 2 != 0)
            //             Console.WriteLine(x);
            //     }
            // );

            var kq = mang.Where(
                 x => x >= 2 && x <= 10
            );

            foreach (var rs in kq)
            {
                Console.WriteLine(rs);
            }
        }
    }
}

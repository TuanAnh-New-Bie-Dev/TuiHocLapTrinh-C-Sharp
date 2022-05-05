using System;
using System.Text;

namespace CS012_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // string thongbao = "......Thong bao nay dung trim !....";

            // thongbao = thongbao.Trim('.') + "abc";

            // Console.WriteLine(thongbao);

            // thongbao = thongbao.Replace("dung trim", "cung la dung trim nhung ma dc replace");
            // Console.WriteLine(thongbao);

            // string[] subthongbao = thongbao.Split(" ");

            // foreach (var item in subthongbao)
            // {
            //     Console.WriteLine(item);
            // }

            // String[] submsg = {"xin", "chao", "cac", "ban", "TuiHocLapTrinh", "day!"};

            // string msg = string.Join(" ", submsg);

            // Console.WriteLine(msg);

            StringBuilder thongbao = new StringBuilder();
            thongbao.Append("Xin");
            thongbao.Append(" Chao cac ban TuiHocLapTrinh day");
            thongbao.Replace("cac ban", "moi nguoi");

            String kq = thongbao.ToString();

            Console.WriteLine(kq);

        }
    }
}

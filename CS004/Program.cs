using System.Text;
using System;

namespace CS004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // int a;
            // Console.Write("Nhập số nguyên a: ");
            // a = int.Parse(Console.ReadLine());

            // if(a % 2 == 0) {
            //     Console.WriteLine($"Số {a} là số chẵn");
            // } else {
            //     Console.WriteLine($"Số {a} là số lẻ");
            // }

            // [8-10] : giỏi
            // [6.5-8] : khá
            // [5.0-6.5] : trung bình
            // [0-5.0] : yếu

            // float dtb;
            // Console.Write("Hãy nhập điểm trung bình: ");
            // dtb = float.Parse(Console.ReadLine());

            // if (0 <= dtb && dtb < 5)
            // {
            //     Console.WriteLine("Học lực yếu");
            // }
            // else if (5 <= dtb && dtb < 6.5)
            // {
            //     Console.WriteLine("Học lực trung bình");
            // }
            // else if (6.5 <= dtb && dtb < 8)
            // {
            //     Console.WriteLine("Học lực khá");
            // }
            // else if (8 <= dtb && dtb <= 10)
            // {
            //     Console.WriteLine("Học lực giỏi");
            // }

            // float a, b;

            // Console.Write("Nhập số a: ");
            // a = float.Parse(Console.ReadLine());
            // Console.Write("Nhập số b: ");
            // b = float.Parse(Console.ReadLine());

            // float max;

            // max = (a > b) ? a : b;

            // Console.WriteLine($"Số {max} là số lớn nhất");


            // float a = 4, b = 3.5f, c = 9;

            // float max = a;

            // if(b > a ) max = b;

            // if(c > max) max = c;

            // float max;

            // max = (a > b) ?
            //  (a > c) ? a : c
            //  :
            //   (b > c) ? b : c
            //   ;

            // Console.WriteLine($"Số {max} là số lớn nhất");

            // int a;
            // a = 5;

            // switch (a)
            // {
            //     case 1:
            //     case 3:
            //     case 5:
            //     case 7:
            //     case 9:
            //         Console.WriteLine($"{a} là số lẻ");
            //         break;
            //     case 2:
            //     case 4:
            //     case 6:
            //     case 8:
            //         Console.WriteLine($"{a} là số chẵn");
            //         break;

            //     default:
            //         Console.WriteLine("Hãy thử số khác");
            //         break;
            // }

            int a, b;
            Console.Write("Nhập số a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            b = int.Parse(Console.ReadLine());

        L1:
            Console.WriteLine("Hãy chọn lệnh ");
            Console.WriteLine("1. Tính tổng ");
            Console.WriteLine("2. Tính hiệu ");
            Console.WriteLine("3. Tính tích ");
            Console.WriteLine("4. Tính thương ");
            Console.Write("Nhập : ");
            int opt = int.Parse(Console.ReadLine());
            double kq;
            switch (opt)
            {
                case 1:
                    kq = a + b;
                    Console.WriteLine($"{a} + {b} = {kq}");
                    break;
                case 2:
                    kq = a - b;
                    Console.WriteLine($"{a} - {b} = {kq}");
                    break;
                case 3:
                    kq = a * b;
                    Console.WriteLine($"{a} * {b} = {kq}");
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Không thể chia khi mẫu bằng 0");
                        goto L1;
                    }
                    else
                    {
                        kq = (double)a / b;
                        Console.WriteLine($"{a} / {b} = {kq}");
                    }
                    break;

                default:
                    Console.WriteLine("Nhập lệnh trong phạm vi 1-4");
                    goto L1;

            }

        }
    }
}

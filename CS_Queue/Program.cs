using System;
using System.Collections.Generic;

namespace CS_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue<string> hoso_canxuly = new Queue<string>();

            // hoso_canxuly.Enqueue("Hồ sơ A"); // Hồ sơ xếp thứ nhất trong hàng đợi
            // hoso_canxuly.Enqueue("Hồ sơ B"); // Hồ sơ xếp thứ hai
            // hoso_canxuly.Enqueue("Hồ sơ C");


            // // Lấy hồ sơ xếp trước xử lý  trước, cho đến hết
            // while (hoso_canxuly.Count > 0)
            // {
            //     var hs = hoso_canxuly.Dequeue();
            //     Console.WriteLine($"Xử lý {hs}, còn lại {hoso_canxuly.Count}");
            // }
            // Queue<string> hoso_canxuly = new Queue<string>();

            // hoso_canxuly.Enqueue("Hồ sơ A"); // Hồ sơ xếp thứ nhất trong hàng đợi
            // hoso_canxuly.Enqueue("Hồ sơ B"); // Hồ sơ xếp thứ hai
            // hoso_canxuly.Enqueue("Hồ sơ C");


            // // Lấy hồ sơ xếp trước xử lý  trước, cho đến hết
            // while (hoso_canxuly.Count > 0)
            // {
            //     var hs = hoso_canxuly.Dequeue();
            //     Console.WriteLine($"Xử lý {hs}, còn lại {hoso_canxuly.Count}");
            // }
            LinkedList<string> cacbaihoc = new LinkedList<string>();


            cacbaihoc.AddFirst("Bài học 3");   // thêm vào đầu danh sach
            cacbaihoc.AddLast("Bài học 4");    // thêm vào cuối
            cacbaihoc.AddFirst("Bài học 2");
            cacbaihoc.AddFirst("Bài học 1");


            // Lấy phần tử đầu tiên, sau đó duyệt đến cuối
            Console.WriteLine("---------Nút từ đầu về cuối");
            LinkedListNode<string> node = cacbaihoc.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;   // node gán bằng nút sau nó
            }


            // Lấy phần tử cuối cùng, sau đó duyệt về phần tử đầu  tiên
            Console.WriteLine("--------Nút từ cuối đến đầu");
            node = cacbaihoc.Last;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Previous;   // node gán bằng nút phía trước nó
            }

        }
    }

}

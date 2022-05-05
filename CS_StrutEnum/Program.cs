using System;

namespace CS_StrutEnum
{
    class Program
    {
        // public struct Product {
        //     public string name;
        //     public double price;
        //     public Product(string _name, double _price) {
        //         this.name = _name;
        //         this.price = _price;
        //     }
        //     public string GetInfo() {
        //         return $"Ten san pham {name}, Gia san pham {price}";
        //     }
        // }

        enum HOCLUC { Kem = 111, TrungBinh = 222, Kha = 333, Gioi = 444 };
        static void Main(string[] args)
        {
            // Product cam;
            // Product xoai = new Product("Xoai", 3.5f);

            // cam.name = "cam";
            // cam.price = 3.4;

            // Console.WriteLine(cam.GetInfo());
            // Console.WriteLine(xoai.GetInfo());
            HOCLUC hocluc = HOCLUC.Gioi;

            hocluc = (HOCLUC) (111);

            switch (hocluc)
            {
                case HOCLUC.Kem:
                    Console.WriteLine("hoc luc kem");
                    break;
                case HOCLUC.TrungBinh:
                    Console.WriteLine("hoc luc trung binh");
                    break;
                case HOCLUC.Kha:
                    Console.WriteLine("hoc luc kha");
                    break;
                case HOCLUC.Gioi:
                    Console.WriteLine("hoc luc gioi");
                    break;
                default:
                    Console.WriteLine("hoc luc gi cung k biet =))");
                    break;
            }


        }
    }
}

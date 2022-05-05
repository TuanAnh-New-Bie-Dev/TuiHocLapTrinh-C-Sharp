using System;
using System.Text;

namespace CS007_Class
{

    class Vukhi
    {

        public string Name { get; set; }
        public int Satthuong { get; set; }
        public Vukhi()
        {
            Console.WriteLine("Khởi tạo vũ khí");
            this.Name = "Vu khi";
            this.Satthuong = 1;
        }

        public Vukhi(string _name, int _satthuong)
        {
            this.Name = _name;
            this.Satthuong = _satthuong;
        }

        public void Tancong()
        {
            Console.Write(Name + ": ");
            for (int i = 0; i < Satthuong; i++)
            {
                Console.Write(" * ");
            }
        }
    }

}
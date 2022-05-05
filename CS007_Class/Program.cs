using System;
using System.Text;
namespace CS007_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Vukhi sung = new Vukhi();

            Vukhi vukhi = new Vukhi();

            Vukhi dao = new Vukhi("Dao Phây", 3);

            sung.Satthuong = 12;
            vukhi.Tancong();
            sung.Tancong();

            dao.Tancong();
        }
    }
}

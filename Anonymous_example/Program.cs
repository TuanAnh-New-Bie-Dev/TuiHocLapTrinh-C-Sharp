using System;
using System.Collections.Generic;
using System.Linq;
namespace Anonymous_example
{
    // class Sinhvien
    // {
    //     public string Hoten { get; set; }
    //     public int Namsinh { get; set; }
    //     public string Noisinh { get; set; }
    // }
    class Program
    {
        class Student
        {
            public string Name { get; set; }
        }
        static void PrintInfo(dynamic obj)
        {
            obj.Name = "Tuan Anh";
        }
        static void Main(string[] args)
        {
            // var sanpham = new { Ten = "Ip 11", Price = 12.2, NamSx = 2022 };

            // Console.WriteLine(sanpham.Ten);
            // Console.WriteLine(sanpham.Price);
            // Console.WriteLine(sanpham.NamSx);

            // List<Sinhvien> cacsv = new List<Sinhvien>() {
            //     new Sinhvien() {Hoten = "Hoang Tuan Anh", Namsinh = 2000, Noisinh = "Quang Nam"},
            //     new Sinhvien() {Hoten = "Nguyen Hoang Tuan Khoa", Namsinh = 2012, Noisinh = "Quang Nam"},
            //     new Sinhvien() {Hoten = "Hoang Tuan Em", Namsinh = 1999, Noisinh = "Da Nang"},
            //     new Sinhvien() {Hoten = "Hoang Tuan Chi", Namsinh = 2002, Noisinh = "Ha Noi"}
            // };
            // //where sv.Namsinh <= 2000
            // var ketqua = from sv in cacsv where sv.Hoten.Contains("a") select new { Ten = sv.Hoten, NS = sv.Noisinh, SN = sv.Namsinh };

            // foreach (var sv in ketqua)
            // {
            //     Console.WriteLine($"Ten : {sv.Ten} | Nam sinh : {sv.SN} | Noi sinh : {sv.NS}");
            // }

            Student s = new Student();
            PrintInfo(s);
            Console.WriteLine(s.Name);

        }
    }
}

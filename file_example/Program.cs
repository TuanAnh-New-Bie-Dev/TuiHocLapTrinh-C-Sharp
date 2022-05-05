using System;
using System.IO;
using System.Text;

namespace file_example
{
    class Program
    {
        // static void ListFileDirectory(string path)
        // {
        //     String[] directories = System.IO.Directory.GetDirectories(path);
        //     String[] files = System.IO.Directory.GetFiles(path);
        //     foreach (var file in files)
        //     {
        //         Console.WriteLine(file);
        //     }
        //     foreach (var directory in directories)
        //     {
        //         Console.WriteLine(directory);
        //         ListFileDirectory(directory); // Đệ quy
        //     }
        // }

        class Product
        {
            public int ID { get; set; }
            public double Price { get; set; }
            public string Name { get; set; }
            public void Save(Stream stream)
            {
                //int -> 4 bytes
                var byte_id = BitConverter.GetBytes(ID);
                stream.Write(byte_id, 0, 4);
                //double -> 8 bytes
                var byte_price = BitConverter.GetBytes(Price);
                stream.Write(byte_price, 0, 8);
                //chuoi name
                var byte_name = Encoding.UTF8.GetBytes(Name);
                var byte_len = BitConverter.GetBytes(byte_name.Length);
                stream.Write(byte_len, 0, 4);
                stream.Write(byte_name, 0, byte_name.Length);
            }

            public void Restore(Stream stream)
            {
                //int -> 4 bytes
                var byte_id = new byte[4];
                stream.Read(byte_id, 0, 4);
                ID = BitConverter.ToInt32(byte_id, 0);
                //double -> 8 bytes
                var byte_price = new byte[8];
                stream.Read(byte_price, 0, 8);
                Price = BitConverter.ToDouble(byte_price, 0);
                //chuoi name
                var byte_len = new byte[4];
                stream.Read(byte_len, 0, 4);
                int len = BitConverter.ToInt32(byte_len, 0);

                var byte_name = new byte[4];
                stream.Read(byte_name, 0, len);
                Name = Encoding.UTF8.GetString(byte_name, 0, len);
            }
        }
        static void Main(string[] args)
        {
            // DriveInfo drive = new DriveInfo("D:/");

            // Console.WriteLine($"Drive: {drive.Name}");
            // Console.WriteLine($"Drive Type: {drive.DriveType}");
            // Console.WriteLine($"Label: {drive.VolumeLabel}");
            // Console.WriteLine($"Format: {drive.DriveFormat}");
            // Console.WriteLine($"Size: {drive.TotalSize}");
            // Console.WriteLine($"Free: {drive.TotalFreeSpace}");

            // DriveInfo[] allDrives = DriveInfo.GetDrives();

            // foreach (DriveInfo d in allDrives)
            // {
            //     Console.WriteLine("Drive {0}", d.Name);
            //     Console.WriteLine("  Drive type: {0}", d.DriveType);
            //     if (d.IsReady == true)
            //     {
            //         Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
            //         Console.WriteLine("  File system: {0}", d.DriveFormat);
            //         Console.WriteLine("  Available space to current user:{0, 15} bytes", d.AvailableFreeSpace);
            //         Console.WriteLine("  Total available space:          {0, 15} bytes", d.TotalFreeSpace);
            //         Console.WriteLine("  Total size of drive:            {0, 15} bytes ", d.TotalSize);
            //         Console.WriteLine("--------------------------------------------------------------");
            //     }
            // }

            // string path = "obj";
            // Directory.CreateDirectory(path);
            // Directory.Delete(path);
            // if (Directory.Exists(path))
            // {
            //     Console.WriteLine($"{path} - ton tai");
            // }
            // else
            // {
            //     Console.WriteLine($"{path} - khong ton tai");

            // }

            // var files = Directory.GetFiles(path);

            // var directories = Directory.GetDirectories(path);

            // foreach (var directory in directories)
            // {
            //     Console.WriteLine(directory);
            // }
            // Console.WriteLine("--------------------------------------------------------------");

            // foreach (var file in files)
            // {
            //     Console.WriteLine(file);
            // }

            // ListFileDirectory(path);

            // Console.WriteLine(Path.DirectorySeparatorChar);

            // var path = Path.Combine("Dir1", "Dir2", "Tenfile.txt");

            // var path2 = Path.ChangeExtension("Dir1/Dir2/Tenfile.txt", "md");
            // var path3 = ("/Dir1/Dir2/Tenfile.txt");
            // var path4 = Path.GetRandomFileName();

            // Console.WriteLine(path);
            // Console.WriteLine(path2);
            // Console.WriteLine(Path.GetDirectoryName(path));
            // Console.WriteLine(Path.GetExtension(path));
            // Console.WriteLine(Path.GetFileName(path));
            // Console.WriteLine(Path.GetFullPath(path));
            // Console.WriteLine(Path.GetFullPath(path3));
            // Console.WriteLine(path4);
            // string filename = "abc.txt";
            // string content = "Xin chao cac ban Tuihoclaptrinh lan 2";
            // File.WriteAllText(filename, content);
            // File.AppendAllText(filename, content);
            // string content = File.ReadAllText(filename);

            // Console.WriteLine(content);

            // File.Move("abc.txt", "Tuihoclaptrinh.txt");
            // File.Copy("Tuihoclaptrinh.txt", "123.txt");
            // File.Delete("Tuihoclaptrinh.txt");
            string path = "data.dat";
            using var stream = new FileStream(path: path, FileMode.Open);

            Product p = new Product();
            // p.ID = 10;
            // p.Price = 12345;
            // p.Name = "abc";

            // p.Save(stream);

            p.Restore(stream);

            Console.WriteLine($"{p.Name} - {p.Price} - {p.ID}");
            // byte[] buffer = { 1, 2, 3, 4 };
            // int offset = 0;
            // int count = 4;

            // stream.Write(buffer, offset, count);

            // //doc du lieu
            // int sobytedocduoc = stream.Read(buffer, offset, count);

            // // int, double --> bytes
            // int abc = 1;
            // var byte_abc = BitConverter.GetBytes(abc);

            // //bytes --> int, double
            // BitConverter.ToInt32(byte_abc, 0);

            // string s = "abc";

            // var byte_s = Encoding.UTF8.GetBytes(s);

            // Encoding.UTF8.GetString(byte_s, 0, 10); 

        }
    }
}

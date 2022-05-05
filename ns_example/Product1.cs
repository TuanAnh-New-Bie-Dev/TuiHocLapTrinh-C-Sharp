namespace Sanpham
{

    public partial class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string GetInfo() {

            return $"{Name} | {Price} | {Description}";

        }
    }

}
using System;

namespace bt3_kiem_tra
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }

        public Product()
        {
            ProductId = "";
            ProductName = "";
            Category = "";
            UnitPrice = 0;
            Quantity = 0;
            ImagePath = "";
        }

        public Product(string id, string name, string category, decimal price, int qty, string imagePath = "")
        {
            ProductId = id;
            ProductName = name;
            Category = category;
            UnitPrice = price;
            Quantity = qty;
            ImagePath = imagePath;
        }

        public override string ToString()
        {
            return $"{ProductId} - {ProductName}";
        }
    }
}

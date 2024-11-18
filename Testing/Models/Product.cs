
using System;

namespace Testing.Models
{
    public class Product
    {
        public Product() 
        {

        }

        public int productID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int categoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }

    }
}

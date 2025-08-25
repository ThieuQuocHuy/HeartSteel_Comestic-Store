using System;

namespace Customer.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;

        public Product()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

        public Product(int id, string name, string description, decimal price, int stock, string category, string imagePath = "")
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Category = category;
            ImagePath = imagePath;
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            IsActive = true;
        }

        public void UpdateStock(int quantity)
        {
            Stock += quantity;
            UpdatedDate = DateTime.Now;
        }

        public bool CanSell(int quantity)
        {
            return IsActive && Stock >= quantity;
        }
    }
}
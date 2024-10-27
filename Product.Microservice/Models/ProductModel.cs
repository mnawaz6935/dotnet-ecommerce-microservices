namespace Product.Microservice.Models
{
    using System;

    public class ProductModel
    {
        // Essential attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public string SKU { get; set; } // Stock Keeping Unit
        public string Category { get; set; }
        public string Brand { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? LastUpdated { get; set; }

        // Optional attributes
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public decimal Discount { get; set; } // Discount as a percentage
        public decimal Weight { get; set; } // Weight in kg, lbs, etc.

        // Constructor
        public ProductModel()
        {
            DateAdded = DateTime.Now;
            IsActive = true;
        }

        // Methods
        public decimal GetDiscountedPrice()
        {
            return Price - (Price * (Discount / 100));
        }

        public void UpdateStock(int quantity)
        {
            QuantityInStock = quantity;
            LastUpdated = DateTime.Now;
        }

        public void DeactivateProduct()
        {
            IsActive = false;
            LastUpdated = DateTime.Now;
        }
    }

}

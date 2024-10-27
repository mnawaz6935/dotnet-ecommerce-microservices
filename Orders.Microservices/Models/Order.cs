namespace Orders.Microservices.Models
{
    using System;
    using System.Collections.Generic;

    public class Order
    {
        // Essential attributes
        public int OrderId { get; set; }
        public int CustomerId { get; set; } // Link to the Customer class
        public List<OrderItem> Items { get; set; } // List of items in the order
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; } // Enum for order status
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }

        // Optional attributes
        public DateTime? ShippedDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public string TrackingNumber { get; set; }
        public string Notes { get; set; }
        public bool IsPaid { get; set; }

        // Constructor
        public Order()
        {
            OrderDate = DateTime.Now;
            Status = OrderStatus.Pending;
            Items = new List<OrderItem>();
        }

        // Methods
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            TotalAmount = 0;
            foreach (var item in Items)
            {
                TotalAmount += item.GetTotalPrice();
            }
        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            if (newStatus == OrderStatus.Shipped)
                ShippedDate = DateTime.Now;
            else if (newStatus == OrderStatus.Delivered)
                DeliveredDate = DateTime.Now;
        }
    }

    // Supporting classes and enums
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal GetTotalPrice()
        {
            return Quantity * UnitPrice;
        }
    }

    public enum OrderStatus
    {
        Pending,
        Processed,
        Shipped,
        Delivered,
        Cancelled
    }

}

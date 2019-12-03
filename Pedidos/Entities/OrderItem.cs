using System;

namespace Pedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Product  Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, decimal price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public decimal SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + " $"
                + Price.ToString("F2")
                + " Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2");

        }
    }
}

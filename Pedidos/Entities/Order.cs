using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Pedidos.Entities;
using Pedidos.Entities.Enums;

namespace Pedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Staus { get; set; }
        public Cliente Cliente { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Cliente cliente)
        {
            Moment = moment;
            Staus = status;
            Cliente = cliente;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public decimal Total()
        {
            decimal sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order: status: " + Staus);
            sb.AppendLine("Client: " + Cliente);
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();
        }
    }
}

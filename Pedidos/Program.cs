using System;
using Pedidos.Entities;
using Pedidos.Entities.Enums;

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pedido de Vendas, Bem Vindo!");
            Console.WriteLine("Enter with Client data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(name, email, data);

            Console.WriteLine("Enter with Order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, cliente);

            Console.Write("How many Items to this order? ");
            int nritems = int.Parse(Console.ReadLine());
            for(int i = 0; i<nritems; i++)
            {
                Console.WriteLine($"Enter with Item #{i} data:");
                Console.Write("Item Name: ");
                string itemname = Console.ReadLine();
                Console.Write("Item Price (0,00): ");
                decimal itemprice = decimal.Parse(Console.ReadLine());
                Product product = new Product(itemname,itemprice);

                Console.Write("Item Quantity: ");
                int itemqtd = int.Parse(Console.ReadLine());
                OrderItem orderitem = new OrderItem(itemqtd, itemprice, product);
                order.AddItem(orderitem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}

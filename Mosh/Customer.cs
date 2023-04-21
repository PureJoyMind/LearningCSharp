using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharCodes
{
    public class Customer
    {
        private static readonly Random random = new Random();
        
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer() // default constructor
        {
            Orders = new List<Order>();
            Id = random.Next(255000);
            Name = string.Empty;
        }
        public Customer(string name) // sets id and name's initial value
            : this()
        {
            Name = name;
        }

        public void AddOrder(Order[] order)
        {
            foreach (var item in order)
            {
                Orders.Append(item);
            }
        }

        public void RemoveOrder(Order order)
        {
            
            Orders.Remove(order);
        }

        public void PrintOrders()
        {
            var orders = new StringBuilder();
            for(var j = 0; j <= Orders.Count-1; j++){
                orders.Append($"Order number {Orders[j].OrderId}:")
                    .AppendLine();
                int y;

                for (var i = 0; i <= Orders[j].Products.Count - 1; i++)
                {
                    y = i;
                    orders.Append($"{++y}. ")
                        .AppendLine(Orders[j].Products[i]);
                }

                orders.AppendLine();
            }

            Console.WriteLine(orders);
        }

    }
}
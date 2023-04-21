using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodes
{
    public class Order
    {
        private static readonly Random random = new Random();

        //public string Name;
        public string Name { get; set; }
        //public int OrderId;
        public int OrderId { get; private set; }
        public List<string> Products;

        public Order()
        {
            OrderId = random.Next(50000);
            Name = string.Empty;
            Products = new List<string>();
        }
        public Order(string name) 
            : this()  
        {
            Name = name;
        }

        public void PrintOrder()
        {
            var order = new StringBuilder();
            order.Append($"Order number {OrderId}:")
                .AppendLine();
            int y;

            for (var i = 0; i <= Products.Count-1; i++)
            {
                y = i;
                order.Append($"{++y}. ")
                    .AppendLine(Products[i]);
            }

            Console.WriteLine(order);
        }

        public void AddToOrder(string product)
        {
            Products.Add(product);
            Console.WriteLine($"{product} added to order number {OrderId}.");
        }

        public void RemoveFromOrder(string product)
        {
            Products.Remove(product);
            Console.WriteLine($"{product} removed from order number {OrderId}.");
        }
    }
}
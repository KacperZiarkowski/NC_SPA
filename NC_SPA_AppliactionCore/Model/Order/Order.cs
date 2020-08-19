using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Order
{
    public class Order : Entity
    
    {
        public Order(Customer.Customer customer, List<OrderItem> orderItems, string shipToAddress)
        {
            
        }

        public string BuyerId { get; private set; }
        public Address ShippingAddress{ get; private set; }

        private readonly List<OrderItem> _orderItems = new List<OrderItem>();

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

    }
}

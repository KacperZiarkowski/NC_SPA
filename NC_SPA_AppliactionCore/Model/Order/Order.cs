using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Order
{
    public partial class Order : Entity
    
    {
        public Order(Customer.Customer customer, List<OrderItem> orderItems, Address? shipToAddress)
        {
            BuyerId = customer.CustomerIdentity;
            _orderItems = orderItems;
            ShippingAddress = shipToAddress ?? customer.DeliveryAddress;
        }

        public string BuyerId { get; private set; }
        public Address ShippingAddress{ get; private set; }

        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShop_ApplicationCore.Model.Order
{
    public partial class Order : Entity
    
    {
        public Order(
            string customerId, 
            List<OrderItem> orderItems, 
            Address shippingAddress)
        {
            BuyerId = customerId;
            _orderItems = orderItems;
            ShippingAddress = shippingAddress;
        }

        [ForeignKey("BuyerId")]
        public string BuyerId { get; private set; }

        public Address ShippingAddress{ get; private set; }

        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

    }
}

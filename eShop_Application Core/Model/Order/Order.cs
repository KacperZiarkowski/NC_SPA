﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop_ApplicationCore.Model.Order
{
    public class Order : Entity
    {
        public Order()
        {
        }

        public Order(
            Guid customerGuid,
            List<OrderItem> orderItems,
            Address shippingAddress)
        {
            BuyerGuid = customerGuid;
            _orderItems = orderItems;
            ShippingAddress = shippingAddress;
        }

        [ForeignKey("BuyerGuid")]
        public Guid BuyerGuid { get; private set; }

        public Address ShippingAddress { get; private set; }

        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

    }
}

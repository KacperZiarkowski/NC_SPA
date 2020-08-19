using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace eShop_ApplicationCore.Model.Order
{
    public partial class Order : Entity
    {
        public decimal TotalCost()
        {
            var sum = 0m;
            foreach (var item in _orderItems)
            {
                sum += item.UnitPrice * item.Units;
            }
            return sum;
        }
    }
}

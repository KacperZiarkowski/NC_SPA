using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Order
{
    public partial class Order
    {
        public decimal TotalCost()
        {
            var sum = 0m;
            foreach (var item in _orderItems)
            {
                sum += item.OrderedProduct.ProductBasePrice * item.Quantity;
            }
            return sum;
        }
    }
}

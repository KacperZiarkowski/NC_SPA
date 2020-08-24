using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace eShop_ApplicationCore.Model.Basket
{
    public partial class Basket 
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

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace eShop_ApplicationCore.Model.Basket
{
    public partial class Basket
    {
        public void AddItem(
            int productId,
            decimal price,
            int quantity = 1)
        {
            if (Items.All(bi => bi.ProductId != productId))
            {
                _items.Add(new BasketItem
                {
                    Price = price,
                    ProductId = productId,
                    Quantity = quantity,
                    BasketId = this.Id
                }
                );
                return;
            }
            var existingItem = Items.FirstOrDefault(i => i.ProductId == productId);
            existingItem.Quantity += quantity;
        }


        public decimal BasketTotalCost()
        {
            var total = 0m;
            foreach (var item in _items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
    }
}

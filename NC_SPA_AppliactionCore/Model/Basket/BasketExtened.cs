using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace eShop_ApplicationCore.Model.Basket
{
    public partial class Basket
    {
        
        public void RemoveAllProducts()
        {
            _items.RemoveAll(bi => bi != null);
        }


        public decimal TotalCost()
        {
            var sum = 0m;
            foreach (var item in _items)
            {
                sum += item.Price * item.Quantity;
            }
            return sum;
        }


        public void RemoveSingleProduct(int productId)
        {
            var existedBasketItem = Items.FirstOrDefault(bi => bi.ProductId == productId && bi.Quantity > 1);
            if (existedBasketItem != null)
            {
                existedBasketItem.Quantity -= 1;
                return;
            }
            _items.RemoveAll(bi => bi.ProductId == productId);
        }

        
        public void AddProduct(
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
    }
}

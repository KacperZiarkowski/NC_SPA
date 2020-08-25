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
        private decimal _totalCost;
        [NotMapped] 
        public decimal TotalCost
        {
            get => this._totalCost;
            private set => RecalculateTotalPrice();
        }


        public void RemoveAllItems()
        {
            _items.RemoveAll(bi => bi != null);
        }


        private void RecalculateTotalPrice()
        {
            var total = 0m;
            foreach (var item in _items)
            {
                total += item.Price * item.Quantity;
            }
            _totalCost = total;
        }


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
                RecalculateTotalPrice();
                return;
            }
            var existingItem = Items.FirstOrDefault(i => i.ProductId == productId);
            existingItem.Quantity += quantity;
            RecalculateTotalPrice();
        }
    }
}

using eShop_ApplicationCore.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop_ApplicationCore.Model.Basket
{
    public partial class Basket : Entity
    {
        public Basket()
        {
            
        }
        public string BuyerId { get; private set; }
        private readonly List<BasketItem> _items = new List<BasketItem>();
        public IReadOnlyCollection<BasketItem> Items => _items.AsReadOnly();

        public void AddItem(int productId, decimal price, int quantity = 1)
        {
            if (Items.All(bi => bi.ProductId != productId))
            {
                _items.Add(new BasketItem
                    {
                        Price = price,
                        ProductId = productId,
                        Quantity = quantity
                    }
                );
                return;
            }
            var existingItem = Items.First(i => i.ProductId == productId);
            if (existingItem != null) existingItem.Quantity += quantity;
        }
        
    }
}

using System;
using System.Collections.Generic;

namespace eShop_ApplicationCore.Model.Basket
{
    public partial class Basket : Entity
    {
        
        public Guid BuyerGuid { get; set; }


        private readonly List<BasketItem> _items = new List<BasketItem>();


        public IReadOnlyCollection<BasketItem> Items => _items.AsReadOnly();
    }
}

using eShop_ApplicationCore.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop_ApplicationCore.Model.Basket
{
    public partial class Basket : Entity
    {
        public Basket(Guid buyerGuid)
        {
            BuyerGuid = buyerGuid;
        }

        public Guid BuyerGuid { get; set; }

        private readonly List<BasketItem> _items = new List<BasketItem>();

        public IReadOnlyCollection<BasketItem> Items => _items.AsReadOnly();
    }
}

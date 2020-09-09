using System;
using System.Collections.Generic;

namespace eShop_ApplicationCore.Model.Basket
{
    /// <summary>
    /// Represents a basket
    /// </summary>
    public partial class Basket : Entity
    {
        /// <summary>
        /// Gets or sets a user guid which owns this basket
        /// </summary>
        public Guid BuyerGuid { get; set; }

        /// <summary>
        /// A private collection which helps with Basket encapsulation
        /// Basket items could be added only through Order methods
        /// </summary>
        private readonly List<BasketItem> _items = new List<BasketItem>();

        /// <summary>
        /// Using List.AsReadOnly() protects private list against external updates
        /// Better performance than ToList() because it will not have to copy all items in a new collection
        /// </summary>
        public IReadOnlyCollection<BasketItem> Items => _items.AsReadOnly();
    }
}

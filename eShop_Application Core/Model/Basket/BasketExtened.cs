using System.Linq;

namespace eShop_ApplicationCore.Model.Basket
{
    /// <summary>
    /// Represents a basket
    /// </summary>
    public partial class Basket
    {
        /// <summary>
        /// Removes all products from the basket
        /// </summary>
        public void RemoveAllItems()
        {
            _items.RemoveAll(bi => bi != null);
        }

        /// <summary>
        /// Removes all products with a quantity equal to zero
        /// </summary>
        public void RemoveEmptyItems()
        {
            _items.RemoveAll(bi => bi.Quantity == 0);
        }

        /// <summary>
        /// Calculate the total cost of products in the basket
        /// </summary>
        public decimal TotalCost()
        {
            var sum = 0m;
            foreach (var item in _items)
            {
                sum += item.BasePrice * item.Quantity;
            }
            return sum;
        }

        /// <summary>
        /// Remove a single product from the basket
        /// If the quantity of product is more than one, it reduces the quantity of a product by one
        /// <param name="basketItemId">Basket item identifier</param>
        /// </summary>
        public void RemoveSingleItem(int basketItemId)
        {
            var existedBasketItem = Items.FirstOrDefault(bi => bi.BasketItemId == basketItemId && bi.Quantity > 1);
            if (existedBasketItem != null)
            {
                existedBasketItem.Quantity -= 1;
                return;
            }
            _items.RemoveAll(bi => bi.BasketItemId == basketItemId);
        }

        /// <summary>
        /// Adds product to an existing cart
        /// <param name="productId">Product identifier</param>
        /// <param name="price">Product unit price</param>
        /// <param name="quantity">Number of products added, by default 1</param>
        /// </summary>
        public void AddItem(
            int basketItemId,
            decimal price,
            int quantity = 1)
        {
            if (Items.All(bi => bi.BasketItemId != basketItemId))
            {
                _items.Add(new BasketItem
                    {
                        BasePrice = price,
                        BasketItemId = basketItemId,
                        Quantity = quantity,
                        BasketId = this.Id
                    }
                );
              
                return;
            }
            var existingItem = Items.FirstOrDefault(i => i.BasketItemId == basketItemId);
            
            existingItem.Quantity += quantity;
        }
    }
}

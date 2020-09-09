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
        public void RemoveAllProducts()
        {
            _items.RemoveAll(bi => bi != null);
        }

        /// <summary>
        /// Calculate the total cost of products in the basket
        /// </summary>
        public decimal TotalCost()
        {
            var sum = 0m;
            foreach (var item in _items)
            {
                sum += item.Price * item.Quantity;
            }
            return sum;
        }

        /// <summary>
        /// Remove a single product from the basket
        /// If the quantity of product is more than one, it reduces the quantity of a product by one
        /// <param name="productId">Product identifier</param>
        /// </summary>
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

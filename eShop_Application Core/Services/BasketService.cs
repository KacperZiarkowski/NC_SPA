using System;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using eShop_ApplicationCore.Interfaces;
using eShop_ApplicationCore.Interfaces.DbContext;
using eShop_ApplicationCore.Model.Basket;

namespace eShop_ApplicationCore.Services
{

    public class BasketService : IBasketService
    {
        #region Fields

        private readonly IBasketDbContext _basketDbContext;
        private readonly IAppLogger<BasketService> _appLogger;

        #endregion

        #region Ctor

        public BasketService(
            IBasketDbContext basketDbContext,
            IAppLogger<BasketService> appLogger)
        {
            _basketDbContext = basketDbContext;
            _appLogger = appLogger;
        }

        #endregion

        #region Methods
        public async Task ClearBasket(int basketId)
        {
            var basket = await _basketDbContext.Baskets.FindAsync(basketId);

            basket?.RemoveAllItems();

            await _basketDbContext.UpdateAsync(basket);
        }


        public async Task AddProductToBasket(int basketId, int productId, decimal productPrice, int quantity = 1)
        {
            var basket = await _basketDbContext.Baskets.FindAsync(basketId);

            if (basket is null)
                throw new ArgumentNullException(nameof(basket));

            basket.AddProduct(productId, productPrice, quantity);

            await _basketDbContext.UpdateAsync(basket);
        }


        public async Task SetQuantity(int basketId, int productId, int quantity)
        {
            var basket = await _basketDbContext.Baskets.FindAsync(basketId);

            if (basket is null)
                throw new ArgumentNullException(nameof(basket));
            
            var productForQuantityChange = basket.Items.First(bi => bi.BasketItemId == productId);

            if (productForQuantityChange != null)
                productForQuantityChange.Quantity = quantity;

            basket.RemoveEmptyProducts();

            await _basketDbContext.UpdateAsync(basket);
        }

        #endregion
    }
}

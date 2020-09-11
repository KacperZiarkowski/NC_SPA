using System;
using System.Threading.Tasks;
using System.Xml.Linq;
using eShop_ApplicationCore.Interfaces;
using eShop_ApplicationCore.Interfaces.DbContext;
using eShop_ApplicationCore.Model.Basket;

namespace eShop_ApplicationCore.Services
{

    public class BasketService : IBasketService
    {
        private readonly IEShopDbContext _eShopDbContext;

        public async Task AddProductToBasket(int basketId, int productId, decimal productPrice, int quantity = 1)
        {
            var basket = await _eShopDbContext.Baskets.FindAsync(basketId);
           
            if (basket is null)
                throw new ArgumentNullException(nameof(basket));
            
            basket.AddProduct(productId, productPrice, quantity);
            
            await _eShopDbContext.UpdateAsync(basket);
        }
    }
}

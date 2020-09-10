using System.Threading.Tasks;
using eShop_ApplicationCore.Interfaces.DbContext;

namespace eShop_ApplicationCore.Services
{
   
    public class BasketService
    {
        private readonly IEShopDbContext _eShopDbContext;

        public async Task AddProductToBasket(int basketId, int productId, decimal productPrice,int quantity = 1)
        {
            var basket = _eShopDbContext.Baskets.
        }
    }
}

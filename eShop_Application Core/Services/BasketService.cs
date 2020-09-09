using eShop_ApplicationCore.Model.Interfaces.DbContext;
using System.Threading.Tasks;

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

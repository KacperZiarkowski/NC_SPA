using eShop_ApplicationCore.Model.Basket;
using Microsoft.EntityFrameworkCore;

namespace eShop_ApplicationCore.Interfaces.DbContext
{
    /// <summary>
    /// Represents basket context
    /// </summary>
    public interface IBasketDbContext : IEShopDbContextBaseAsyncOperations
    {
        DbSet<Model.Basket.Basket> Baskets { get; set; }

        DbSet<BasketItem> BasketItems { get; set; }
    }
}

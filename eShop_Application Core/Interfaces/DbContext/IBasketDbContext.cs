using System.Data.Entity;
using eShop_ApplicationCore.Model.Basket;

namespace eShop_ApplicationCore.Interfaces.DbContext
{
    public interface IBasketDbContext
    {
        DbSet<Model.Basket.Basket> Baskets { get; set; }

        DbSet<BasketItem> BasketItems { get; set; }
    }
}

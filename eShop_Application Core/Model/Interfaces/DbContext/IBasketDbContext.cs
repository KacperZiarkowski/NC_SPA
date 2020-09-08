using eShop_ApplicationCore.Model.Basket;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace eShop_ApplicationCore.Model.Interfaces.DbContext
{
    public interface IBasketDbContext
    {
        DbSet<Basket.Basket> Baskets { get; set; }

        DbSet<BasketItem> BasketItems { get; set; }
    }
}

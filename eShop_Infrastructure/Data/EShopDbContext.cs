using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using eShop_ApplicationCore.Interfaces.DbContext;
using eShop_ApplicationCore.Model;
using eShop_ApplicationCore.Model.Basket;
using eShop_ApplicationCore.Model.Order;
using eShop_ApplicationCore.Model.Product;
using eShop_ApplicationCore.Model.Tax;

namespace eShop_Infrastructure.Data
{
    /// <summary>
    /// Application DbContext
    /// </summary>
    class EShopDbContext : IEShopDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Vat> Taxes { get; set; }
        public DbSet<VatRule> VatRules { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public Task UpdateAsync(Entity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Entity entity)
        {
            throw new NotImplementedException();
        }

        public Task<Entity> AddAsync(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
